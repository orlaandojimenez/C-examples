using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MisViajes
{
    public partial class CatalogoViajes : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            LinkButton lbInsert = new LinkButton();
            lbInsert.Click += new EventHandler(lbInsert_Click);
        }

        protected void lbInsert_Click(object sender, EventArgs e)
        {
            SqlDataSourceViajes.InsertParameters["destino"].DefaultValue = ((TextBox)GridViewViajes.FooterRow.FindControl("TextBoxDestino")).Text;
            SqlDataSourceViajes.InsertParameters["fecha_salida"].DefaultValue = ((TextBox)GridViewViajes.FooterRow.FindControl("TextBoxFechaSalida")).Text;
            SqlDataSourceViajes.InsertParameters["fecha_regreso"].DefaultValue = ((TextBox)GridViewViajes.FooterRow.FindControl("TextBoxFechaRegreso")).Text;
            SqlDataSourceViajes.InsertParameters["hotel"].DefaultValue = ((TextBox)GridViewViajes.FooterRow.FindControl("TextBoxHotel")).Text;
            SqlDataSourceViajes.Insert();
        }

        //protected void btnAgregar_Click(object sender, EventArgs e)
        //{
        //    if (string.IsNullOrEmpty(TxtFechaSalida.Text) || string.IsNullOrEmpty(txtFechaRegreso.Text) || string.IsNullOrEmpty(txtDestino.Text) || string.IsNullOrEmpty(txtHotel.Text))
        //        {
        //            Response.Write("<script>alert('Faltan campos por agregar')</script>");
        //            //lblEstado.Text = "Faltan campos por llenar";
        //        }
        //     else
        //        {
        //            try 
        //                {	        
		                    
        //                    //se crea instancia de la clase
        //                    clsViaje viaje = new clsViaje("", "", "", "");
        //                    //se indica cada texbox con su valor
        //                    viaje.Fecha_Salida = TxtFechaSalida.Text;
        //                    viaje.Fecha_Regreso = txtFechaRegreso.Text;
        //                    viaje.Destino = txtDestino.Text;
        //                    viaje.Hotel = txtHotel.Text;
        //                    viaje.Agregar();//se agrega el registro
        //                    Response.Write("<script>alert('Registro agregado con exito')</script>");

        //                    //Se limpian los textbox
        //                    TxtFechaSalida.Text = "";
        //                    txtFechaRegreso.Text = "";
        //                    txtDestino.Text = "";
        //                    txtHotel.Text = "";
        //                }
        //                catch (Exception)
        //                {
        //                    Response.Write("<script>alert('Se ha generado una excepcion')</script>");
        //                }
        //        }
            
        //}
    }
}