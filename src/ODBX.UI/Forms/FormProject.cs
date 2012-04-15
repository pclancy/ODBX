// 
//    ODBX.UI
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormProject.cs
//   
//  

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ODBX.Common;
using ODBX.Controls;
using ODBX.Driver;
using ODBX.Properties;

namespace ODBX.Forms
{
    public partial class FormProject : BaseForm
    {

        public enum GroupByView
        {
            None = 0,
            ObjectType = 1,
            Difference = 2
        }

        private Project _project;
        public GroupByView GroupBy { get; set; }

        public FormProject()
        {
            InitializeComponent();
        }

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

            Cursor.Current = Cursors.Default;
        }


        private void BuildView()
        {
            SuspendLayout();


            this.objectListGrid1.Bind(Project.Model);

            switch (GroupBy)
            {
                case GroupByView.None:
                    break;
                case GroupByView.ObjectType:
                    break;
                case GroupByView.Difference:
                    break;

            }
            ResumeLayout();
            Refresh();
        }

        //private GroupList AddRow(string headerFormat, IList<ModelObject> objects)
        //{
        //    var control = new GroupList { Dock = DockStyle.Top, HeaderFormat =  headerFormat};
        //    control.SelectionChanged += ControlOnSelectionChanged;
        //    control.Bind(objects);
        //    splitContainerMain.Panel1.Controls.Add(control);
        //    return control;
        //}

        private void ObjectListGrid1SelectionChanged(object sender, ModelEventArgs args)
        {
            SelectedObject = args.SelectedObject;

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

    }
}