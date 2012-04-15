// 
//    ODBX.UI
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    ModelEventArgs.cs
//   
//  

using System;
using ODBX.Driver;

namespace ODBX.Controls
{
    public class ModelEventArgs : EventArgs
    {
        public ModelObject SelectedObject { get; set; }
    }

    public delegate void ModelEventHandler(object sender, ModelEventArgs args);

}