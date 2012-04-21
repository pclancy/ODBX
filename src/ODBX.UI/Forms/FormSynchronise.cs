// 
//    ODBX.UI
//  
//    FormSynchronise.cs
//   
//  

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ODBX.Common;
using ODBX.Driver;
using ScintillaNET;

namespace ODBX.Forms
{
    public partial class FormSynchronise : BaseForm
    {
        public FormSynchronise()
        {
            InitializeComponent();
        }

        public void Bind(Project project, IList<ModelObject> objects)
        {

            Font font = new Font("Lucida Console", 10);

            textScript.IsReadOnly = false;
            textScript.ConfigurationManager.Language = project.Driver.Syntax;

            textScript.Styles.Default.Font = font;

            for (var i = 0; i < 32; i++)
                textScript.Styles[i].Font = font;

                textScript.Styles[StylesCommon.LineNumber].Font = font;
            textScript.Styles[StylesCommon.BraceBad].Font = font;
            textScript.Styles[StylesCommon.BraceLight].Font = font;
            textScript.Styles[StylesCommon.CallTip].Font = font;
            textScript.Styles[StylesCommon.ControlChar].Font = font;
            textScript.Styles[StylesCommon.Default].Font = font;
            textScript.Styles[StylesCommon.IndentGuide].Font = font;
            textScript.Styles[StylesCommon.LastPredefined].Font = font;
            textScript.Styles[StylesCommon.Max].Font = font;
            textScript.Text = project.Driver.GenerateScript(objects);
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