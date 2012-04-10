// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    Project.cs
//   
//  

using System.Collections.Generic;
using System.Data;
using ODBX.Driver;

namespace ODBX.Config
{
    public class Project
    {
        public IDriver Driver { get; set; }
        public IConnection Target { get; set; }
        public IConnection Source { get; set; }
        public IList<DriverOption> Options { get; set; }

        public Model Model { get; set; }

        public void Refresh()
        {
            Model = Driver.BuildComparisonObjects(Source, Target);
        }

    }
}