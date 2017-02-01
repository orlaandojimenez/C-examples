using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MisViajes
{
    public partial class Organiza : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButton lbInsert = new LinkButton();
            lbInsert.Click += new EventHandler(lbInsert_Click);
        }

        protected void lbInsert_Click(object sender, EventArgs e)
        {
            SqlDataSourceOrganiza.InsertParameters["idviaje"].DefaultValue = ((DropDownList)GridViewOrganiza.FooterRow.FindControl("DropDownListInsertViaje")).SelectedValue;
            SqlDataSourceOrganiza.InsertParameters["idpersona"].DefaultValue = ((DropDownList)GridViewOrganiza.FooterRow.FindControl("DropDownListInsertPersona")).SelectedValue;
            SqlDataSourceOrganiza.InsertParameters["pagado"].DefaultValue = ((TextBox)GridViewOrganiza.FooterRow.FindControl("TextBoxPagado")).Text;
            SqlDataSourceOrganiza.Insert();
        }
    }
}