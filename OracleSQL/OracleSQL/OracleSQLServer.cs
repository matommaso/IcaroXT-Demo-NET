using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleSQL
{
    class OracleSQLServer
    {
        public static string connectionString = "Data Source = 192.168.11.122:1521/DEVICARO; User Id = user_acm; Password = EBLA;";

        public void ExecuteQuery(String sqlQuery)
        {
            try
            {
                OracleConnection connection = new OracleConnection(connectionString);
                connection.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = sqlQuery;
                cmd.Connection = connection;

                int rowNumber = 1;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int fieldCount = dr.FieldCount;
                    Console.Write(rowNumber++ + " ");
                    for (int i = 0; i < fieldCount; i++)
                    {
                        Console.Write(dr[i] + " ");
                    }
                    Console.WriteLine();
                }
                Console.ReadLine();
                connection.Dispose();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
