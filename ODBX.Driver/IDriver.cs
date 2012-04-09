// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    Driver.cs
//   
//  

using System;

namespace ODBX.Driver
{
    public interface IDriver
    {
        string Name { get; }
        string License { get; }
        Version Version { get; }
        IConfiguration Configuration { get; }
        Guid Id { get; }
    }

}