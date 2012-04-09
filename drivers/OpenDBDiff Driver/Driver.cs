// 
//    ODBX.Driver.OpenDBDiff
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    Driver.cs
//   
//  

using System;

namespace ODBX.Driver.OpenDBDiff
{
    public class OpenDbDiffDriver : IDriver
    {
        private readonly Configuration _configuration;

        public OpenDbDiffDriver()
        {
            _configuration = new Configuration();
        }

        public string Name
        {
            get { return "SQL Server - Open DB Diff Project"; }
        }

        public string License
        {
            get { return "GPL"; }
        }

        public Version Version
        {
            get { return new Version(1, 0); }
        }

        public IConfiguration Configuration
        {
            get { return _configuration; }
        }

        public Guid Id
        {
            get { return new Guid("{1F752582-6081-4A78-8DF6-A31D99BC2241}"); }
        }
    }
}