// 
//    ODBX.Driver.OpenDBDiff
// 	
//    Copyright (c) 2011 Paul Clancy
//  
//    SqlServerConnection.cs
//   
//  

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;

namespace ODBX.Driver.Servers
{
    public class SqlServer : IServer
    {
        #region IServer Members

        public string LastError { get; private set; }

        public bool TestConnection(IConnection connection)
        {
            try
            {
                using (var conn = new SqlConnection {ConnectionString = connection.ConnectionString})
                {
                    conn.Open();
                    conn.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                return false;
            }
        }

        public List<string> GetCatalogs(IConnection connection)
        {
            connection.Catalog = "master";

            var catalogList = new List<string>();
            using (var conn = new SqlConnection(connection.ConnectionString))
            {
                conn.Open();
                using (
                    var command = new SqlCommand("SELECT name,database_id FROM sys.databases ORDER BY Name", conn))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
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
            SqlDataSourceEnumerator sqlSource = SqlDataSourceEnumerator.Instance;
            DataTable dt = sqlSource.GetDataSources();

            return (from DataRow dr in dt.Rows
                    let serverName = dr["ServerName"].ToString()
                    let instanceName = dr["InstanceName"] != null ? dr["InstanceName"].ToString() : null
                    select
                        string.IsNullOrEmpty(instanceName)
                            ? serverName
                            : string.Format("{0}\\{1}", serverName, instanceName)).ToList();
        }

        #endregion
    }
}