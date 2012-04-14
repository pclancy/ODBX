// 
//    ODBX.UI
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    State.cs
//   
//  

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace ODBX.Common
{
    public static class State
    {
        public static string DefaultFilePath { get; set; }

        static State()
        {
            DefaultFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public static void SaveProject(Project project)
        {
            if (string.IsNullOrWhiteSpace(project.FilePath))
            {
                project.FilePath = string.Format(@"{0}\{1}-{2} vs {3}-{4}.odbx",
                                                 DefaultFilePath,
                                                 project.Source.Host, project.Source.Catalog,
                                                 project.Target.Host, project.Target.Catalog);
            }

            var xmlSerializer = new XmlSerializer(typeof(ProjectDTO));

            using (TextWriter writeFileStream = new StreamWriter(project.FilePath))
            {
                xmlSerializer.Serialize(writeFileStream, new ProjectDTO(project));
                writeFileStream.Close();
            }
        }


        public static List<Project> ScanProjects(string folderPath)
        {
            var projects = new List<Project>();
            foreach (var enumerateFile in Directory.EnumerateFiles(folderPath, "*.odbx"))
            {
                projects.Add(LoadProject(enumerateFile));
            }

            return projects;
        }

        public static Project LoadProject(string filePath)
        {
            using (var readFileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var xmlSerializer = new XmlSerializer(typeof(ProjectDTO));
                var projectDTO = (ProjectDTO)xmlSerializer.Deserialize(readFileStream);
                readFileStream.Close();

                return new Project(projectDTO, filePath);
            }
        }
    }
}