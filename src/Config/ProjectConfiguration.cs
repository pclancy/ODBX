// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    ProjectConfiguration.cs
//   
//  

using ODBX.Driver;

namespace ODBX.Config
{
    public class ProjectConfiguration
    {
        public Connection Destination { get; set; }
        public Connection Source { get; set; }

        public string Type { get; set; }
        public string Name { get; set; }
    }
}