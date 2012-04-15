// 
//    ODBX.UI
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    ObjectListGrid.cs
//   
//  

using System;
using System.Windows.Forms;
using ODBX.Driver;

namespace ODBX.Controls
{
    public partial class ObjectListGrid : UserControl
    {
        public event ModelEventHandler SelectionChanged;

        public void OnSelectionChanged(ModelEventArgs e)
        {
            var handler = SelectionChanged;
            if (handler != null) handler(this, e);
        }

        public ObjectListGrid()
        {
            InitializeComponent();
        }

        public void Bind(Model model)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = model.Objects;
        }

        private void DataGridView1SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                OnSelectionChanged(new ModelEventArgs
                                       {SelectedObject = (ModelObject) dataGridView1.SelectedRows[0].DataBoundItem});
            }
        }
    }
}