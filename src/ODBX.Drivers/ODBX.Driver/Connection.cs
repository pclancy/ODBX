// 
//    ODBX.Driver
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    Server.cs
//   
//  

using System;
using System.Linq;

namespace ODBX.Driver
{
    [Serializable]
    public class Connection : IConnection
    {
        #region IConnection Members

        public AuthenticationMethod Authentication { get; set; }
        public string Host { get; set; }
        public string Catalog { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public bool IsReady
        {
            get
            {
                bool readyState = !string.IsNullOrWhiteSpace(Host) && !string.IsNullOrWhiteSpace(Catalog);
                if (readyState)
                {
                    if (Authentication == AuthenticationMethod.Basic)
                    {
                        readyState = !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
                    }
                }

                return readyState;
            }
        }

        public string ConnectionString
        {
            get
            {
                string sql = "Data Source=" + Host + ";Initial Catalog=" + Catalog + ";";
                if (Authentication == AuthenticationMethod.Basic)
                    sql += "User Id=" + Username + ";Password=" + Password + ";";
                else
                    sql += "Integrated Security=SSPI;";

                return sql;
            }
            set
            {
                if (!String.IsNullOrEmpty(value))
                {
                    string[] items = value.Split(';');
                    foreach (var item in items.Select(t => t.Split('=')))
                    {
                        if (item[0].Equals("User Id", StringComparison.InvariantCultureIgnoreCase))
                        {
                            Username = item[1];
                            Authentication = AuthenticationMethod.Basic;
                        }
                        if (item[0].Equals("Password", StringComparison.InvariantCultureIgnoreCase))
                            Password = item[1];
                        if (item[0].Equals("Data Source", StringComparison.InvariantCultureIgnoreCase))
                            Host = item[1];
                        if (item[0].Equals("Initial Catalog", StringComparison.InvariantCultureIgnoreCase))
                            Catalog = item[1];
                        if (item[0].Equals("Integrated Security", StringComparison.InvariantCultureIgnoreCase))
                        {
                            Authentication = AuthenticationMethod.Integrated;
                            Username = "";
                            Password = "";
                        }
                    }
                }
                else
                {
                    Authentication = AuthenticationMethod.Unknown;
                    Username = "";
                    Password = "";
                    Host = "(local)";
                    Catalog = "";
                }
            }
        }

        #endregion
    }
}