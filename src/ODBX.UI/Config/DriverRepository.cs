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
        private static List<IDriver> _drivers;


        public static List<IDriver> GetInstalledDrivers(bool refesh = false)
        {
            if (refesh || _drivers == null)
            {
                _drivers = new List<IDriver>(new IDriver[]
                                                 {
                                                     //new FakeDriver(),
                                                     new OpenDbDiffDriver()
                                                 });
            }

            return _drivers;
        }

        public static IDriver GetDriverById(Guid id)
        {
            return _drivers.First(x => x.Id == id);
        }
    }
}