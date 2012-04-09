// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    DriverRepository.cs
//   
//  

using System;
using System.Collections.Generic;

namespace ODBX.Config
{
    public class DriverRepository
    {
        public static List<Driver> GetInstalledDrivers()
        {
            return new List<Driver>(new[]
                                        {
                                            new Driver {License = "GPL", Name = "Open DB Diff", Version = new Version(1, 0)}
                                        });
        }
    }

    public class Driver
    {
        public string Name { get; set; }
        public string License { get; set; }
        public Version Version { get; set; }
    }
}