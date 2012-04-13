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
using ODBX.Common;
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
            panelDirection.BackgroundImage = _project.Direction == Direction.LeftToRight
                                                 ? Resources.big_arrow_right
                                                 : Resources.big_arrow_left;

            labelSourceConnection.Text = _project.Source.Host;
            labelTargetConnection.Text = _project.Target.Host;
            labelSourceCatalog.Text = _project.Source.Catalog;
            labelTargetCatalog.Text = _project.Target.Catalog;

            objectListView.SetObjects(_project.Model.Objects);

            Cursor.Current = Cursors.Default;
        }

        private void ObjectListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            if (objectListView.SelectedItem != null)
            {
                var modelObject = (ModelObject)objectListView.SelectedItem.RowObject;


                controlScriptDiff1.ModelObject = modelObject;
                controlScriptDiff1.LeftContent = _project.Driver.GenerateScript(ScriptAction.OriginalFromSource, modelObject);
                controlScriptDiff1.RightContent = _project.Driver.GenerateScript(ScriptAction.OriginalFromTarget, modelObject);
                controlScriptDiff1.BottomContent = _project.Driver.GenerateScript(ScriptAction.Merged, modelObject);
            }
        }

        private void ObjectListViewSelectionChanged(object sender, EventArgs e)
        {
        }

        private void PanelDirectionMouseDoubleClick(object sender, MouseEventArgs e)
        {
            IConnection source = _project.Source;
            IConnection target = _project.Target;

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

            Bind(_project);
        }

    }
}