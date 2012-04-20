using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ODBX.Driver;
using ODBX.Forms;
using ODBX.Properties;

namespace ODBX.Controls
{
    public class ResultGrid : DataGridView
    {
        private List<GridObject> _gridBinding;
        private Model _model;
        private bool _isBinding;

        public ResultGrid()
        {
            CellClick += OnCellClick;
        }

        protected override void OnCellMouseMove(DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Cursor = IsGroupRow(e.RowIndex) ? Cursors.Hand : Cursors.Default;
            }
            else
            {
                Cursor = Cursors.Default;
            }

            base.OnCellMouseMove(e);
        }

        protected override void OnCellMouseLeave(DataGridViewCellEventArgs e)
        {
            Cursor = Cursors.Default;
            base.OnCellMouseLeave(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
           Cursor = Cursors.Default;

            base.OnMouseLeave(e);
        }



        public ModelObject SelectedObject
        {
            get
            {
                if (SelectedRows.Count > 0)
                {
                    var dataBoundItem = SelectedRows[0].DataBoundItem as GridDifference;
                    if (dataBoundItem != null)
                        return dataBoundItem.Object;
                }
                return null;
            }
        }

        private void OnCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (IsGroupRow(e.RowIndex))
            {
                SuspendLayout();
                ToggleGroup(e.RowIndex);
                ResumeLayout();
            }
        }

        protected override void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e)
        {
            if (IsGroupRow(e.RowIndex) && !_isBinding)
            {
                var gridGroup = Rows[e.RowIndex].DataBoundItem as GridGroup;

                if (Rows[e.RowIndex].Height != 32)
                    Rows[e.RowIndex].Height = 32;

                PaintGroupRow(gridGroup, e);
                e.Handled = true;
            }
            base.OnRowPrePaint(e);
        }

        private void PaintGroupRow(GridGroup gridGroup, DataGridViewRowPrePaintEventArgs e)
        {
            Rectangle rect = e.RowBounds;
            var gradBrush = new LinearGradientBrush(rect, SystemColors.ControlLight, SystemColors.ControlLightLight,
                                                    LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(gradBrush, rect);

            e.Graphics.DrawLine(SystemPens.ButtonShadow, rect.Left, rect.Top, rect.Width, rect.Top);
            e.Graphics.DrawLine(SystemPens.ButtonHighlight, rect.Left, rect.Top + 1, rect.Width, rect.Top + 1);
            e.Graphics.DrawLine(SystemPens.Control, rect.Left, rect.Bottom - 1, rect.Width, rect.Bottom - 1);


            var layoutRectangle = new Rectangle(rect.Left + 25, rect.Top + 9, rect.Width - 35, rect.Height - 10);
            e.Graphics.DrawString(gridGroup.HeaderText, RowsDefaultCellStyle.Font, Brushes.Black, layoutRectangle);

            e.Graphics.DrawImage(gridGroup.Collapsed ? Resources.expand : Resources.collapse, rect.Left + 5,
                                 rect.Top + 7, 16, 16);



        }

        protected override void SetSelectedRowCore(int rowIndex, bool selected)
        {
            if (!IsGroupRow(rowIndex))
                base.SetSelectedRowCore(rowIndex, selected);
        }

        public void Bind(Model model, GroupByView groupBy)
        {
            SuspendLayout();
            _isBinding = true;

            DataSource = null;
            Rows.Clear();

            _model = model;
            _gridBinding = new List<GridObject>();

            List<IGrouping<string, ModelObject>> groupings;

            switch (groupBy)
            {
                case GroupByView.ObjectType:
                    groupings =
                        _model.Objects.OrderBy(x => x.Type).ThenBy(x => x.Name).GroupBy(modelObject => modelObject.Type)
                            .ToList();
                    break;
                case GroupByView.Difference:
                    groupings =
                        _model.Objects.OrderBy(x => x.Type).ThenBy(x => x.Name).GroupBy(
                            modelObject => modelObject.Difference.DisplayValue).ToList();
                    break;
                default:
                    groupings =
                        _model.Objects.OrderBy(x => x.Type).ThenBy(x => x.Name).GroupBy(x => "All").ToList();
                    break;
            }

            foreach (var grouping in groupings)
            {
                var group = new GridGroup();
                group.HeaderText = string.Format("{0} : {1} objects", grouping.Key, grouping.Count());
                group.Collapsed = true;
                _gridBinding.Add(group);

                foreach (ModelObject modelObject in grouping)
                {
                    var difference = new GridDifference
                                         {
                                             Include = true,
                                             Object = modelObject,
                                             SourceName = modelObject.Name,
                                             TargetName = modelObject.Name,
                                             Type = modelObject.Type,
                                             Action = modelObject.Difference.Action.ToString()
                                         };

                    _gridBinding.Add(difference);
                }
            }

            AutoGenerateColumns = false;
            DataSource = _gridBinding;

            CollapseExpandAll(true);
            _isBinding = false;

            ResumeLayout();
        }

        public void CollapseAll()
        {
            CollapseExpandAll(true);
        }

        public void ExpandAll()
        {
            CollapseExpandAll(false);
        }

        private void CollapseExpandAll(bool collapsed)
        {
            SuspendLayout();

            int count = Rows.Count;
            for (int i = 0; i < count; i++)
            {
                if (IsGroupRow(i))
                    ((GridGroup)Rows[i].DataBoundItem).Collapsed = collapsed;
                else
                    Rows[i].Visible = !collapsed;
            }
            ResumeLayout();
        }

        private void ToggleGroup(int index)
        {
            SuspendLayout();

            var gridGroup = (GridGroup)Rows[index].DataBoundItem;
            gridGroup.Collapsed = !gridGroup.Collapsed;

            foreach (DataGridViewRow row in GetRows(index))
                row.Visible = !gridGroup.Collapsed;

            ResumeLayout();
        }

        private IEnumerable<DataGridViewRow> GetRows(int index)
        {
            while (!IsGroupRow(++index) && index < _model.Objects.Count)
                yield return Rows[index];
        }

        private bool IsGroupRow(int rowIndex)
        {
            if (rowIndex < 0 || rowIndex > _model.Objects.Count - 1)
                return false;

            return Rows[rowIndex].DataBoundItem is GridGroup;
        }
    }

    public class GridGroup : GridObject
    {
        public bool Collapsed { get; set; }

        public string HeaderText { get; set; }
    }

    public class GridDifference : GridObject
    {
        public ModelObject Object { get; set; }
    }

    public class GridObject
    {
        public string TargetName { get; set; }
        public string SourceName { get; set; }
        public bool Include { get; set; }

        public string Type { get; set; }
        public string Action { get; set; }

    }

    public class SelectionChangedEventArgs : EventArgs
    {
        public ModelObject SelectedObject { get; set; }
    }

    public delegate void ModelEventHandler(object sender, SelectionChangedEventArgs args);
}