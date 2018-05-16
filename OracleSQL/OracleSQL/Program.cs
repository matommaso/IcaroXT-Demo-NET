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
                    Console.Write(ab.SIGLA +" ");
                    Console.Write(ab.MATR_UTENTE + " ");
                    Console.Write(ab.DATA_INS + " ");
                    Console.Write(ab.DATA_VAR + " ");
                    Console.Write(ab.RICH_EQUIP_CONDOTTA + " ");
                    Console.Write(ab.RICH_EQUIP_CABINA + " ");
                    Console.WriteLine();
                }
            }

            Console.ReadLine();
            //string sqlQuery = "SELECT* from ABILITAZIONE";
            //OracleSQLServer sqlServer = new OracleSQLServer();
            //sqlServer.ExecuteQuery(sqlQuery);
        }
    }
}
