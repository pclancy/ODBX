// 
//    ODBX.UI
//  
//    FormSynchronise.cs
//   
//  

using System;
using System.Collections.Generic;
using ODBX.Common;
using ODBX.Driver;

namespace ODBX.Forms
{
    public partial class FormSynchronise : BaseForm
    {
        public FormSynchronise()
        {
            InitializeComponent();
            textScript.ApplySettings();

        }

        public void Bind(Project project, IList<ModelObject> objects)
        {

            textScript.IsReadOnly = false;
            textScript.Text = project.Driver.GenerateScript(objects);
            textScript.ConfigurationManager.Language = project.Driver.Syntax;
            textScript.ApplySettings();
            textScript.IsReadOnly = true;

            labelHeaderAction.Text = string.Format("Use this script to modify database {0} on server {1} to make it compatible with database {2} on server {3}",
                                                   project.Target.Catalog, project.Target.Host, project.Source.Catalog, project.Source.Host);
        }

        private void ButtonCancelClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}