using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MisViajes
{
    public partial class Costos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButton lbInsert = new LinkButton();
            lbInsert.Click += new EventHandler(lbInsert_Click);
        }

        protected void lbInsert_Click(object sender, EventArgs e)
        {
            SqlDataSourceCostos.InsertParameters["idviaje"].DefaultValue = ((DropDownList)GridViewCostos.FooterRow.FindControl("DplViaje")).SelectedValue;
            SqlDataSourceCostos.InsertParameters["nombre"].DefaultValue = ((TextBox)GridViewCostos.FooterRow.FindControl("TextBoxNombre")).Text;
            SqlDataSourceCostos.InsertParameters["precio"].DefaultValue = ((TextBox)GridViewCostos.FooterRow.FindControl("TextBoxPrecio")).Text;
            SqlDataSourceCostos.Insert();
        }
    }
}