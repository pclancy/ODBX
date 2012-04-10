// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormApplication.cs
//   
//  

using System;
using System.Windows.Forms;
using ODBX.Properties;

namespace ODBX.Forms
{
    public partial class FormApplication : BaseForm
    {
        private FormProject _formProject;

        public FormApplication()
        {
            InitializeComponent();
            
        }

        protected override void OnLoad(EventArgs e)
        {

            base.OnLoad(e);
            OpenProject();
        }

        private void OpenProject()
        {
            _formProject = new FormProject {MdiParent = this, WindowState = FormWindowState.Maximized};
            _formProject.Show();
        }

        private void ButtonOptionsClick(object sender, System.EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var formProjectConfiguration = new FormProjectConfiguration();

                if (formProjectConfiguration.ShowDialog(this) == DialogResult.OK)
                {
                    _formProject.Project = formProjectConfiguration.Project;
                }
            }
            catch(Exception ex)
            {
                Program.HandleException(this, ex, Strings.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void ButtonRefreshClick(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                _formProject.Bind();
            }
            catch (Exception ex)
            {
                Program.HandleException(this, ex, Strings.Error);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}