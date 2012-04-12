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

    public delegate void FeedbackHandler(object sender, FeedbackEventArgs args);

    public interface IDriver
    {
        string Name { get; }
        string License { get; }
        Version Version { get; }
        IConfiguration Configuration { get; }
        IServer Server { get; }

        Guid Id { get; }

        string LastError { get; }
        string Syntax { get; }
        event FeedbackHandler FeedbackMessage;
        Model BuildComparisonObjects(IConnection sourceConnection, IConnection targetConnection);
        string GenerateScript(ModelObject modelObject);
    }

    public class FeedbackEventArgs : EventArgs
    {
        public string Message { get; set; }
        public int ProgressPercent { get; set; }
    }
}