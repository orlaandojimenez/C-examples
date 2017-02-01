using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MisViajes
{
    public partial class Calculos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //double totalcosto = 0;
            //foreach (GridViewRow row in GridView1.Rows )
            //{
            //    totalcosto += Convert.ToDouble(row.Cells["precio"].Value);
            //}
        }
        
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            
        }

        protected void GridView1_DataBound(object sender, EventArgs e)
        {
            double totalcostos = 0.00;
            foreach (GridViewRow row in GridView1.Rows)
            {
                double costo = Double.Parse(row.Cells[3].Text);
                totalcostos += costo;
            }

            txtTotalCostos.Text = totalcostos.ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double costoAutobus = Convert.ToDouble(txtAutobus.Text);
            double costoHab = Convert.ToDouble(txtHab.Text);
            double costoComida = 0.00;
            if (txtComida.Text.Trim() != "")
            {
                 costoComida = Convert.ToDouble(txtComida.Text);
            }
            double noches = Convert.ToInt32(txtNoches.Text);

            double costoPersona = ((costoAutobus / 30) + ((costoHab / 2) * noches) + costoComida);

            txtPersona.Text = costoPersona.ToString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            double costoPersona = Convert.ToDouble(txtPersona.Text);
            double suma = Convert.ToDouble(txtSuma.Text);

            double cobroPersona = costoPersona + suma;

            txtCobroPersona.Text = cobroPersona.ToString();

            double ganancia = suma * (GridViewPersonas.Rows.Count);

            txtGanancia.Text = ganancia.ToString();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            txtAutobus.Text = "";
            txtHab.Text = "";
            txtNoches.Text = "";
            txtComida.Text = "";
            txtPersona.Text = "";
            txtSuma.Text = "";
            txtCobroPersona.Text = "";
            txtGanancia.Text = "";
        }
    }
}