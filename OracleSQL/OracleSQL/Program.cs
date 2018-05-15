using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
using System.Data;

namespace OraWinApp
{
    static class Program
    {
        static void Main()
        {
            try
            {
                string connectionString = "Data Source = 192.168.11.122:1521/DEVICARO; User Id = user_acm; Password = EBLA;";

                OracleConnection connection = new OracleConnection(connectionString);
                connection.Open();

                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "SELECT * from AEROPORTI_1";
                cmd.Connection = connection;

                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int fieldCount = dr.FieldCount;
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
