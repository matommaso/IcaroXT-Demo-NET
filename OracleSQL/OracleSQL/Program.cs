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
            OracleSQLServerEF oracleSQLServerEF = new OracleSQLServerEF();
            var listAbilitaziones = oracleSQLServerEF.GetABILITAZIONEs();
            foreach (ABILITAZIONE ab in listAbilitaziones)
            {
                Console.WriteLine(ab.ToString());
            }
            Console.ReadLine();

            //string sqlQuery = "SELECT* from ABILITAZIONE";
            //OracleSQLServer sqlServer = new OracleSQLServer();
            //List<string> results = sqlServer.ExecuteQuery(sqlQuery);

            //for (int i = 0; i < results.Count; i++)
            //{
            //    Console.WriteLine($" {i}  {results[i]}");
            //}
            //Console.ReadLine();
        }
    }
}
