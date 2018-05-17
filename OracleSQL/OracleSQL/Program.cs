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
            using (var db = new Entities())
            {
                foreach (ABILITAZIONE ab in db.ABILITAZIONEs)
                {
                    Console.WriteLine(ab.ToString());
                }
            }

            Console.ReadLine();
            //string sqlQuery = "SELECT* from ABILITAZIONE";
            //OracleSQLServer sqlServer = new OracleSQLServer();
            //sqlServer.ExecuteQuery(sqlQuery);
        }
    }
}
