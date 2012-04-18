// 
//    ODBX.UI
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormProject.cs
//   
//  

using System;
using System.Windows.Forms;
using ODBX.Common;
using ODBX.Driver;
using ODBX.Properties;

namespace ODBX.Forms
{
    public enum GroupByView
    {
        None = 0,
        ObjectType = 1,
        Difference = 2
    }

    public partial class FormProject : BaseForm
    {
        private Project _project;

        public FormProject()
        {
            InitializeComponent();

            resultGrid.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            resultGrid.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            resultGrid.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            resultGrid.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            
        }

        public GroupByView GroupBy { get; set; }

        public ModelObject SelectedObject { get; set; }

        public Project Project
        {
            get { return _project; }
            private set { _project = value; }
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
            resultGrid.CollapseAll();

            Cursor.Current = Cursors.Default;
        }


        public void BuildView()
        {
            if (Project == null)
                return;

            SuspendLayout();

            resultGrid.Bind(Project.Model, GroupBy);

            ResumeLayout();
            Refresh();
        }


        private void ResultGridSelectionChanged(object sender, EventArgs e)
        {
            SelectedObject = resultGrid.SelectedObject;

            if (SelectedObject != null)
            {
                controlScriptDiff1.ModelObject = SelectedObject;
                controlScriptDiff1.LeftContent = _project.Driver.GenerateScript(ScriptAction.OriginalFromSource,
                                                                                SelectedObject);
                controlScriptDiff1.RightContent = _project.Driver.GenerateScript(ScriptAction.OriginalFromTarget,
                                                                                 SelectedObject);
                controlScriptDiff1.BottomContent = _project.Driver.GenerateScript(ScriptAction.Merged, SelectedObject);
            }
        }

        private void FormProjectShown(object sender, EventArgs e)
        {
            resultGrid.CollapseAll();
        }

    }
}