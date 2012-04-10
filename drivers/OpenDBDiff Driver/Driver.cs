// 
//    ODBX.Driver.OpenDBDiff
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    Driver.cs
//   
//  

using System;
using DBDiff.Schema;
using DBDiff.Schema.Model;
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
        private Database _sourceModel;
        private Database _merged;
        private Database _target;

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

        public Model BuildComparisonObjects(IConnection sourceConnection, IConnection targetConnection)
        {
            var source = new Generate { ConnectionString = sourceConnection.ConnectionString, Options = new SqlOption(true) };
            _sourceModel = source.Process();

            var target = new Generate { ConnectionString = targetConnection.ConnectionString, Options = new SqlOption(true) };
            _target = target.Process();

            _merged = Generate.Compare((Database) _sourceModel.Clone(null), _target);

            var model = new Model();

            _merged.Tables.ForEach(item => model.Add("Table", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Views.ForEach(item => model.Add("View", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Users.ForEach(item => model.Add("Users", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.UserTypes.ForEach(item => model.Add("User Types", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.XmlSchemas.ForEach(item => model.Add("XML Schemas", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Assemblies.ForEach(item => model.Add("CLR Assemblies", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.CLRFunctions.ForEach(item => model.Add("CLR Functions", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.CLRProcedures.ForEach(item => model.Add("CLR Procedures", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.DDLTriggers.ForEach(item => model.Add("DDL Triggers", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Defaults.ForEach(item => model.Add("Defaults", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.ExtendedProperties.ForEach(item => model.Add("Extended Properties", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.FileGroups.ForEach(item => model.Add("File Groups", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Functions.ForEach(item => model.Add("Functions", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.PartitionFunctions.ForEach(item => model.Add("Partition Functions", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.PartitionSchemes.ForEach(item => model.Add("Partition Schemes", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Procedures.ForEach(item => model.Add("Stored Procedures", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Roles.ForEach(item => model.Add("Roles", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Schemas.ForEach(item => model.Add("Schemas", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Synonyms.ForEach(item => model.Add("Synonyms", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            return model;
        }

        private Action ResolveAction(Enums.ObjectStatusType status)
        {
                switch(status)
                {
                    case Enums.ObjectStatusType.CreateStatus:
                        return Action.Create;
                    case Enums.ObjectStatusType.DropStatus:
                        return Action.Drop;
                    case Enums.ObjectStatusType.UpdateStatus:
                        return Action.Update;
                    case Enums.ObjectStatusType.RebuildStatus:
                        return Action.Rebuild;
                    case Enums.ObjectStatusType.OriginalStatus:
                        return Action.None;
                }

                return Action.Unknown;
            
        }

        public string LastError { get; private set; }
        public string GenerateScript(ModelObject modelObject)
        {
            var schemaObject =_merged.Find(modelObject.Fullname);
            return schemaObject == null ? "(no object)" : schemaObject.ToSql();
        }
    }
}