// 
//    ODBX.UI
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    ObjectListGrid.cs
//   
//  

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using ODBX.Driver;
using ODBX.Forms;

namespace ODBX.Controls
{
    public partial class ObjectListGrid : UserControl
    {
        public event ModelEventHandler SelectionChanged;

        public class GridGroup
        {
            public string Name { get; set; }
            public string FormatString { get; set; }
            public int[] ObjectRows { get; set; }
        }

        public void OnSelectionChanged(ModelEventArgs e)
        {
            var handler = SelectionChanged;
            if (handler != null) handler(this, e);
        }

        public ObjectListGrid()
        {
            InitializeComponent();
        }

        public void Bind(Model model, GroupByView groupBy)
        {
            var modelProjection = new DataTable();
            modelProjection.Columns.Add("Id", typeof(int));
            modelProjection.Columns.Add("RowType", typeof(string));
            modelProjection.Columns.Add("NameLeft", typeof(string));
            modelProjection.Columns.Add("NameRight", typeof(string));
            modelProjection.Columns.Add("Include", typeof(bool));
            modelProjection.Columns.Add("Type", typeof(string));
            modelProjection.Columns.Add("Object", typeof(object));


            //var gridModel = (from x in model.Objects select x).OrderBy(x=>x.Type).ToList();


            var gridModel = new List<IGrouping<string, ModelObject>>();
            groupBy = GroupByView.Difference;
            

            switch (groupBy)
            {
                case GroupByView.ObjectType:
                    gridModel = model.Objects.GroupBy(modelObject => modelObject.Type).ToList();
                    break;
                case GroupByView.Difference:
                    gridModel = model.Objects.GroupBy(modelObject => modelObject.Difference.DisplayValue).ToList();
                    break;
            }

            foreach (var grouping in gridModel)
            {
                var group = new GridGroup();
                group.Name = string.Format("{0} : {1} objects", grouping.Key, grouping.Count());

                var groupRow = modelProjection.NewRow();
                groupRow["RowType"] = "Group";
                groupRow["Object"] = group;

                modelProjection.Rows.Add(groupRow);

                foreach (var modelObject in grouping)
                {
                    var row = modelProjection.NewRow();
                    row["RowType"] = "Object";
                    row["Id"] = modelObject.Id;
                    row["NameLeft"] = modelObject.Name;
                    row["NameRight"] = modelObject.Name;
                    row["Include"] = modelObject.Include;
                    row["Type"] = modelObject.Type;
                    row["Object"] = modelObject;

                    modelProjection.Rows.Add(row);
                }
            }


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = modelProjection;
        }

        private void DataGridView1SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var row = (DataRowView)dataGridView1.SelectedRows[0].DataBoundItem;
                if (row["RowType"].Equals("Object"))
                {



                    OnSelectionChanged(new ModelEventArgs
                                           {
                                               SelectedObject = (ModelObject)
                                                  ((DataRowView)dataGridView1.SelectedRows[0].DataBoundItem)["Object"]
                                           });
                }
            }
        }

        private void DataGridView1RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var row = (DataRowView)dataGridView1.Rows[e.RowIndex].DataBoundItem;
            if (row["RowType"].Equals("Group"))
            {
                dataGridView1.Rows[e.RowIndex].Height = 32;
                var gridGroup = (GridGroup)row["object"];
                e.Handled = true;
                PaintGroupRow(gridGroup, e);
            }
        }

        private void PaintGroupRow(GridGroup gridGroup, DataGridViewRowPrePaintEventArgs e)
        {
            var rect = e.RowBounds;
            var gradBrush = new LinearGradientBrush(rect, SystemColors.ControlLight, SystemColors.ControlLightLight, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(gradBrush, rect);
            e.Graphics.DrawLine(SystemPens.ButtonShadow, rect.Left, rect.Top, rect.Width, rect.Top);
            e.Graphics.DrawLine(SystemPens.ButtonHighlight, rect.Left, rect.Top+1, rect.Width, rect.Top+1);
            e.Graphics.DrawLine(SystemPens.ButtonShadow, rect.Left, rect.Bottom - 1, rect.Width, rect.Bottom - 1);


            var layoutRectangle = new Rectangle(rect.Left + 5, rect.Top + 8, rect.Width - 10, rect.Height - 10);
            e.Graphics.DrawString(gridGroup.Name, dataGridView1.Font, Brushes.Black, layoutRectangle);


        }

        private void DataGridView1RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //if (!DrawExpandCollapseLines || e.RowIndex >= _source.Count) return;
            //int next = e.RowIndex + 1;
            //int r = _grid.RowHeadersWidth;
            //int x = HeaderOffset - Lineoffset;
            //int y = e.RowBounds.Top + e.RowBounds.Height / 2;
            //e.Graphics.DrawLine(_linepen, x, y, r, y);
            //if (next < _source.Count && !IsGroupRow(next))
            //    y = e.RowBounds.Bottom;
            //e.Graphics.DrawLine(_linepen, x, e.RowBounds.Top, x, y);

        }

    }
}