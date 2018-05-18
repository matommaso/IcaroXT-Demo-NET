using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Oracle.DataAccess.Client;
using System.Data;

namespace OracleSQL
{
    static class Program
    {
        static void Main()
        {
            string sqlQuery = "SELECT* from ABILITAZIONE";
            OracleSQLServer sqlServer = new OracleSQLServer();
            DataTable results = sqlServer.ExecuteQuery(sqlQuery);

            for (int i = 0; i < results.Rows.Count; i++)
            {
                Console.WriteLine($" {i}  { results.Rows[i]["SIGLA"]}");
            }
            Console.ReadLine();
        }
    }
}
