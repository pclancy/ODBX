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
        private Database _merged;
        private Database _sourceModel;
        private Database _target;

        public OpenDbDiffDriver()
        {
            _configuration = new Configuration();
            _server = new SqlServer();
        }

        #region IDriver Members

        public event FeedbackHandler FeedbackMessage;
        public event EventHandler ComparisonStarted;

        public void OnComparisonStarted(EventArgs e)
        {
            var handler = ComparisonStarted;
            if (handler != null) handler(this, e);
        }

        public event EventHandler ComparisonCompleted;

        public void OnComparisonCompleted(EventArgs e)
        {
            var handler = ComparisonCompleted;
            if (handler != null) handler(this, e);
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
            OnComparisonStarted(EventArgs.Empty);

            var source = new Generate
                             {ConnectionString = sourceConnection.ConnectionString, Options = new SqlOption(true)};

            source.OnProgress += args => OnFeedbackMessage(new FeedbackEventArgs
                                                               {
                                                                   Message = args.Message,
                                                                   ProgressPercent =
                                                                       args.Progress*(40/Generate.MaxValue)
                                                               });
            _sourceModel = source.Process();


            var target = new Generate
                             {ConnectionString = targetConnection.ConnectionString, Options = new SqlOption(true)};
            target.OnProgress += args => OnFeedbackMessage(new FeedbackEventArgs
                                                               {
                                                                   Message = args.Message,
                                                                   ProgressPercent =
                                                                       40 + (args.Progress*(40/Generate.MaxValue))
                                                               });

            _target = target.Process();

            OnFeedbackMessage(new FeedbackEventArgs {Message = "Running comparison...", ProgressPercent = 90});
            _merged = Generate.Compare((Database) _sourceModel.Clone(null), _target);

            OnFeedbackMessage(new FeedbackEventArgs {Message = "Building Model...", ProgressPercent = 95});
            var model = new Model();

            _merged.Tables.ForEach(
                item => model.Add("Table", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Views.ForEach(
                item => model.Add("View", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Users.ForEach(
                item => model.Add("Users", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.UserTypes.ForEach(
                item => model.Add("User Types", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.XmlSchemas.ForEach(
                item =>
                model.Add("XML Schemas", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Assemblies.ForEach(
                item =>
                model.Add("CLR Assemblies", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.CLRFunctions.ForEach(
                item =>
                model.Add("CLR Functions", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.CLRProcedures.ForEach(
                item =>
                model.Add("CLR Procedures", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.DDLTriggers.ForEach(
                item =>
                model.Add("DDL Triggers", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Defaults.ForEach(
                item => model.Add("Defaults", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.ExtendedProperties.ForEach(
                item =>
                model.Add("Extended Properties", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.FileGroups.ForEach(
                item =>
                model.Add("File Groups", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Functions.ForEach(
                item => model.Add("Functions", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.PartitionFunctions.ForEach(
                item =>
                model.Add("Partition Functions", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.PartitionSchemes.ForEach(
                item =>
                model.Add("Partition Schemes", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Procedures.ForEach(
                item =>
                model.Add("Stored Procedures", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Roles.ForEach(
                item => model.Add("Roles", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Schemas.ForEach(
                item => model.Add("Schemas", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Synonyms.ForEach(
                item => model.Add("Synonyms", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));

            OnFeedbackMessage(new FeedbackEventArgs {Message = "Comparison Complete", ProgressPercent = 100});
            OnComparisonCompleted(EventArgs.Empty);

            return model;
        }

        public string LastError { get; private set; }

        public string Syntax
        {
            get { return "mssql"; }
        }

        public string GenerateScript(ModelObject modelObject)
        {
            ISchemaBase schemaObject = _merged.Find(modelObject.Fullname);
            return schemaObject == null ? "(no object)" : schemaObject.ToSqlDiff().ToSQL();
        }

        #endregion

        public void OnFeedbackMessage(FeedbackEventArgs e)
        {
            FeedbackHandler handler = FeedbackMessage;
            if (handler != null) handler(this, e);
        }

        private Action ResolveAction(Enums.ObjectStatusType status)
        {
            switch (status)
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
                case Enums.ObjectStatusType.AlterStatus:
                    return Action.Alter;
            }

            return Action.Unknown;
        }
    }
}