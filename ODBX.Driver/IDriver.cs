// 
//    ODBX.Driver
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    IDriver.cs
//   
//  

using System;
using ODBX.Driver.Servers;

namespace ODBX.Driver
{
    public enum AuthenticationMethod
    {
        Unknown = 0,
        Integrated = 1,
        Basic = 2
    }

    public interface IDriver
    {
        string Name { get; }
        string License { get; }
        Version Version { get; }
        IConfiguration Configuration { get; }
        IServer Server { get; }

        Guid Id { get; }

        void BuildComparisonObjects(IConnection connection);
        string LastError { get; }
    }
}