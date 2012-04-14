// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormProject.cs
//   
//  

using System;
using System.Windows.Forms;
using BrightIdeasSoftware;
using ODBX.Common;
using ODBX.Controls;
using ODBX.Driver;
using ODBX.Properties;

namespace ODBX.Forms
{
    public partial class FormProject : BaseForm
    {
        private Project _project;

        public FormProject()
        {
            InitializeComponent();

        }

        private ModelObject _selectedObject;
        public ModelObject SelectedObject
        {
            get { return _selectedObject; }
            set
            {
                _selectedObject = value;
            }
        }

        public Project Project
        {
            get { return _project; }
            private set
            {
                _project = value;
            }
        }


        public void Bind(Project project)
        {
            Cursor.Current = Cursors.WaitCursor;

            Project = project;

            Text = project.FilePath;
            controlScriptDiff1.Syntax = _project.Driver.Syntax;
            panelDirection.BackgroundImage = Resources.big_arrow_right;

            labelSourceConnection.Text = _project.Source.Host;
            labelTargetConnection.Text = _project.Target.Host;
            labelSourceCatalog.Text = _project.Source.Catalog;
            labelTargetCatalog.Text = _project.Target.Catalog;

            BuildView();

            Cursor.Current = Cursors.Default;
        }

        private void ObjectListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedObject != null)
            {
                controlScriptDiff1.ModelObject = SelectedObject;
                controlScriptDiff1.LeftContent = _project.Driver.GenerateScript(ScriptAction.OriginalFromSource, SelectedObject);
                controlScriptDiff1.RightContent = _project.Driver.GenerateScript(ScriptAction.OriginalFromTarget, SelectedObject);
                controlScriptDiff1.BottomContent = _project.Driver.GenerateScript(ScriptAction.Merged, SelectedObject);
            }
        }

        private void BuildView()
        {
            this.SuspendLayout();
            this.tableLayoutView.Controls.Clear();
            this.tableLayoutView.ColumnCount = 1;

            //foreach (var modelObject in Project.Model.Objects)
            //{


            var gl1 = new GroupList();
            gl1.Height = 30*10;

            this.tableLayoutView.Controls.Add(gl1);
            this.tableLayoutView.Controls[0].Dock = DockStyle.Fill;

            this.tableLayoutView.RowStyles.Add(new RowStyle(SizeType.AutoSize));


            this.tableLayoutView.RowCount++;
            this.tableLayoutView.Controls.Add(new GroupList());
            this.tableLayoutView.Controls[1].Dock = DockStyle.Fill;

            this.tableLayoutView.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            this.tableLayoutView.RowCount++;
            //}

            this.ResumeLayout();
            //objectListView.SetObjects(_project.Model.Objects);
        }


    }
}