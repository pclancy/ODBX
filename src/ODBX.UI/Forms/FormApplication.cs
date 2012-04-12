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
        private FormProjectBrowser _formProjectBrowser;

        public FormApplication()
        {
            InitializeComponent();
        }


        private void OpenProjectBrowser()
        {
            if (_formProjectBrowser.ShowDialog() == DialogResult.OK)
            { }

        }

        //private void OpenProject()
        //{
        //    _formProject = new FormProject {MdiParent = this, WindowState = FormWindowState.Maximized};
        //    _formProject.Show();
        //}

        private void ButtonOptionsClick(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                Program.HandleException(this, ex, Strings.Error);
            }
            finally
            {

                ButtonRefresh.Enabled = _formProject.Project != null;
                _formProject.Bind();
                _formProject.Show();

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

        private void FormApplicationLoad(object sender, EventArgs e)
        {
            _formProject = new FormProject { MdiParent = this, WindowState = FormWindowState.Maximized };
            _formProjectBrowser = new FormProjectBrowser();

            
        }

        private void FormApplicationShown(object sender, EventArgs e)
        {
            OpenProjectBrowser();

        }

        private void ButtonProjectsClick(object sender, EventArgs e)
        {
            OpenProjectBrowser();
        }
    }
}