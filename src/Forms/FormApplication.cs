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
            var formProject = new FormProject {MdiParent = this, WindowState = FormWindowState.Maximized};

            formProject.Show();
        }

        private void ButtonOptionsClick(object sender, System.EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                var formProjectConfiguration = new FormProjectConfiguration();

                if (formProjectConfiguration.ShowDialog(this) == DialogResult.OK)
                {
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
    }
}