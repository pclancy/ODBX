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
using ODBX.Properties;

namespace ODBX.Forms
{
    public partial class FormProject : Form
    {
        private Project _project;

        public FormProject()
        {
            InitializeComponent();
            textScript.ConfigurationManager.Language = "mssql";
        }

        public Project Project
        {
            get { return _project; }
            set
            {
                _project = value;
                textScript.ConfigurationManager.Language = _project.Driver.Syntax;
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
                textScript.Text = script;
            }
        }

        private void ObjectListViewSelectionChanged(object sender, System.EventArgs e)
        {

        }

        private void PanelDirectionMouseDoubleClick(object sender, MouseEventArgs e)
        {
            var source = _project.Source;
            var target = _project.Target;

            if (_project.Direction == Direction.LeftToRight)
            {
                _project.Direction = Direction.RightToLeft;
                panelDirection.BackgroundImage = Resources.big_arrow_left;
            }
            else
            {
                _project.Direction = Direction.LeftToRight;
                panelDirection.BackgroundImage = Resources.big_arrow_right;
            }

            panelDirection.Update();

            _project.Source = target;
            _project.Target = source;

            Bind();
        }
    }
}