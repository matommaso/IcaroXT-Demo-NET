using OracleSQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
            string sqlQuery = "SELECT* from ABILITAZIONE";
            OracleSQLServer sqlServer = new OracleSQLServer();
            sqlServer.ExecuteQuery(sqlQuery);

            BulletedList1.DataTextField = "Sigla";
            BulletedList1.DataSource = sqlServer.ExecuteQuery(sqlQuery);
            BulletedList1.DataBind();
        }

        protected void BulletedList1_Click(object sender, BulletedListEventArgs e)
        {

        }
    }
}