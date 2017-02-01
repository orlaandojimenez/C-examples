using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MisViajes
{
    public partial class CatalogoPersonas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButton lbInsert = new LinkButton();
            lbInsert.Click += new EventHandler(lbInsert_Click);
        }

        protected void lbInsert_Click(object sender, EventArgs e)
        {
            SqlDataSourcePersonas.InsertParameters["nombre"].DefaultValue = ((TextBox)GridViewPersonas.FooterRow.FindControl("TextBoxNombre")).Text;
            SqlDataSourcePersonas.InsertParameters["telefono"].DefaultValue = ((TextBox)GridViewPersonas.FooterRow.FindControl("TextBoxTelefono")).Text;
            SqlDataSourcePersonas.Insert();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}