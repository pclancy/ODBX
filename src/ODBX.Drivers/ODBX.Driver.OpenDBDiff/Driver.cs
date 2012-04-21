// 
//    ODBX.Driver.OpenDBDiff
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    Driver.cs
//   
//  

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        private static readonly Dictionary<Enums.ObjectStatusType, Difference> DifferenceMap = new Dictionary
            <Enums.ObjectStatusType, Difference>
                                                                                                   {
                                                                                                       {
                                                                                                           Enums.
                                                                                                           ObjectStatusType
                                                                                                           .
                                                                                                           OriginalStatus
                                                                                                           ,
                                                                                                           new Difference
                                                                                                               {
                                                                                                                   Action
                                                                                                                       =
                                                                                                                       Action
                                                                                                                       .
                                                                                                                       None,
                                                                                                                   DisplayValue
                                                                                                                       =
                                                                                                                       "Identical",
                                                                                                                   IsDifferent
                                                                                                                       =
                                                                                                                       false,
                                                                                                                   IsInSource
                                                                                                                       =
                                                                                                                       true,
                                                                                                                   IsInTarget
                                                                                                                       =
                                                                                                                       true
                                                                                                               }
                                                                                                           },
                                                                                                       {
                                                                                                           Enums.
                                                                                                           ObjectStatusType
                                                                                                           .CreateStatus
                                                                                                           ,
                                                                                                           new Difference
                                                                                                               {
                                                                                                                   Action
                                                                                                                       =
                                                                                                                       Action
                                                                                                                       .
                                                                                                                       Create,
                                                                                                                   DisplayValue
                                                                                                                       =
                                                                                                                       "Only in Source",
                                                                                                                   IsDifferent
                                                                                                                       =
                                                                                                                       true,
                                                                                                                   IsInSource
                                                                                                                       =
                                                                                                                       true,
                                                                                                                   IsInTarget
                                                                                                                       =
                                                                                                                       false
                                                                                                               }
                                                                                                           },
                                                                                                       {
                                                                                                           Enums.
                                                                                                           ObjectStatusType
                                                                                                           .AlterStatus,
                                                                                                           new Difference
                                                                                                               {
                                                                                                                   Action
                                                                                                                       =
                                                                                                                       Action
                                                                                                                       .
                                                                                                                       Alter,
                                                                                                                   DisplayValue
                                                                                                                       =
                                                                                                                       "Different",
                                                                                                                   IsDifferent
                                                                                                                       =
                                                                                                                       true,
                                                                                                                   IsInSource
                                                                                                                       =
                                                                                                                       true,
                                                                                                                   IsInTarget
                                                                                                                       =
                                                                                                                       true
                                                                                                               }
                                                                                                           },
                                                                                                       {
                                                                                                           Enums.
                                                                                                           ObjectStatusType
                                                                                                           .DropStatus,
                                                                                                           new Difference
                                                                                                               {
                                                                                                                   Action
                                                                                                                       =
                                                                                                                       Action
                                                                                                                       .
                                                                                                                       Drop,
                                                                                                                   DisplayValue
                                                                                                                       =
                                                                                                                       "Only in Target",
                                                                                                                   IsDifferent
                                                                                                                       =
                                                                                                                       true,
                                                                                                                   IsInSource
                                                                                                                       =
                                                                                                                       false,
                                                                                                                   IsInTarget
                                                                                                                       =
                                                                                                                       true
                                                                                                               }
                                                                                                           },
                                                                                                       {
                                                                                                           Enums.
                                                                                                           ObjectStatusType
                                                                                                           .
                                                                                                           RebuildStatus
                                                                                                           ,
                                                                                                           new Difference
                                                                                                               {
                                                                                                                   Action
                                                                                                                       =
                                                                                                                       Action
                                                                                                                       .
                                                                                                                       Rebuild,
                                                                                                                   DisplayValue
                                                                                                                       =
                                                                                                                       "Different",
                                                                                                                   IsDifferent
                                                                                                                       =
                                                                                                                       true,
                                                                                                                   IsInSource
                                                                                                                       =
                                                                                                                       true,
                                                                                                                   IsInTarget
                                                                                                                       =
                                                                                                                       true
                                                                                                               }
                                                                                                           },
                                                                                                   };

        private readonly Configuration _configuration;
        private readonly IServer _server;
        private Database _merged;
        private Database _source;
        private Database _target;

        public OpenDbDiffDriver()
        {
            _configuration = new Configuration(this);
            _server = new SqlServer();
        }

        #region IDriver Members

        public event FeedbackHandler FeedbackMessage;
        public event EventHandler ComparisonStarted;

        public event EventHandler ComparisonCompleted;

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
            SqlOption options = BuildOptions();

            OnComparisonStarted(EventArgs.Empty);

            var source = new Generate {ConnectionString = sourceConnection.ConnectionString, Options = options};

            source.OnProgress += args => OnFeedbackMessage(new FeedbackEventArgs
                                                               {
                                                                   Message = args.Message,
                                                                   ProgressPercent =
                                                                       args.Progress*(40/Generate.MaxValue)
                                                               });
            _source = source.Process();


            var target = new Generate {ConnectionString = targetConnection.ConnectionString, Options = options};
            target.OnProgress += args => OnFeedbackMessage(new FeedbackEventArgs
                                                               {
                                                                   Message = args.Message,
                                                                   ProgressPercent =
                                                                       40 + (args.Progress*(40/Generate.MaxValue))
                                                               });

            _target = target.Process();

            OnFeedbackMessage(new FeedbackEventArgs {Message = "Running comparison...", ProgressPercent = 90});
            _merged = Generate.Compare((Database) _target.Clone(null), _source);

            OnFeedbackMessage(new FeedbackEventArgs {Message = "Building Model...", ProgressPercent = 95});
            var model = new Model();

            _merged.Tables.ForEach(
                item => model.Add("Table", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Views.ForEach(
                item => model.Add("View", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Users.ForEach(
                item => model.Add("User", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.UserTypes.ForEach(
                item => model.Add("User Type", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.XmlSchemas.ForEach(
                item => model.Add("XML Schema", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Assemblies.ForEach(
                item =>
                model.Add("CLR Assemblie", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.CLRFunctions.ForEach(
                item =>
                model.Add("CLR Function", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.CLRProcedures.ForEach(
                item =>
                model.Add("CLR Procedure", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.DDLTriggers.ForEach(
                item =>
                model.Add("DDL Trigger", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Defaults.ForEach(
                item => model.Add("Default", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.ExtendedProperties.ForEach(
                item =>
                model.Add("Extended Property", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.FileGroups.ForEach(
                item =>
                model.Add("File Groups", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Functions.ForEach(
                item => model.Add("Functions", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.PartitionFunctions.ForEach(
                item =>
                model.Add("Partition Function", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.PartitionSchemes.ForEach(
                item =>
                model.Add("Partition Scheme", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Procedures.ForEach(
                item =>
                model.Add("Stored Procedure", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Roles.ForEach(
                item => model.Add("Role", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Schemas.ForEach(
                item => model.Add("Schema", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));
            _merged.Synonyms.ForEach(
                item => model.Add("Synonym", item.FullName, new Guid(item.Guid), item.Id, ResolveAction(item.Status)));

            OnFeedbackMessage(new FeedbackEventArgs {Message = "Comparison Complete", ProgressPercent = 100});
            OnComparisonCompleted(EventArgs.Empty);

            return model;
        }

        public string GenerateScript(ScriptAction action, ModelObject modelObject)
        {
            ISchemaBase schemaObject;
            switch (action)
            {
                case ScriptAction.OriginalFromSource:
                    schemaObject = _source.Find(modelObject.Name);
                    return schemaObject == null ? string.Empty : schemaObject.ToSql();

                case ScriptAction.OriginalFromTarget:
                    schemaObject = _target.Find(modelObject.Name);
                    return schemaObject == null ? string.Empty : schemaObject.ToSql();

                case ScriptAction.Merged:
                    schemaObject = _merged.Find(modelObject.Name);
                    return schemaObject == null ? string.Empty : schemaObject.ToSqlDiff().ToSQL();
            }

            return string.Empty;
        }

        public string GenerateScript(IList<ModelObject> objects)
        {
            var schemaList = new List<ISchemaBase>();
            foreach (var modelObject in objects)
            {
                var schemaObject = _merged.Find(modelObject.Name);
                if (schemaObject != null)
                    schemaList.Add(schemaObject);

            }


            var script = new StringBuilder();
            foreach (var schemaBase in schemaList)
            {
                script.Append(schemaBase.ToSqlDiff().ToSQL());
            }

            return script.ToString();
        }


        public string LastError { get; private set; }

        public string Syntax
        {
            get { return "mssql"; }
        }

        #endregion

        public void OnComparisonStarted(EventArgs e)
        {
            EventHandler handler = ComparisonStarted;
            if (handler != null) handler(this, e);
        }

        public void OnComparisonCompleted(EventArgs e)
        {
            EventHandler handler = ComparisonCompleted;
            if (handler != null) handler(this, e);
        }

        private SqlOption BuildOptions()
        {
            var config = (Configuration) Configuration;
            var options = new SqlOption(false)
                              {
                                  Ignore =
                                      {
                                          FilterConstraint = config[OptionType.FilterConstraint].ConfiguredValue,
                                          FilterFunction = config[OptionType.FilterFunction].ConfiguredValue,
                                          FilterStoreProcedure = config[OptionType.FilterStoreProcedure].ConfiguredValue,
                                          FilterView = config[OptionType.FilterView].ConfiguredValue,
                                          FilterTable = config[OptionType.FilterTable].ConfiguredValue,
                                          FilterTableOption = config[OptionType.FilterTableOption].ConfiguredValue,
                                          FilterUserDataType = config[OptionType.FilterUserDataType].ConfiguredValue,
                                          FilterTrigger = config[OptionType.FilterTrigger].ConfiguredValue,
                                          FilterSchema = config[OptionType.FilterSchema].ConfiguredValue,
                                          FilterXMLSchema = config[OptionType.FilterXMLSchema].ConfiguredValue,
                                          FilterTableFileGroup = config[OptionType.FilterTableFileGroup].ConfiguredValue,
                                          FilterExtendedPropertys =
                                              config[OptionType.FilterExtendedProperties].ConfiguredValue,
                                          FilterDDLTriggers = config[OptionType.FilterDDLTriggers].ConfiguredValue,
                                          FilterSynonyms = config[OptionType.FilterSynonyms].ConfiguredValue,
                                          FilterRules = config[OptionType.FilterRules].ConfiguredValue,
                                          FilterAssemblies = config[OptionType.FilterAssemblies].ConfiguredValue,
                                          FilterTableChangeTracking =
                                              config[OptionType.FilterTableChangeTracking].ConfiguredValue,
                                          FilterTableLockEscalation =
                                              config[OptionType.FilterTableLockEscalation].ConfiguredValue,
                                          FilterFullTextPath = config[OptionType.FilterFullTextPath].ConfiguredValue,
                                          FilterFullText = config[OptionType.FilterFullText].ConfiguredValue,
                                          FilterCLRStoreProcedure =
                                              config[OptionType.FilterCLRStoredProcedure].ConfiguredValue,
                                          FilterCLRUDT = config[OptionType.FilterCLRUserDefinedType].ConfiguredValue,
                                          FilterCLRTrigger = config[OptionType.FilterCLRTrigger].ConfiguredValue,
                                          FilterCLRFunction = config[OptionType.FilterCLRFunction].ConfiguredValue,
                                          FilterRoles = config[OptionType.FilterRoles].ConfiguredValue,
                                          FilterUsers = config[OptionType.FilterUsers].ConfiguredValue,
                                          FilterNotForReplication =
                                              config[OptionType.FilterNotForReplication].ConfiguredValue,
                                          FilterColumnCollation =
                                              config[OptionType.FilterColumnCollation].ConfiguredValue,
                                          FilterColumnIdentity = config[OptionType.FilterColumnIdentity].ConfiguredValue,
                                          FilterColumnOrder = config[OptionType.FilterColumnOrder].ConfiguredValue,
                                          FilterIndexRowLock = config[OptionType.FilterIndexRowLock].ConfiguredValue,
                                          FilterIndexIncludeColumns =
                                              config[OptionType.FilterIndexIncludeColumns].ConfiguredValue,
                                          FilterIndexFillFactor =
                                              config[OptionType.FilterIndexFillFactor].ConfiguredValue,
                                          FilterConstraintCheck =
                                              config[OptionType.FilterConstraintCheck].ConfiguredValue,
                                          FilterConstraintUK =
                                              config[OptionType.FilterConstraintUniqueKey].ConfiguredValue,
                                          FilterConstraintFK =
                                              config[OptionType.FilterConstraintForeignKey].ConfiguredValue,
                                          FilterConstraintPK =
                                              config[OptionType.FilterConstraintPrimaryKey].ConfiguredValue,
                                          FilterIndex = config[OptionType.FilterIndex].ConfiguredValue,
                                          FilterIndexFilter = config[OptionType.FilterIndexFilter].ConfiguredValue,
                                          FilterPartitionScheme =
                                              config[OptionType.FilterPartitionScheme].ConfiguredValue,
                                          FilterPartitionFunction =
                                              config[OptionType.FilterPartitionFunction].ConfiguredValue,
                                      },
                                  Comparison =
                                      {
                                          IgnoreWhiteSpacesInCode =
                                              config[OptionType.ComparisonIgnoreWhiteSpacesInCode].ConfiguredValue,
                                          CaseSensityType =
                                              config[OptionType.FilterPartitionFunction].ConfiguredValue
                                                  ? SqlOptionComparison.CaseSensityOptions.CaseSensity
                                                  : SqlOptionComparison.CaseSensityOptions.Automatic,
                                          CaseSensityInCode =
                                              config[OptionType.FilterPartitionFunction].ConfiguredValue
                                                  ? SqlOptionComparison.CaseSensityOptions.CaseSensity
                                                  : SqlOptionComparison.CaseSensityOptions.Automatic,
                                      },
                                  Script =
                                      {
                                          AlterObjectOnSchemaBinding =
                                              config[OptionType.ScriptAlterObjectOnSchemaBinding].ConfiguredValue
                                      }
                              };


            return options;
        }

        public void OnFeedbackMessage(FeedbackEventArgs e)
        {
            FeedbackHandler handler = FeedbackMessage;
            if (handler != null) handler(this, e);
        }


        private Difference ResolveAction(Enums.ObjectStatusType status)
        {
            Difference match = DifferenceMap.FirstOrDefault(x => x.Key.HasFlag(status)).Value;

            if (match == null)
            {
                return new Difference {Action = Action.None, DisplayValue = "Error"};
            }

            match.InternalState = status.ToString();
            return match;
        }
    }
}