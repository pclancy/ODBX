// 
//    ODBX.Driver.OpenDBDiff
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    Configuration.cs
//   
//  

using System.Collections.Generic;
using System.Linq;

namespace ODBX.Driver.OpenDBDiff
{
    public enum OptionType
    {
        FilterConstraint,
        FilterFunction,
        FilterStoreProcedure,
        FilterView,
        FilterTable,
        FilterTableOption,
        FilterUserDataType,
        FilterTrigger,
        FilterSchema,
        FilterXMLSchema,
        FilterTableFileGroup,
        FilterExtendedProperties,
        FilterDDLTriggers,
        FilterSynonyms,
        FilterRules,
        FilterAssemblies,
        FilterTableChangeTracking,
        FilterTableLockEscalation,
        FilterFullTextPath,
        FilterFullText,
        FilterCLRStoredProcedure,
        FilterCLRUserDefinedType,
        FilterCLRTrigger,
        FilterCLRFunction,
        FilterRoles,
        FilterUsers,
        FilterNotForReplication,
        FilterColumnCollation,
        FilterColumnIdentity,
        FilterColumnOrder,
        FilterIndexRowLock,
        FilterIndexIncludeColumns,
        FilterIndexFillFactor,
        FilterConstraintCheck,
        FilterConstraintUniqueKey,
        FilterConstraintForeignKey,
        FilterConstraintPrimaryKey,
        FilterIndex,
        FilterIndexFilter,
        FilterPartitionScheme,
        FilterPartitionFunction,


        ScriptAlterObjectOnSchemaBinding,

        ComparisonIgnoreWhiteSpacesInCode,
        ComparisonCaseSensitive,
    }

    public class DiffOption : DriverOption
    {
        public DiffOption(DriverOptionCategory category, string name, string synopsis, bool defaultValue, OptionType id)
            : base(category, name, synopsis, defaultValue, (int) id)
        {
        }
    }

    public class Configuration : IConfiguration
    {
        private readonly IDriver _driver;


