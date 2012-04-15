// 
//    ODBX.UI
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    ObjectListView.cs
//   
//  

using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ODBX.Driver;

namespace ODBX.Controls
{

    public partial class ObjectListView : UserControl
    {

        public event ModelEventHandler SelectionChanged;

        public void OnSelectionChanged(ModelEventArgs e)
        {
            var handler = SelectionChanged;
            if (handler != null) handler(this, e);
        }

        private IList<ModelObject> Objects { get; set; }

        public ObjectListView()
        {
            InitializeComponent();
        }

        public void Bind(IList<ModelObject> objects)
        {
            Objects = objects;
            ListView.SetObjects(Objects);

            Height = ExpandedHeight;
        }

        public int CollapsedHeight
        {
            get { return 0; }
        }

        public int ExpandedHeight
        {
            get { return  40 + (ListView.RowHeight * Objects.Count ); }
        }


        private void ListViewSelectionChanged(object sender, System.EventArgs e)
        {
            OnSelectionChanged(new ModelEventArgs() { SelectedObject = (ModelObject) this.ListView.SelectedObject} );           
        }

    }
}