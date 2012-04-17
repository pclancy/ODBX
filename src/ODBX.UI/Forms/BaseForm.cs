// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    BaseForm.cs
//   
//  

using System.Drawing;
using System.Windows.Forms;
using ODBX.Controls;

namespace ODBX.Forms
{
    public class BaseForm : Form
    {

        protected override void OnLoad(System.EventArgs e)
        {
            base.OnLoad(e);
            AutoScaleMode = AutoScaleMode.Dpi;
            ChangeFont(this);
        }

        private void ChangeFont(Control control)
        {
            control.Font = new Font(SystemFonts.DialogFont.FontFamily, control.Font.Size, control.Font.Style);

            if (control.HasChildren)
            {
                foreach (Control childControl in control.Controls)
                {
                    ChangeFont(childControl);
                }
            }
        }
    }
}