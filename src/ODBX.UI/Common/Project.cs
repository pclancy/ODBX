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

    [Serializable]
    public class ProjectDTO
    {
        public ProjectDTO()
        {}

        public ProjectDTO(Project project)
        {
            DriverId = project.Driver.Id;
            DriverName = project.Driver.Name;
            Source = project.Source.ConnectionString;
            Target = project.Target.ConnectionString;
            Version = "1.0";
            Author = project.Author;

        }


        public Guid DriverId { get; set; }
        public string DriverName { get; set; }

        public string Version { get; set; }
        public string Author { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
        public DateTime? LastCompared { get; set; }
        public DateTime? LastSync { get; set; }
    }

    public class Project
    {
        public IDriver Driver { get; set; }
        public IConnection Target { get; set; }
        public IConnection Source { get; set; }
        public IList<DriverOption> Options { get; set; }
        public Model Model { get; set; }
        public string FilePath { get; set; }
        public DateTime? LastCompared { get; set; }
        public DateTime? LastSync { get; set; }
        public string Author { get; set; }


        public Project(){}
        public Project(ProjectDTO project, string filePath)
        {
            FilePath = filePath;
            Author = project.Author;
            Source = new Connection(project.Source);
            Target = new Connection(project.Target);
            Driver = DriverRepository.GetDriverById(project.DriverId);
            LastCompared = project.LastCompared;
            LastSync = project.LastSync;
        }

        public void Refresh()
        {
            Model = Driver.BuildComparisonObjects(Source, Target);
        }


    }
}