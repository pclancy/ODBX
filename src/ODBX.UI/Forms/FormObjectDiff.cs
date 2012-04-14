// 
//    ODBX.UI
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FormObjectDiff.cs
//   
//  

using System;
using ODBX.Driver;

namespace ODBX.Forms
{
    public partial class FormObjectDiff : BaseForm
    {
        private ModelObject _modelObject;

        public ModelObject ModelObject
        {
            get { return _modelObject; }
            set
            {
                if (value != null)
                {
                    _modelObject = value;
                    controlScriptDiff1.ModelObject = value;
                    Text = string.Format("Object Diff: {0}", value.Fullname);
                }
            }
        }

        public FormObjectDiff()
        {
            InitializeComponent();
        }

        private void ButtonCloseClick(object sender, EventArgs e)
        {
            Close();
        }

        public void SetContent(string leftContent, string rightContent, string bottomContent, string syntax)
        {
            controlScriptDiff1.LeftContent = leftContent;
            controlScriptDiff1.RightContent = rightContent;
            controlScriptDiff1.BottomContent = bottomContent;
            controlScriptDiff1.Syntax = syntax;
        }

    }
}