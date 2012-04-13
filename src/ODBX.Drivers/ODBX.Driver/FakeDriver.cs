// 
//    ODBX.Driver
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    FakeDriver.cs
//   
//  

using System;
using System.Collections.Generic;
using ODBX.Driver.Servers;

namespace ODBX.Driver
{
    public class FakeDriver : IDriver
    {
        private readonly FakeDriverConfiguration _configuration;

        public FakeDriver()
        {
            _configuration = new FakeDriverConfiguration();
        }

        #region IDriver Members

        public event FeedbackHandler FeedbackMessage;
        public event EventHandler ComparisonStarted;
        public event EventHandler ComparisonCompleted;

        public string Name
        {
            get { return "Fake Driver"; }
        }

        public string License
        {
            get { return "GPL"; }
        }

        public Version Version
        {
            get { return new Version(1, 0); }
        }

        public IConfiguration Configuration
        {
            get { return _configuration; }
        }

        public IServer Server
        {
            get { return new FakeServer(); }
        }

        public Guid Id
        {
            get { return new Guid("{0DF47C45-D084-4C10-8BB2-8B372AF5B882}"); }
        }


        public Model BuildComparisonObjects(IConnection sourceConnection, IConnection targetConnection)
        {
            return null;
        }

        public string GenerateScript(ScriptAction action, ModelObject modelObject)
        {
            return string.Empty;
        }

        public string LastError { get; private set; }

        public string Syntax
        {
            get { return "mssql"; }
        }

        public string GenerateScript(ModelObject modelObject)
        {
            return string.Empty;
        }

        #endregion
    }

    public class FakeServer : IServer
    {
        #region IServer Members

        public string LastError
        {
            get { return string.Empty; }
        }

        public bool TestConnection(IConnection connection)
        {
            return true;
        }

        public List<string> GetCatalogs(IConnection connection)
        {
            return new List<string>();
        }

        public List<string> GetHosts()
        {
            return new List<string>();
        }

        #endregion
    }

    public class FakeDriverConfiguration : IConfiguration
    {
        private static readonly Guid OPTION_THROW_EXCEPTION = new Guid("{92D4FE1C-186A-4089-8A65-DA56E5245365}");

        public FakeDriverConfiguration()
        {
            var optionCategory = new DriverOptionCategory("Behaviour");

            OptionCategories = new List<DriverOptionCategory>(new[] {optionCategory});

            Options = new List<DriverOption>
                          {
                              new DriverOption(optionCategory, "Throw Exception", "", true, OPTION_THROW_EXCEPTION),
                          };
        }

        #region IConfiguration Members

        public IList<DriverOption> Options { get; set; }
        public IList<DriverOptionCategory> OptionCategories { get; set; }

        #endregion
    }
}