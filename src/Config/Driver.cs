// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    Driver.cs
//   
//  

using System;

namespace ODBX.Config
{
    public abstract class Driver
    {
        public abstract string Name { get; }
        public abstract string License { get; }
        public abstract Version Version { get; }
        public abstract DriverConfiguration Configuration { get; }
    }
}