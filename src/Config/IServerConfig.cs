// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    IServerConfig.cs
//   
//  

using System.Collections.Generic;

namespace ODBX.Config
{
    public interface IServerConfig
    {
        List<string> GetCatalogs(ConnectionConfiguration config);
        List<string> GetHosts();
        bool TestConnection(ConnectionConfiguration configuration);
        string LastError { get;}
    }
}