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
using System.Linq;
using ODBX.Driver;
using ODBX.Driver.OpenDBDiff;

namespace ODBX.Config
{
    public class DriverRepository
    {
        static readonly List<IDriver> Drivers = new List<IDriver>(new IDriver[]
                                        {
                                            new FakeDriver(),
                                            new OpenDbDiffDriver()
                                        });

        
        public static List<IDriver> GetInstalledDrivers()
        {
            return Drivers;
        }

        public static IDriver GetDriverById(Guid id)
        {
            return Drivers.First(x => x.Id == id);
        }
    }
}