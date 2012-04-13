// 
//    ODBX.Driver
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    IConfiguration.cs
//   
//  

using System;
using System.Collections.Generic;

namespace ODBX.Driver
{
    public interface IConfiguration
    {
        IList<DriverOption> Options { get; set; }
        IList<DriverOptionCategory> OptionCategories { get; set; }
    }
}