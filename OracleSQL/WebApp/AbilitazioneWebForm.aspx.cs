using OracleSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class AbilitazioneWebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {

        }

        protected void ButtonAB_Click(object sender, EventArgs e)
        {
            string sqlQuery = "SELECT* from ABILITAZIONE";
            OracleSQLServer sqlServer = new OracleSQLServer();
            sqlServer.ExecuteQuery(sqlQuery);

            BulletedListAB.DataTextField = "Sigla";
            BulletedListAB.DataSource = sqlServer.ExecuteQuery(sqlQuery);
            BulletedListAB.DataBind();
        }
    }
}