// 
//    ODBX.Driver
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    IConnection.cs
//   
//  

namespace ODBX.Driver
{
    public interface IConnection
    {
        AuthenticationMethod Authentication { get; set; }
        string Host { get; set; }
        string Catalog { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        bool IsReady { get; }
        string ConnectionString { get; set; }
        string Summary { get; }
    }
}