// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    ProjectConfiguration.cs
//   
//  

namespace ODBX.Config
{
    public class ProjectConfiguration
    {
        public ConnectionConfiguration Destination { get; set; }
        public ConnectionConfiguration Source { get; set; }

        public string Type { get; set; }
        public string Name { get; set; }
    }
}