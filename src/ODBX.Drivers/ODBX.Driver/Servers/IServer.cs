// 
//    ODBX.Driver
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    IServer.cs
//   
//  

using System.Collections.Generic;

namespace ODBX.Driver.Servers
{
    public interface IServer
    {
        string LastError { get; }
        bool TestConnection(IConnection connection);
        List<string> GetCatalogs(IConnection connection);
        List<string> GetHosts();
    }
}