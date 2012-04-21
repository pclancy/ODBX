// 
//    ODBX.UI
//  
//    ScriptViewer.cs
//   
//  

using System.Drawing;
using ScintillaNET;

namespace ODBX.Controls
{
    public class ScriptViewer : Scintilla
    {
        public void ApplySettings()
        {
            var font = new Font("Lucida Console", 10);

            Styles.Default.Font = font;

            for (var i = 0; i < 32; i++)
                Styles[i].Font = font;

            Styles[StylesCommon.LineNumber].Font = font;
            Styles[StylesCommon.BraceBad].Font = font;
            Styles[StylesCommon.BraceLight].Font = font;
            Styles[StylesCommon.CallTip].Font = font;
            Styles[StylesCommon.ControlChar].Font = font;
            Styles[StylesCommon.Default].Font = font;
            Styles[StylesCommon.IndentGuide].Font = font;
            Styles[StylesCommon.LastPredefined].Font = font;
            Styles[StylesCommon.Max].Font = font;

            Margins.Margin0.IsClickable = true;
            Margins.Margin0.IsFoldMargin = true;
            Margins.Margin0.IsMarkerMargin = true;
            Margins.Margin0.Width = 50;
        }
    }
}