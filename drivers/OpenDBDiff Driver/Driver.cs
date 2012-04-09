// 
//    ODBX.Driver.OpenDBDiff
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    Driver.cs
//   
//  

using System;
using DBDiff.Schema.SQLServer.Generates.Generates;
using DBDiff.Schema.SQLServer.Generates.Model;
using DBDiff.Schema.SQLServer.Generates.Options;
using ODBX.Driver.Servers;

namespace ODBX.Driver.OpenDBDiff
{
    public class OpenDbDiffDriver : IDriver
    {
        private readonly Configuration _configuration;
        private readonly IServer _server;

        public OpenDbDiffDriver()
        {
            _configuration = new Configuration();
            _server = new SqlServer();
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

        public IServer Server
        {
            get { return _server; }
        }

        public Guid Id
        {
            get { return new Guid("{1F752582-6081-4A78-8DF6-A31D99BC2241}"); }
        }

        public void BuildComparisonObjects(IConnection connection)
        {
            var source = new Generate { ConnectionString = connection.ConnectionString, Options = new SqlOption(true) };
            var sourceModel = source.Process();

            var destination = new Generate { ConnectionString = connection.ConnectionString, Options = new SqlOption(true) };
            var destinationModel = destination.Process();

            var merged = Generate.Compare((Database) sourceModel.Clone(null), destinationModel);
        }

        public string LastError { get; private set; }
    }
}