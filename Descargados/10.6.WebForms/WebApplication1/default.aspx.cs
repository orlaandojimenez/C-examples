using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void button_Hello_Click(object sender, EventArgs e)
        {//Ejecuta el StoredProcedure
            string customerID = this.TextBox1.Text;
            if(customerID != "")
            {
                SqlParameter parameter1 = new SqlParameter("@customerID",customerID);
                DataSet dataSet = SQLManager.EjecutarQueryConSP("sp_getOrderByCustomerID", parameter1);
                if(dataSet != null)
                {
                    this.GridView_Hello.DataSource = dataSet;
                    this.GridView_Hello.DataBind();
                }
                else
                {//El DataSet es nulo, ocurrio algun error
                    Type cstype = this.GetType();//Obtiene la pagina
                    string key = "alertScript";//Da un ID a tu script
                    string script = "<script type=\"text/javascript\">";
                    script += "alert('Error consultando la base de datos');";
                    script += "</script>";
                    ClientScript.RegisterStartupScript(cstype, key, script);
                }
            }
        }
    }
}