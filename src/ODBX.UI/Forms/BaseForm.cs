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

namespace ODBX.Forms
{
    public class BaseForm : Form
    {
        public BaseForm()
        {
            Font = SystemFonts.IconTitleFont;

            foreach (Control control in Controls)
            {
                control.Font = SystemFonts.IconTitleFont;
                if (control.HasChildren)
                {
                    foreach (Control childControl in Controls)
                    {
                        childControl.Font = SystemFonts.IconTitleFont;
                    }
                }
            }
        }
    }
}