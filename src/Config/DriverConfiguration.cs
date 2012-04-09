// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    DriverConfiguration.cs
//   
//  

using System.Collections.Generic;

namespace ODBX.Config
{
    public abstract class DriverConfiguration
    {
        public IList<DriverOption> Options { get; set; }
        public IList<DriverOptionCategory> OptionCategories { get; set; }
    }

}