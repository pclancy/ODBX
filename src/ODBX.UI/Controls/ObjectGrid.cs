using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ODBX.Controls
{
    public class ObjectGrid : DataGridView
    {
    }

    [DefaultEvent("DisplayGroup")]
    public class DataGridViewGrouper : Component, IGrouper
    {
        private readonly GroupingSource _source = new GroupingSource();
        private DataGridView _grid;

        public DataGridViewGrouper()
        {
            _source.DataSourceChanged += SourceDataSourceChanged;
            _source.GroupingChanged += SourceGroupingChanged;
        }

        public DataGridViewGrouper(DataGridView grid)
            : this()
        {
            DataGridView = grid;
        }

        public DataGridViewGrouper(IContainer container)
            : this()
        {
            container.Add(this);
        }

        [DefaultValue(null)]
        public DataGridView DataGridView
        {
            get { return _grid; }
            set
            {
                if (_grid == value) return;
                if (_grid != null)
                {
                    _grid.Sorted -= GridSorted;
                    _grid.RowPrePaint -= GridRowPrePaint;
                    _grid.RowPostPaint -= GridRowPostPaint;
                    _grid.CellBeginEdit -= GridCellBeginEdit;
                    _grid.CellDoubleClick -= GridCellDoubleClick;
                    _grid.CellClick -= GridCellClick;
                    _grid.MouseMove -= GridMouseMove;
                    _grid.SelectionChanged -= GridSelectionChanged;
                }
                RemoveGrouping();
                _selectedrows.Clear();
                _grid = value;
                if (_grid != null)
                {
                    _grid.Sorted += GridSorted;
                    _grid.RowPrePaint += GridRowPrePaint;
                    _grid.RowPostPaint += GridRowPostPaint;
                    _grid.CellBeginEdit += GridCellBeginEdit;
                    _grid.CellDoubleClick += GridCellDoubleClick;
                    _grid.CellClick += GridCellClick;
                    _grid.MouseMove += GridMouseMove;
                    _grid.SelectionChanged += GridSelectionChanged;
                }
            }
        }

        public GroupingSource GroupingSource
        {
            get { return _source; }
        }

        private bool GridUsesGroupSource
        {
            get { return _grid != null && _grid.DataSource == _source; }
        }

        public bool IsGrouped
        {
            get { return _source.GroupOn != null; }
        }

        [DefaultValue(SortOrder.Ascending)]
        public SortOrder SortOrder
        {
            get { return _source.GroupSortDirection; }
            set { _source.GroupSortDirection = value; }
        }

        public bool CurrentRowIsGroupRow
        {
            get
            {
                if (_grid == null || _grid.CurrentCell == null) return false;
                return IsGroupRow(_grid.CurrentCell.RowIndex);
            }
        }

        #region Select /  Collapse/Expand

        /// <summary>
        /// selected rows are kept seperately in order to invalidate the entire row
        /// and not just one cell when the selection is changed
        /// </summary>
        private readonly List<int> _selectedrows = new List<int>();

        private Point _capturedcollapsebox = new Point(-1, -1);

        private void GridMouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < HeaderOffset && e.X >= HeaderOffset - Collapseboxwidth)
            {
                DataGridView.HitTestInfo ht = _grid.HitTest(e.X, e.Y);
                if (IsGroupRow(ht.RowIndex))
                {
                    int y = e.Y - ht.RowY;
                    if (y >= CollapseBoxYOffset && y <= CollapseBoxYOffset + Collapseboxwidth)
                    {
                        Checkcollapsedfocused(ht.ColumnIndex, ht.RowIndex);
                        return;
                    }
                }
            }
            Checkcollapsedfocused(-1, -1);
        }

        private void InvalidateCapturedBox()
        {
            if (_capturedcollapsebox.Y == -1) return;
            _grid.InvalidateCell(_capturedcollapsebox.X, _capturedcollapsebox.Y);
        }

        private void Checkcollapsedfocused(int col, int row)
        {
            if (_capturedcollapsebox.X != col || _capturedcollapsebox.Y != row)
            {
                InvalidateCapturedBox();
                _capturedcollapsebox = new Point(col, row);
                InvalidateCapturedBox();
            }
        }

        private void GridCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            if (e.RowIndex == _capturedcollapsebox.Y)
            {
                bool show = IsCollapsed(e.RowIndex);
                CollapseExpand(e.RowIndex, show);
                if (show)
                    _grid.CurrentCell = _grid[1, e.RowIndex + 1];
            }
        }

        private void GridSelectionChanged(object sender, EventArgs e)
        {
            Invalidateselected();
            _selectedrows.Clear();
            foreach (DataGridViewCell c in _grid.SelectedCells)
                if (IsGroupRow(c.RowIndex))
                    _selectedrows.Add(c.RowIndex);
            Invalidateselected();
        }

        private void Invalidateselected()
        {
            if (_selectedrows.Count == 0 || _grid.SelectionMode == DataGridViewSelectionMode.FullRowSelect) return;
            foreach (int i in _selectedrows)
                _grid.InvalidateRow(i);
        }


        private bool IsCollapsed(int index)
        {
            if (++index >= _grid.Rows.Count) return false;
            return !_grid.Rows[index].Visible;
        }

        private void CollapseExpand(int index, bool show)
        {
            _grid.SuspendLayout();
            foreach (DataGridViewRow row in GetRows(index))
                row.Visible = show;
            _grid.ResumeLayout();
        }

        public void ExpandAll()
        {
            CollapseExpandAll(true);
        }

        public void CollapseAll()
        {
            CollapseExpandAll(false);
        }

        private void CollapseExpandAll(bool show)
        {
            if (_grid == null || !GridUsesGroupSource) return;
            _grid.SuspendLayout();
            _source.SuspendBinding();
            int cnt = _source.Count;
            for (int i = 0; i < cnt; i++)
            {
                if (!IsGroupRow(i))
                    _grid.Rows[i].Visible = show;
            }
            _grid.ResumeLayout();
            _source.ResumeBinding();
        }

        private void GridCellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsGroupRow(e.RowIndex))
            {
                CollapseExpand(e.RowIndex, true);
                _grid.SuspendLayout();
                _grid.CurrentCell = _grid[1, e.RowIndex + 1];
                _grid.Rows[e.RowIndex].Selected = false;
                SelectGroup(e.RowIndex);
                _grid.ResumeLayout();
            }
        }

        private IEnumerable<DataGridViewRow> GetRows(int index)
        {
            while (!IsGroupRow(++index) && index < _source.Count)
                yield return _grid.Rows[index];
        }

        private void SelectGroup(int offset)
        {
            foreach (DataGridViewRow row in GetRows(offset))
                row.Selected = true;
        }

        #endregion

        #region IGrouper Members

        public event EventHandler PropertiesChanged;

        public IEnumerable<PropertyDescriptor> GetProperties()
        {
            foreach (PropertyDescriptor pd in _source.GetItemProperties(null))
                yield return pd;
        }

        public void RemoveGrouping()
        {
            if (GridUsesGroupSource)
                try
                {
                    _grid.DataSource = _source.DataSource;
                    _grid.DataMember = _source.DataMember;
                    _source.RemoveGrouping();
                }
                catch
                {
                }
        }

        public event EventHandler GroupingChanged;

        [DefaultValue(null)]
        public GroupingInfo GroupOn
        {
            get { return _source.GroupOn; }
            set
            {
                if (GroupOn == value) return;
                if (value == null)
                    RemoveGrouping();
                else
                    CheckSource().GroupOn = value;
            }
        }

        public void SetGroupOn(PropertyDescriptor property)
        {
            if (property == null) throw new ArgumentNullException("property");
            CheckSource().SetGroupOn(property);
        }

        public void SetGroupOn(string name)
        {
            if (string.IsNullOrEmpty(name))
                RemoveGrouping();
            else
                CheckSource().SetGroupOn(name);
        }

        #endregion

        public IEnumerable<IGroupRow> GetGroups()
        {
            return _source.GetGroups();
        }

        public bool IsGroupRow(int index)
        {
            return _source.IsGroupRow(index);
        }

        private void SourceDataSourceChanged(object sender, EventArgs e)
        {
            if (PropertiesChanged != null)
                PropertiesChanged(this, e);
        }

        private void GridCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (IsGroupRow(e.RowIndex))
                e.Cancel = true;
        }

        protected override void Dispose(bool disposing)
        {
            DataGridView = null;
            _source.Dispose();
            base.Dispose(disposing);
        }

        private void GridSorted(object sender, EventArgs e)
        {
            _capturedcollapsebox = new Point(-1, -1);
            ResetGrouping();
        }

        private void SourceGroupingChanged(object sender, EventArgs e)
        {
            OnGroupOnChanged();
        }

        private void OnGroupOnChanged()
        {
            if (GroupingChanged != null)
                GroupingChanged(this, EventArgs.Empty);
        }

        public void ResetGrouping()
        {
            if (!GridUsesGroupSource) return;
            _source.ResetGroup();
        }


        public void SetGroupOn(DataGridViewColumn col)
        {
            SetGroupOn(col == null ? null : col.DataPropertyName);
        }

        public void SetGroupOn(GroupingDelegate gd)
        {
            CheckSource().SetGroupOn(gd);
        }

        public void SetGroupOnStartLetters(GroupingInfo g, int Letters)
        {
            CheckSource().SetGroupOnStartLetters(g, Letters);
        }

        public void SetGroupOnStartLetters(string Property, int Letters)
        {
            CheckSource().SetGroupOnStartLetters(Property, Letters);
        }

        private GroupingSource CheckSource()
        {
            if (_grid == null)
                throw new Exception("No target datagridview set");
            if (!GridUsesGroupSource)
            {
                _source.DataSource = _grid.DataSource;
                _source.DataMember = _grid.DataMember;
                _grid.DataSource = _source;
            }
            return _source;
        }

        #region Painting

        private const int Collapseboxwidth = 10;
        private const int Lineoffset = Collapseboxwidth / 2;
        private const int CollapseBoxYOffset = 5;

        private readonly Pen _linepen = Pens.SteelBlue;
        private bool _showcount = true;

        private bool _showheader = true;

        private int HeaderOffset
        {
            get
            {
                if (_grid.RowHeadersVisible) return _grid.RowHeadersWidth - Lineoffset;
                return Lineoffset * 4;
            }
        }

        private bool DrawExpandCollapseLines
        {
            get { return _grid.RowHeadersVisible; }
        }

        [DefaultValue(true)]
        public bool ShowGroupName
        {
            get { return _showheader; }
            set
            {
                if (_showheader == value) return;
                _showheader = value;
                if (_grid != null) _grid.Invalidate();
            }
        }

        [DefaultValue(true)]
        public bool ShowCount
        {
            get { return _showcount; }
            set
            {
                if (_showcount == value) return;
                _showcount = value;
                if (_grid != null) _grid.Invalidate();
            }
        }

        private void GridRowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (IsGroupRow(e.RowIndex))
            {
                e.Handled = true;
                PaintGroupRow(e);
            }
        }

        private void GridRowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            if (!DrawExpandCollapseLines || e.RowIndex >= _source.Count) return;
            int next = e.RowIndex + 1;
            int r = _grid.RowHeadersWidth;
            int x = HeaderOffset - Lineoffset;
            int y = e.RowBounds.Top + e.RowBounds.Height / 2;
            e.Graphics.DrawLine(_linepen, x, y, r, y);
            if (next < _source.Count && !IsGroupRow(next))
                y = e.RowBounds.Bottom;
            e.Graphics.DrawLine(_linepen, x, e.RowBounds.Top, x, y);
        }

        /// <summary>
        /// This event is fired when the group row has to be painted and the display values are requested
        /// </summary>
        public event EventHandler<GroupDisplayEventArgs> DisplayGroup;

        private GroupDisplayEventArgs GetDisplayValues(DataGridViewRowPrePaintEventArgs pe)
        {
            var row = _source[pe.RowIndex] as IGroupRow;
            var e = new GroupDisplayEventArgs(row, _source.GroupOn);
            bool selected = _selectedrows.Contains(pe.RowIndex);
            e.Selected = selected;
            e.BackColor = selected ? _grid.DefaultCellStyle.SelectionBackColor : _grid.DefaultCellStyle.BackColor;
            e.ForeColor = selected ? _grid.DefaultCellStyle.SelectionForeColor : _grid.DefaultCellStyle.ForeColor;
            e.Font = pe.InheritedRowStyle.Font;
            if (_showcount)
                e.Summary = "(" + row.Count + ")";
            if (_showheader)
                e.Header = _source.GroupOn.ToString();
            e.GroupingInfo.SetDisplayValues(e);
            if (e.Cancel) return null;
            if (DisplayGroup != null)
            {
                DisplayGroup(this, e);
                if (e.Cancel) return null;
            }
            return e;
        }

        private void PaintGroupRow(DataGridViewRowPrePaintEventArgs e)
        {
            GroupDisplayEventArgs info = GetDisplayValues(e);
            if (info == null) return; //cancelled
            Rectangle r = e.RowBounds;
            r.X = 1;
            r.Height--;
            using (var b = new SolidBrush(info.BackColor))
                e.Graphics.FillRectangle(b, r);
            //line under the group row
            e.Graphics.DrawLine(Pens.SteelBlue, r.Left, r.Bottom, r.Right, r.Bottom);
            //collapse/expand symbol               
            {
                Rectangle cer = GetCollapseBoxBounds(e.RowBounds.Y);
                if (_capturedcollapsebox.Y == e.RowIndex)
                    e.Graphics.FillEllipse(Brushes.Yellow, cer);
                e.Graphics.DrawEllipse(_linepen, cer);
                bool collapsed = IsCollapsed(e.RowIndex);
                int cx;
                if (DrawExpandCollapseLines && !collapsed)
                {
                    cx = HeaderOffset - Lineoffset;
                    e.Graphics.DrawLine(_linepen, cx, cer.Bottom, cx, r.Bottom);
                }
                cer.Inflate(-2, -2);
                int cy = cer.Y + cer.Height / 2;
                e.Graphics.DrawLine(_linepen, cer.X, cy, cer.Right, cy);
                if (collapsed)
                {
                    cx = cer.X + cer.Width / 2;
                    e.Graphics.DrawLine(_linepen, cx, cer.Top, cx, cer.Bottom);
                }
            }
            //group value
            {
                r.X = HeaderOffset + 1;


                using (var fb = new SolidBrush(info.ForeColor))
                {
                    var sf = new StringFormat { LineAlignment = StringAlignment.Center };
                    if (info.Header != null)
                    {
                        SizeF size = e.Graphics.MeasureString(info.Header, info.Font);
                        e.Graphics.DrawString(info.Header, info.Font, fb, r, sf);
                        r.Offset((int)size.Width + 5, 0);
                    }
                    if (info.DisplayValue != null)
                    {
                        using (var f = new Font(info.Font.FontFamily, info.Font.Size + 2, FontStyle.Bold))
                        {
                            SizeF size = e.Graphics.MeasureString(info.DisplayValue, f);
                            e.Graphics.DrawString(info.DisplayValue, f, fb, r, sf);
                            r.Offset((int)size.Width + 10, 0);
                        }
                    }
                    if (info.Summary != null)
                    {
                        e.Graphics.DrawString(info.Summary, info.Font, fb, r, sf);
                    }
                }
            }
        }

        private Rectangle GetCollapseBoxBounds(int yOffset)
        {
            return new Rectangle(HeaderOffset - Collapseboxwidth, yOffset + CollapseBoxYOffset, Collapseboxwidth,
                                 Collapseboxwidth);
        }

        #endregion
    }

    public class GroupDisplayEventArgs : CancelEventArgs
    {
        public readonly GroupingInfo GroupingInfo;
        public readonly IGroupRow Row;

        public GroupDisplayEventArgs(IGroupRow row, GroupingInfo info)
        {
            this.Row = row;
            GroupingInfo = info;
        }

        public object Value
        {
            get { return Row.Value; }
        }

        public string DisplayValue { get; set; }
        public string Header { get; set; }
        public string Summary { get; set; }
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public Font Font { get; set; }
        public bool Selected { get; internal set; }
    }

    public interface IGroupRow
    {
        int Index { get; }
        object Value { get; }
        int Count { get; }
        object[] Rows { get; }
    }

    [DefaultEvent("GroupingChanged")]
    public class GroupingSource : BindingSource
    {
        private BindingSource bsource;
        private GroupingInfo groupon;
        private GroupInfo info;
        private SortOrder order = SortOrder.Ascending;
        private PropertyDescriptorCollection props;
        private bool suspendlistchange;

        public GroupingSource()
        {
        }

        public GroupingSource(object DataSource)
            : this()
        {
            this.DataSource = DataSource;
        }

        public GroupingSource(object DataSource, string GroupOn)
            : this(DataSource)
        {
        }

        [DefaultValue(null)]
        public GroupingInfo GroupOn
        {
            get { return groupon; }
            set
            {
                if (groupon == value) return;
                RemoveGrouping(value == null);
                if (value != null)
                {
                    if (value.Equals(groupon)) return;
                    groupon = value;
                    OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
                    OnGroupingChanged();
                }
            }
        }

        [DefaultValue(SortOrder.Ascending)]
        public SortOrder GroupSortDirection
        {
            get { return order; }
            set
            {
                if (order == value) return;
                order = value;
                ResetGroup();
            }
        }

        private GroupInfo Info
        {
            get
            {
                if (info == null)
                {
                    info = new GroupInfo(this);
                    if (bsource != null)
                        SyncWithBSource();
                }
                return info;
            }
        }

        private bool NeedSync
        {
            get
            {
                if (bsource == null || suspendlistchange) return false;
                if (bsource.IsBindingSuspended) return false;
                return Current != bsource.Current;
            }
        }

        public int BaseCount
        {
            get { return base.Count; }
        }

        public override int Count
        {
            get { return Info.TotalCount; }
        }

        public override object this[int index]
        {
            get { return Info.Rows[index]; }
            set { Info.Rows[index] = value; }
        }

        public void RemoveGrouping()
        {
            RemoveGrouping(true);
        }

        private void RemoveGrouping(bool callListChanged)
        {
            if (groupon == null) return;
            groupon = null;
            ResetGroup();
            if (callListChanged)
            {
                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
                OnGroupingChanged();
            }
        }

        public void SetGroupOn(string Property)
        {
            SetGroupOn(GetProperty(Property));
        }

        private PropertyDescriptor GetProperty(string Name)
        {
            PropertyDescriptor pd = GetItemProperties(null)[Name];
            if (pd == null)
                throw new Exception(Name + " is not a valid property");
            return pd;
        }

        public void SetGroupOn(PropertyDescriptor p)
        {
            if (p == null) throw new ArgumentNullException();
            if (groupon == null || !groupon.IsProperty(p))
                GroupOn = new PropertyGrouper(p);
        }

        public void SetGroupOn(GroupingDelegate gd)
        {
            SetGroupOn(gd, null);
        }

        public void SetGroupOn(GroupingDelegate gd, string descr)
        {
            if (gd == null) throw new ArgumentNullException();
            GroupOn = new DelegateGrouper(gd, descr);
        }

        public void SetGroupOnStartLetters(GroupingInfo g, int Letters)
        {
            GroupOn = new StartLetterGrouper(g, Letters);
        }

        public void SetGroupOnStartLetters(string Property, int Letters)
        {
            SetGroupOnStartLetters(GetProperty(Property), Letters);
        }

        public bool IsGroupRow(int Index)
        {
            if (info == null) return false;
            if (Index < 0 || Index >= Count) return false;
            return info.Rows[Index] is GroupRow;
        }


        public IEnumerable<IGroupRow> GetGroups()
        {
            foreach (IGroupRow g in Info.Groups.Values)
                yield return g;
        }

        private void OnGroupingChanged()
        {
            if (GroupingChanged != null)
                GroupingChanged(this, EventArgs.Empty);
        }

        public event EventHandler GroupingChanged;

        public void ResetGroup()
        {
            info = null;
        }

        private void DisposeBindingSourceEvents()
        {
            if (bsource == null) return;
            bsource.CurrentChanged -= bsource_CurrentChanged;
        }

        protected override void Dispose(bool disposing)
        {
            DisposeBindingSourceEvents();
            base.Dispose(disposing);
        }

        protected override void OnDataSourceChanged(EventArgs e)
        {
            ResetGroup();
            DisposeBindingSourceEvents();
            bsource = DataSource as BindingSource;
            if (bsource != null)
            {
                bsource.CurrentChanged += bsource_CurrentChanged;
                if (NeedSync) SyncWithBSource();
            }
            base.OnDataSourceChanged(e);
        }

        protected override void OnListChanged(ListChangedEventArgs e)
        {
            if (suspendlistchange) return;

            switch (e.ListChangedType)
            {
                case ListChangedType.ItemChanged:
                    if (groupon != null && groupon.IsProperty(e.PropertyDescriptor))
                        ResetGroup();
                    break;
                case ListChangedType.ItemAdded:
                    if (info != null)
                        info.Rows.Add(List[e.NewIndex]);
                    break;
                case ListChangedType.ItemDeleted:
                    ResetGroup();
                    break;
                case ListChangedType.Reset:
                    ResetGroup();
                    break;
                case ListChangedType.PropertyDescriptorAdded:
                case ListChangedType.PropertyDescriptorChanged:
                case ListChangedType.PropertyDescriptorDeleted:
                    props = null;
                    break;
            }
            base.OnListChanged(e);
        }

        public override object AddNew()
        {
            suspendlistchange = true;
            try
            {
                object res = base.AddNew();
                if (info != null)
                    info.Rows.Add(res);
                return res;
            }
            finally
            {
                suspendlistchange = false;
            }
        }

        public override void ApplySort(PropertyDescriptor property, ListSortDirection sort)
        {
            if (property is PropertyWrapper)
                property = (property as PropertyWrapper).Property;
            base.ApplySort(property, sort);
        }

        public override void ApplySort(ListSortDescriptionCollection sorts)
        {
            base.ApplySort(sorts);
        }


        public override void RemoveAt(int index)
        {
            if (info == null || groupon == null)
                base.RemoveAt(index);
            else if (!IsGroupRow(index))
            {
                int i = List.IndexOf(this[index]);
                suspendlistchange = true;
                try
                {
                    info.Rows.RemoveAt(index);
                    List.RemoveAt(i);
                    base.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemDeleted, index));
                }
                finally
                {
                    suspendlistchange = false;
                }
            }
        }


        public override void Remove(object value)
        {
            if (value is GroupRow) return;
            int index = IndexOf(value);
            if (index != -1)
            {
                RemoveAt(index);
            }
        }

        protected override void OnCurrentChanged(EventArgs e)
        {
            base.OnCurrentChanged(e);
            if (NeedSync && !(Current is GroupRow))
            {
                bsource.Position = bsource.IndexOf(Current);
            }
        }

        private void bsource_CurrentChanged(object sender, EventArgs e)
        {
            if (NeedSync)
                SyncWithBSource();
        }

        private void SyncWithBSource()
        {
            Position = IndexOf(bsource.Current);
        }

        public override int IndexOf(object value)
        {
            return Info.Rows.IndexOf(value);
        }

        public override PropertyDescriptorCollection GetItemProperties(PropertyDescriptor[] listAccessors)
        {
            if (listAccessors == null)
            {
                if (props == null)
                {
                    /*
                    props = new PropertyDescriptorCollection(
                    base.GetItemProperties(null).Cast<PropertyDescriptor>()
                    .Select(pd => new PropertyWrapper(pd, this)).ToArray());*/
                    props = base.GetItemProperties(null);
                    var arr = new PropertyDescriptor[props.Count];
                    for (int i = 0; i < props.Count; i++)
                    {
                        arr[i] = new PropertyWrapper(props[i], this);
                    }
                    props = new PropertyDescriptorCollection(arr);
                }
                return props;
            }
            return base.GetItemProperties(listAccessors);
        }

        public object GetBaseRow(int Index)
        {
            return List[Index];
        }

        #region Nested type: GroupInfo

        private class GroupInfo
        {
            public readonly GroupingSource Owner;
            public IDictionary<object, GroupRow> Groups;
            public IList Rows;

            public GroupInfo(GroupingSource Owner)
            {
                this.Owner = Owner;
                set();
            }

            public int TotalCount
            {
                get { return Rows.Count; }
            }

            private void set()
            {
                Groups = null;
                GroupingInfo gi = Owner.groupon;
                if (gi == null)
                {
                    Rows = Owner.List;
                    return;
                }
                if (Owner.GroupSortDirection == SortOrder.None)
                    Groups = new Dictionary<object, GroupRow>();
                else
                {
                    var comparer = new ODBX.Controls.GenericComparer<object>();
                    comparer.Descending = Owner.GroupSortDirection == SortOrder.Descending;
                    Groups = new SortedDictionary<object, GroupRow>(comparer);
                }
                foreach (object row in Owner)
                {
                    object key = gi.GetGroupValue(row);
                    GroupRow gr;
                    if (!Groups.TryGetValue(key, out gr))
                    {
                        gr = new GroupRow();
                        gr.Value = key;
                        Groups.Add(key, gr);
                    }
                    gr.List.Add(row);
                }

                //var groups = Owner.Cast<object>().GroupBy<object, object>(o => gr.GetGroupValue(o));
                int i = 0;
                Rows = new List<object>(Groups.Count + Owner.BaseCount);
                foreach (GroupRow g in Groups.Values)
                {
                    g.Finalize(i++);
                    Rows.Add(g);
                    foreach (object row in g.Rows)
                        Rows.Add(row);
                }
            }
        }

        #endregion

        #region Nested type: GroupRow

        private class GroupRow : IGroupRow
        {
            internal List<object> List = new List<object>();

            #region IGroupRow Members

            public int Index { get; set; }
            public object Value { get; set; }
            public object[] Rows { get; set; }

            public int Count
            {
                get { return Rows.Length; }
            }

            #endregion

            public void Finalize(int Index)
            {
                this.Index = Index;
                Rows = List.ToArray();
                List = null;
            }
        }

        #endregion

        #region Nested type: PropertyWrapper

        public class PropertyWrapper : PropertyDescriptor
        {
            public readonly GroupingSource Owner;
            public readonly PropertyDescriptor Property;

            public PropertyWrapper(PropertyDescriptor Property, GroupingSource Owner)
                : base(Property)
            {
                this.Property = Property;
                this.Owner = Owner;
            }

            public override Type ComponentType
            {
                get { return Property.ComponentType; }
            }

            public override bool IsReadOnly
            {
                get { return Property.IsReadOnly; }
            }

            public override Type PropertyType
            {
                get { return Property.PropertyType; }
            }

            public override bool CanResetValue(object component)
            {
                return Property.CanResetValue(component);
            }

            public override object GetValue(object component)
            {
                if (component is GroupRow)
                {
                    if (Owner.groupon.IsProperty(Property))
                        return (component as GroupRow).Value;
                    return null;
                }
                return Property.GetValue(component);
            }

            public override void ResetValue(object component)
            {
                Property.ResetValue(component);
            }

            public override void SetValue(object component, object value)
            {
                Property.SetValue(component, value);
            }

            public override bool ShouldSerializeValue(object component)
            {
                return Property.ShouldSerializeValue(component);
            }
        }

        #endregion
    }

    #region Grouping Info objects

    public abstract class GroupingInfo
    {
        public abstract object GetGroupValue(object Row);

        public virtual bool IsProperty(PropertyDescriptor p)
        {
            return false;
        }

        public virtual bool IsProperty(string Name)
        {
            return Name == ToString();
        }

        public static implicit operator GroupingInfo(PropertyDescriptor p)
        {
            return new PropertyGrouper(p);
        }

        public virtual void SetDisplayValues(GroupDisplayEventArgs e)
        {
            object o = e.Value;
            e.DisplayValue = o == null ? "<Null>" : o.ToString();
        }
    }

    public class PropertyGrouper : GroupingInfo
    {
        public readonly PropertyDescriptor Property;

        public PropertyGrouper(PropertyDescriptor Property)
        {
            if (Property == null) throw new ArgumentNullException();
            this.Property = Property;
        }

        public override object GetGroupValue(object Row)
        {
            return Property.GetValue(Row);
        }

        public override string ToString()
        {
            return Property.Name;
        }
    }

    public delegate object GroupingDelegate(object Row);

    public class DelegateGrouper : GroupingInfo
    {
        public readonly GroupingDelegate GroupingDelegate;
        public readonly string Name;

        public DelegateGrouper(GroupingDelegate Delegate, string Name)
        {
            if (Delegate == null) throw new ArgumentNullException();
            this.Name = Name;
            if (Name == null) this.Name = Delegate.ToString();
            GroupingDelegate = Delegate;
        }

        public override string ToString()
        {
            return Name;
        }

        public override object GetGroupValue(object Row)
        {
            return GroupingDelegate(Row);
        }
    }


    public class StartLetterGrouper : GroupingInfo
    {
        public readonly GroupingInfo Grouper;
        public readonly int Letters;

        public StartLetterGrouper(GroupingInfo Grouper)
            : this(Grouper, 1)
        {
        }

        public StartLetterGrouper(GroupingInfo Grouper, int Letters)
        {
            if (Grouper == null) throw new ArgumentNullException();
            this.Grouper = Grouper;
            this.Letters = Letters;
        }

        public override string ToString()
        {
            return Grouper.ToString();
        }

        public override bool IsProperty(PropertyDescriptor p)
        {
            return Grouper.IsProperty(p);
        }

        public override object GetGroupValue(object Row)
        {
            object val = Grouper.GetGroupValue(Row);
            if (val == null) return null;
            string s = val.ToString();
            if (s.Length < Letters) return s;
            return s.Substring(0, Letters);
        }
    }

    #endregion

    #region Interfaces

    public interface IDataGridViewGrouperOwner
    {
        DataGridViewGrouper Grouper { get; }
    }

    public interface IGrouper
    {
        GroupingInfo GroupOn { get; set; }
        void SetGroupOn(string name);
        void SetGroupOn(PropertyDescriptor property);
        void RemoveGrouping();
        event EventHandler PropertiesChanged;
        event EventHandler GroupingChanged;
        IEnumerable<PropertyDescriptor> GetProperties();
    }

    #endregion

    /*
* Added the Generic comparer here, for ease of use on blog posting ;)
*/

    /// <summary>
    /// Comparer that tries to find the 'strongest' comparer for a type. 
    /// if the type implements a generic IComparable, that is used.
    /// otherwise if it implements a normal IComparable, that is used.
    /// If neither are implemented, the ToString versions are compared. 
    /// INullable structures are also supported.
    /// This way, the DefaultComparer can compare any object types and can be used for sorting any source.
    /// </summary>
    /// <example>Array.Sort(YourArray,new GenericComparer());</example>
    public class GenericComparer : IComparer
    {
        private IComparer comp;
        private int factor = 1;
        private Type targettype;
        private Type type;

        public GenericComparer()
        {
        }

        public GenericComparer(Type Type)
        {
            this.Type = Type;
        }

        public Type Type
        {
            get { return type; }
            set
            {
                if (value == null) throw new ArgumentNullException();
                type = value;
                comp = null;
            }
        }

        /// <summary>
        /// normally the same as the type, but can be set to a different type
        /// </summary>
        public Type TargetType
        {
            get
            {
                if (targettype == null) return type;
                return targettype;
            }
            set
            {
                if (TargetType == value) return;
                targettype = value;
                comp = null;
            }
        }

        public bool Descending
        {
            get { return factor < 0; }
            set { factor = value ? -1 : 1; }
        }

        #region IComparer Members

        public int Compare(object x, object y)
        {
            return factor * compare(x, y);
        }

        #endregion

        private IComparer GetGenericComparer(Type From, Type To)
        {
            while (To != typeof(object))
            {
                if (typeof(IComparable<>).MakeGenericType(To).IsAssignableFrom(From))
                    return (IComparer)Activator.CreateInstance(typeof(StrongCompare<,>).MakeGenericType(From, To));
                To = To.BaseType;
            }
            return null;
        }

        public IComparer GetComparer(Type From, Type To)
        {
            IComparer gen = GetGenericComparer(From, To);
            if (gen != null)
                return gen;
            else if (typeof(IComparable).IsAssignableFrom(type))
            {
                return (IComparer)Activator.CreateInstance(typeof(NonGenericCompare<>).MakeGenericType(type));
            }
            else if (type.IsGenericType && typeof(Nullable<>) == type.GetGenericTypeDefinition())
            {
                Type basetype = type.GetGenericArguments()[0];
                return (IComparer)Activator.CreateInstance(typeof(NullableComparer<>).MakeGenericType(basetype),
                                                            GetComparer(basetype, To == From ? basetype : To));
            }
            return new StringComparer();
        }

        private int compare(object x, object y)
        {
            if (x == y) return 0;
            if (x == null) return -1;
            if (y == null) return 1;
            if (type == null)
                Type = x.GetType();
            if (comp == null)
                comp = GetComparer(type, TargetType);
            return comp.Compare(x, y);
        }

        #region Nested type: NonGenericCompare

        private class NonGenericCompare<T> : IComparer
            where T : IComparable
        {
            #region IComparer Members

            public int Compare(object x, object y)
            {
                return ((T)x).CompareTo(y);
            }

            #endregion
        }

        #endregion

        #region Nested type: NullableComparer

        private class NullableComparer<T> : IComparer
            where T : struct
        {
            public readonly IComparer BaseComparer;

            public NullableComparer(IComparer BaseComparer)
            {
                this.BaseComparer = BaseComparer;
            }

            #region IComparer Members

            public int Compare(object x, object y)
            {
                return BaseComparer.Compare(getval(x), getval(y));
            }

            #endregion

            private object getval(object o)
            {
                return ((T?)o).Value;
            }
        }

        #endregion

        #region Nested type: StringComparer

        private class StringComparer : IComparer
        {
            #region IComparer Members

            public int Compare(object x, object y)
            {
                return string.Compare(x.ToString(), y.ToString());
            }

            #endregion
        }

        #endregion

        #region Nested type: StrongCompare

        private class StrongCompare<F, T> : IComparer
            where F : IComparable<T>
        {
            #region IComparer Members

            public int Compare(object x, object y)
            {
                return ((F)x).CompareTo((T)y);
            }

            #endregion
        }

        #endregion
    }

    public class GenericComparer<T> : GenericComparer, IComparer<T>
    {
        public GenericComparer()
            : base(typeof(T))
        {
        }

        #region IComparer<T> Members

        public int Compare(T a, T b)
        {
            return base.Compare(a, b);
        }

        #endregion
    }


    public class PropertyDescriptorComparer : GenericComparer
    {
        public readonly PropertyDescriptor Prop;

        public PropertyDescriptorComparer(PropertyDescriptor Prop)
            : this(Prop, true)
        {
        }

        public PropertyDescriptorComparer(PropertyDescriptor Prop, bool Descending)
            : base(Prop.PropertyType)
        {
            this.Prop = Prop;
            this.Descending = Descending;
        }
    }
}
