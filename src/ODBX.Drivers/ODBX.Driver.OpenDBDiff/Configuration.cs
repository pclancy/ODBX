// 
//    ODBX.Driver.OpenDBDiff
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    Configuration.cs
//   
//  

using System;
using System.Collections.Generic;

namespace ODBX.Driver.OpenDBDiff
{
    public class Configuration : IConfiguration
    {
        private static readonly Guid OPTION_TABLE_COLUMN_COLLATION = new Guid("{92D4FE1C-186A-4089-8A65-DA56E5245365}");
        private static readonly Guid OPTION_TABLE_COLUMN_ORDER = new Guid("{4DAAFA50-8C15-48A0-815D-D5174A0C3099}");
        private static readonly Guid OPTION_TABLE_IDENTITY_OPTIONS = new Guid("{13AA52FD-4A0E-4BB2-970B-BD81581626ED}");

        public Configuration()
        {
            var categoryFilters = new DriverOptionCategory("Compare");
            var categoryTables = new DriverOptionCategory("Tables");
            var categoryIndexes = new DriverOptionCategory("Indexes");
            var categoryConstraints = new DriverOptionCategory("Constraints");
            var categoryComparison = new DriverOptionCategory("Comparison");

            OptionCategories =
                new List<DriverOptionCategory>(new[]
                                                   {
                                                       categoryTables, categoryIndexes, categoryConstraints,
                                                       categoryFilters, categoryComparison
                                                   });

            Options = new List<DriverOption>
                          {
                              new DriverOption(categoryTables, "Column Collation", "", true,
                                               OPTION_TABLE_COLUMN_COLLATION),
                              new DriverOption(categoryTables, "Column Order", "", true),
                              new DriverOption(categoryTables, "Identity Options", "", true),
                              new DriverOption(categoryTables, "Table Options", "", true),
                              new DriverOption(categoryTables, "Lock Escalation", "", true),
                              new DriverOption(categoryTables, "Change Tracking", "", true),
                              new DriverOption(categoryIndexes, "Row Locks", "", true),
                              new DriverOption(categoryIndexes, "Fill Factor", "", true),
                              new DriverOption(categoryIndexes, "Include Columns", "", true),
                              new DriverOption(categoryIndexes, "Filter Columns", "", true),
                              new DriverOption(categoryConstraints, "Primary Key Constraints", "", true),
                              new DriverOption(categoryConstraints, "Foreign Key Constraints", "", true),
                              new DriverOption(categoryConstraints, "Unique Key Constraints", "", true),
                              new DriverOption(categoryConstraints, "Check Constraints", "", true),
                              new DriverOption(categoryComparison, "Extended Properties", "", true),
                              new DriverOption(categoryComparison, "Ignore Not For Replication", "", true),
                              new DriverOption(categoryFilters, "File Groups", "", true),
                              new DriverOption(categoryFilters, "Full Text Indexes", "", true),
                              new DriverOption(categoryFilters, "Full Text Index Paths", "", true),
                              new DriverOption(categoryFilters, "Users", "", true),
                              new DriverOption(categoryFilters, "Roles", "", true),
                              new DriverOption(categoryFilters, "Schemas", "", true),
                              new DriverOption(categoryFilters, "Permissions", "", true),
                              new DriverOption(categoryFilters, "CLR Aggregates", "", true),
                              new DriverOption(categoryFilters, "CLR Functions", "", true),
                              new DriverOption(categoryFilters, "CLR Stored Procedures", "", true),
                              new DriverOption(categoryFilters, "CLR User Defined Types", "", true),
                              new DriverOption(categoryFilters, "CLR Triggers", "", true),
                              new DriverOption(categoryFilters, "Functions", "", true),
                              new DriverOption(categoryFilters, "Views", "", true),
                              new DriverOption(categoryFilters, "Stored Procedures", "", true),
                              new DriverOption(categoryFilters, "Triggers", "", true),
                              new DriverOption(categoryFilters, "DDL Triggers", "", true),
                              new DriverOption(categoryFilters, "User Defined Types", "", true),
                              new DriverOption(categoryFilters, "XML Schemas", "", true),
                              new DriverOption(categoryFilters, "Rules", "", true),
                              new DriverOption(categoryFilters, "Partition Function", "", true),
                              new DriverOption(categoryFilters, "Partition Schema", "", true),
                              new DriverOption(categoryComparison, "Case Sensitive", "", false),
                              new DriverOption(categoryComparison, "Ignore white space", "", false),
                              new DriverOption(categoryComparison,
                                               "Rebuild views using SCHEMABINDING with DROP/CREATE statements", "",
                                               false),
                          };
        }

        #region IConfiguration Members

        public IList<DriverOption> Options { get; set; }
        public IList<DriverOptionCategory> OptionCategories { get; set; }

        #endregion
    }
}