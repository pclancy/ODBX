// 
//    ODBX.UI
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    GroupList.cs
//   
//  

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using ODBX.Driver;

namespace ODBX.Controls
{
    public partial class GroupList : UserControl
    {
        public event ModelEventHandler SelectionChanged;

        public void OnSelectionChanged(ModelEventArgs e)
        {
            var handler = SelectionChanged;
            if (handler != null) handler(this, e);
        }

        public bool IsCollapsed { get; set; }
        public GroupList()
        {
            InitializeComponent();
            IsCollapsed = true;
            Height = CollapsedHeight;
        }


        public Image HeaderImage
        {
            get { return pictureBoxGroupIcon.Image; }
            set { pictureBoxGroupIcon.Image = value; }
        }

        public string HeaderFormat { get; set; }

        public void Bind(IList<ModelObject> objects)
        {
            labelHeader.Text = string.Format(HeaderFormat, objects.Count);
            objectListView.Bind(objects);
        }

        private void GradientPanelGroupHeaderClick(object sender, EventArgs e)
        {
            Toggle();
        }

        private void Toggle()
        {
            IsCollapsed = !IsCollapsed;
            Height = IsCollapsed ? CollapsedHeight : ExpandedHeight;
        }

        public int CollapsedHeight
        {
            get { return gradientPanelGroupHeader.Height + objectListView.CollapsedHeight; }
        }

        public int ExpandedHeight
        {
            get { return gradientPanelGroupHeader.Height + objectListView.ExpandedHeight; }
        }

        private void PictureBox1Click(object sender, EventArgs e)
        {
            Toggle();
        }

        private void ObjectListViewSelectionChanged(object sender, ModelEventArgs e)
        {
            OnSelectionChanged(e);
        }
    }
}