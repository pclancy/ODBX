// 
//    ODBX
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    SqlServerConfig.cs
//   
//  

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;

namespace ODBX.Config
{
    public class SqlServerConfig : IServerConfig
    {

        public string LastError { get; private set; }

        public bool TestConnection(ConnectionConfiguration configuration)
        {
            try
            {
                var connection = new SqlConnection {ConnectionString = configuration.ConnectionString};
                connection.Open();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return false;
            }
        }

        public List<string> GetCatalogs(ConnectionConfiguration config)
        {
            config.Catalog = "master";

            var catalogList = new List<string>();
            using (var conn = new SqlConnection(config.ConnectionString))
            {
                conn.Open();
                using (
                    var command = new SqlCommand("SELECT name,database_id FROM sys.databases ORDER BY Name", conn))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            catalogList.Add(reader["Name"].ToString());
                        }
                    }
                }
            }

            return catalogList;
        }

        public List<string> GetHosts()
        {
            var sqlSource = SqlDataSourceEnumerator.Instance;
            var dt = sqlSource.GetDataSources();

            return (from DataRow dr in dt.Rows
                    let serverName = dr["ServerName"].ToString()
                    let instanceName = dr["InstanceName"] != null ? dr["InstanceName"].ToString() : null
                    select string.IsNullOrEmpty(instanceName) ? serverName : string.Format("{0}\\{1}", serverName, instanceName)).ToList();
        }
    }
}