// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormProject.cs
//   
//  

using System.Windows.Forms;
using BrightIdeasSoftware;
using ODBX.Config;
using ODBX.Driver;

namespace ODBX.Forms
{
    public partial class FormProject : Form
    {
        private Project _project;

        public FormProject()
        {
            InitializeComponent();
        }

        public Project Project
        {
            get { return _project; }
            set
            {
                _project = value;
                Bind();
            }
        }

        public void Bind()
        {
            _project.Refresh();
            MessageBox.Show("Done");

            objectListView.SetObjects(_project.Model.Objects);
        }

        private void ObjectListViewSelectedIndexChanged(object sender, System.EventArgs e)
        {
            if (this.objectListView.SelectedItem != null)
            {
                var modelObject = (ModelObject) objectListView.SelectedItem.RowObject;
                var script = _project.Driver.GenerateScript(modelObject);
                this.textScript.Text = script;
            }
        }

        private void ObjectListViewSelectionChanged(object sender, System.EventArgs e)
        {

        }
    }
}