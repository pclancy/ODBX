using System.ComponentModel;
using System.Windows.Forms;

namespace ODBX.Controls
{
    public partial class ControlScriptDiff : UserControl
    {
        public ControlScriptDiff()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string LanguageTemplate
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
            set { textScriptLeft.Text = value; }
        }

        public string RightContent
        {
            get { return textScriptRight.Text; }
            set { textScriptRight.Text = value; }
        }

        public string BottomContent
        {
            get { return textScriptMerged.Text; }
            set { textScriptMerged.Text = value; }
        }
    }
}