// 
//    ODBX.UI
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    ObjectListGrid.cs
//   
//  

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using ODBX.Driver;
using ODBX.Forms;

namespace ODBX.Controls
{

    public partial class ObjectListGrid : UserControl
    {
        public event ModelEventHandler SelectionChanged;
        DataTable _modelProjection;

        public void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            var handler = SelectionChanged;
            if (handler != null) handler(this, e);
        }

        public ObjectListGrid()
        {
            InitializeComponent();
        }

        public void Bind(Model model, GroupByView groupBy)
        {
            GridResults.Bind(model, groupBy);
        }

    }
}