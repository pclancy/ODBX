// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    DriverOption.cs
//   
//  

using System;

namespace ODBX.Driver
{
    public class DriverOption
    {
        public DriverOption(DriverOptionCategory category, string name, string synopsis, bool defaultValue)
        {
            Id = Guid.NewGuid();
            Category = category;
            Name = name;
            Synopsis = synopsis;
            DefaultValue = defaultValue;
        }


        public DriverOption(DriverOptionCategory category, string name, string synopsis, bool defaultValue, Guid id)
        {
            Id = id;
            Category = category;
            Name = name;
            Synopsis = synopsis;
            DefaultValue = defaultValue;
        }

        public Guid Id { get; set; }
        public DriverOptionCategory Category { get; set; }

        public bool ConfiguredValue { get; set; }
        public bool DefaultValue { get; set; }

        public string Synopsis { get; set; }

        public string Name { get; set; }
    }

    public class DriverOptionCategory
    {
        public DriverOptionCategory(string name)
        {
            Id = Guid.NewGuid();
            Name = name;
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}