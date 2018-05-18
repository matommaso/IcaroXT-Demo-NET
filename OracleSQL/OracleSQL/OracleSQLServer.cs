using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleSQL
{
    public class OracleSQLServer
    {
        public static string connectionString = "Data Source = 192.168.11.122:1521/DEVICARO; User Id = user_acm; Password = EBLA;";

        public List<string> ExecuteQuery(String sqlQuery)
        {
            List<string> results = new List<string>();
            try
            {
                OracleConnection connection = new OracleConnection(connectionString);
                connection.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sqlQuery;
                cmd.Connection = connection;

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    StringBuilder sb = new StringBuilder();
                    int fieldCount = dr.FieldCount;
                    for (int i = 0; i < fieldCount; i++)
                    {
                        sb.Append(dr[i].ToString()).Append(",");
                    }
                    results.Add(sb.ToString());
                }
                connection.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            return results;
        }
    }
}
