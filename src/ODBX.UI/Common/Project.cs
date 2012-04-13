// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    Project.cs
//   
//  

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using ODBX.Driver;

namespace ODBX.Common
{
    public enum Direction
    {
        LeftToRight,
        RightToLeft
    }

    [Serializable]
    public class ProjectDTO
    {
        public ProjectDTO()
        {}

        public ProjectDTO(Project project)
        {
            Direction = project.Direction;
            DriverId = project.Driver.Id;
            DriverName = project.Driver.Name;
            Source = project.Source.ConnectionString;
            Target = project.Target.ConnectionString;
            Version = "1.0";
        }


        public Direction Direction { get; set; }
        public Guid DriverId { get; set; }
        public string DriverName { get; set; }

        public string Version { get; set; }

        public string Source { get; set; }
        public string Target { get; set; }
    }

    public class Project
    {
        public Project()
        {
            Direction = Direction.LeftToRight;
        }

        public Direction Direction { get; set; }
        public IDriver Driver { get; set; }

        public IConnection Target { get; set; }
        public IConnection Source { get; set; }
        public IList<DriverOption> Options { get; set; }
        public Model Model { get; set; }
        public string FilePath { get; set; }


        public void Refresh()
        {
            // set options
            Model = Driver.BuildComparisonObjects(Source, Target);
        }


    }
}