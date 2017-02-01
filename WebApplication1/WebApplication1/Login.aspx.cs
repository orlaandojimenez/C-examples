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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button_Login_Click1(object sender, EventArgs e)
        {
            string user = this.TextBox_User.Text;
            string pass = this.TextBox_pass.Text;
            SqlParameter paramUser = new SqlParameter("@user", user);

            DataSet dataset = SQLManager.EjecutarQueryConSP("sp_getOrders_Hazael",paramUser);
            string userDB = dataset.Tables[0].Rows[0][2].ToString(); //FirstName
            string passDB = dataset.Tables[0].Rows[0][1].ToString(); //LastName
           

            if (user == userDB && pass == passDB)
            {
                this.Label_Result.Text= "Login Succesfull";
                Server.Transfer("home.aspx");
            }
            else{
                this.Label_Result.Text="Login Denied";
            }


        }
    }
}