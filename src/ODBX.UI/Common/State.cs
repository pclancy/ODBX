using System;
using System.IO;
using System.Xml.Serialization;

namespace ODBX.Common
{
    public static class State
    {
        private static string _defaultFilePath;
        public static string DefaultFilePath
        {
            get { return _defaultFilePath; }
            set { _defaultFilePath = value; }
        }

        static State()
        {
            _defaultFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
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


        public static Project LoadProject(string filePath)
        {
            var readFileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);

            // Load the object saved above by using the Deserialize function
            //TestClass LoadedObj = (TestClass)SerializerObj.Deserialize(readFileStream);

            // Cleanup
            readFileStream.Close();
            return null;
        }
    }
}