// 
//    ODBX.UI
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    ControlScriptDiff.cs
//   
//  

using System;
using System.ComponentModel;
using System.Windows.Forms;
using ODBX.Driver;
using ODBX.Forms;

namespace ODBX.Controls
{
    public partial class ControlScriptDiff : UserControl
    {
        private ModelObject _modelObject;

        public ControlScriptDiff()
        {
            InitializeComponent();
        }

        public ModelObject ModelObject
        {
            get { return _modelObject; }
            set
            {
                _modelObject = value;

                if (value == null)
                {
                    labelDifference.Text = labelObjectLeft.Text = labelObjectRight.Text = string.Empty;
                }
                else
                {
                    labelDifference.Text = string.Format("{0} - {1}", value.Difference.DisplayValue,
                                                         value.Difference.InternalState);
                }
            }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Syntax
        {
            get { return textScriptRight.ConfigurationManager.Language; }

            set
            {
                if (value != null)
                {
                    textScriptRight.ConfigurationManager.Language = value;
                    textScriptLeft.ConfigurationManager.Language = value;
                    textScriptMerged.ConfigurationManager.Language = value;
                }
            }
        }

        public string LeftContent
        {
            get { return textScriptLeft.Text; }
            set
            {
                textScriptLeft.IsReadOnly = false;
                textScriptLeft.Text = value;
                textScriptLeft.IsReadOnly = true;
            }
        }

        public string RightContent
        {
            get { return textScriptRight.Text; }
            set
            {
                textScriptRight.IsReadOnly = false;
                textScriptRight.Text = value;
                textScriptRight.IsReadOnly = true;
            }
        }

        public string BottomContent
        {
            get { return textScriptMerged.Text; }
            set
            {
                textScriptMerged.IsReadOnly = false;
                textScriptMerged.Text = value;
                textScriptMerged.IsReadOnly = true;
            }
        }

        private void ButtonTearWindowClick(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            var formObjectDiff = new FormObjectDiff {ModelObject = ModelObject};
            formObjectDiff.SetContent(LeftContent, RightContent, BottomContent, Syntax);
            formObjectDiff.Show();
            Cursor.Current = Cursors.Default;
        }

        private void CheckBoxShowMergedCheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxShowMerged.Checked && !checkBoxShowDiff.Checked)
                checkBoxShowDiff.Checked = true;

            splitContainerMain.Panel2Collapsed = !checkBoxShowMerged.Checked;
        }

        private void CheckBoxShowDiffCheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxShowMerged.Checked && !checkBoxShowDiff.Checked)
                checkBoxShowMerged.Checked = true;

            splitContainerMain.Panel1Collapsed = !checkBoxShowDiff.Checked;
        }
    }
}