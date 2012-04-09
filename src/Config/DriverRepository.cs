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
                                            new FakeDriver()
                                        });
        }
    }
}