        public Configuration(IDriver driver)
        {
            _driver = driver;

            var categoryFilters = new DriverOptionCategory("Include");
            var categoryComparison = new DriverOptionCategory("Comparison");

            OptionCategories =
                new List<DriverOptionCategory>(new[]
                                                   {
                                                       categoryFilters, categoryComparison
                                                   });

            Options = new List<DriverOption>
                          {
                              new DiffOption(categoryFilters, "Constraints", "", true, OptionType.FilterConstraint),
                              new DiffOption(categoryFilters, "Functions", "", true, OptionType.FilterFunction),
                              new DiffOption(categoryFilters, "Stored Procedures", "", true,
                                             OptionType.FilterStoreProcedure),
                              new DiffOption(categoryFilters, "Views", "", true, OptionType.FilterView),
                              new DiffOption(categoryFilters, "Tables", "", true, OptionType.FilterTable),
                              new DiffOption(categoryFilters, "Table Options", "", true, OptionType.FilterTableOption),
                              new DiffOption(categoryFilters, "User Defined Types", "", true,
                                             OptionType.FilterUserDataType),
                              new DiffOption(categoryFilters, "Triggers", "", true, OptionType.FilterTrigger),
                              new DiffOption(categoryFilters, "Schemas", "", true, OptionType.FilterSchema),
                              new DiffOption(categoryFilters, "XML Schemas", "", true, OptionType.FilterXMLSchema),
                              new DiffOption(categoryFilters, "Table File Groups", "", false,
                                             OptionType.FilterTableFileGroup),
                              new DiffOption(categoryFilters, "Extended Properties", "", false,
                                             OptionType.FilterExtendedProperties),
                              new DiffOption(categoryFilters, "DDL Triggers", "", true, OptionType.FilterDDLTriggers),
                              new DiffOption(categoryFilters, "Synonyms", "", true, OptionType.FilterSynonyms),
                              new DiffOption(categoryFilters, "Rules", "", true, OptionType.FilterRules),
                              new DiffOption(categoryFilters, "Assemblies", "", true, OptionType.FilterAssemblies),
                              new DiffOption(categoryFilters, "Table Change Tracking", "", true,
                                             OptionType.FilterTableChangeTracking),
                              new DiffOption(categoryFilters, "Table Lock Escalation", "", true,
                                             OptionType.FilterTableLockEscalation),
                              new DiffOption(categoryFilters, "Full Text Paths", "", true, OptionType.FilterFullTextPath),
                              new DiffOption(categoryFilters, "Full Text", "", true, OptionType.FilterFullText),
                              new DiffOption(categoryFilters, "CLR Stored Procedures", "", true,
                                             OptionType.FilterCLRStoredProcedure),
                              new DiffOption(categoryFilters, "CLR User Defined Types", "", true,
                                             OptionType.FilterCLRUserDefinedType),
                              new DiffOption(categoryFilters, "CLR Triggers", "", true, OptionType.FilterCLRTrigger),
                              new DiffOption(categoryFilters, "CLR Functions", "", true, OptionType.FilterCLRFunction),
                              new DiffOption(categoryFilters, "Roles", "", true, OptionType.FilterRoles),
                              new DiffOption(categoryFilters, "Users", "", true, OptionType.FilterUsers),
                              new DiffOption(categoryFilters, "Not For Replication", "", false,
                                             OptionType.FilterNotForReplication),
                              new DiffOption(categoryFilters, "Column Collation", "", false,
                                             OptionType.FilterColumnCollation),
                              new DiffOption(categoryFilters, "Column Identity", "", true,
                                             OptionType.FilterColumnIdentity),
                              new DiffOption(categoryFilters, "Column Order", "", false, OptionType.FilterColumnOrder),
                              new DiffOption(categoryFilters, "Index Row Locks", "", false,
                                             OptionType.FilterIndexRowLock),
                              new DiffOption(categoryFilters, "Index Include Columns", "", true,
                                             OptionType.FilterIndexIncludeColumns),
                              new DiffOption(categoryFilters, "Index Fill Factor", "", false,
                                             OptionType.FilterIndexFillFactor),
                              new DiffOption(categoryFilters, "Constraint Checks", "", true,
                                             OptionType.FilterConstraintCheck),
                              new DiffOption(categoryFilters, "Unique Key Constraints", "", false,
                                             OptionType.FilterConstraintUniqueKey),
                              new DiffOption(categoryFilters, "Foreign Key Constraints", "", false,
                                             OptionType.FilterConstraintForeignKey),
                              new DiffOption(categoryFilters, "Primary Key Constraints", "", false,
                                             OptionType.FilterConstraintPrimaryKey),
                              new DiffOption(categoryFilters, "Indexes", "", true, OptionType.FilterIndex),
                              new DiffOption(categoryFilters, "Index Filters", "", false, OptionType.FilterIndexFilter),
                              new DiffOption(categoryFilters, "Partition Schemes", "", false,
                                             OptionType.FilterPartitionScheme),
                              new DiffOption(categoryFilters, "Partition Functions", "", false,
                                             OptionType.FilterPartitionFunction),
                              new DiffOption(categoryComparison,
                                             "Rebuild views using SCHEMABINDING with DROP/CREATE statements", "", false,
                                             OptionType.ScriptAlterObjectOnSchemaBinding),
                              new DiffOption(categoryComparison, "Ignore White Space", "", true,
                                             OptionType.ComparisonIgnoreWhiteSpacesInCode),
                              new DiffOption(categoryComparison, "Case Sensitive", "", false,
                                             OptionType.ComparisonCaseSensitive),
                          }.OrderBy(x => x.Name).ToList();
        }

        public DriverOption this[OptionType id]
        {
            get { return Options.First(x => x.Id == (int) id); }
        }

        #region IConfiguration Members

        public IList<DriverOption> Options { get; set; }
        public IList<DriverOptionCategory> OptionCategories { get; set; }

        #endregion
    }
}