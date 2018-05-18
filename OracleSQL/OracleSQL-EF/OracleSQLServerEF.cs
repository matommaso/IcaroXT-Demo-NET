using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleSQL
{
    public class OracleSQLServerEF
    {
        public List<ABILITAZIONE> GetABILITAZIONEs()
        {
            List<ABILITAZIONE> abilitaziones = new List<ABILITAZIONE>();

            using (var db = new Entities())
            {
                foreach (ABILITAZIONE ab in db.ABILITAZIONEs)
                {
                    abilitaziones.Add(ab);
                }
            }
            return abilitaziones;
        }
    }
}
