using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.Data;

namespace MisViajes
{
    public partial class Archivos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnExaminar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Orlando/Documents/PlantillaHabitaciones.docx");
        }

        protected void btnAutobus_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Users/Orlando/Documents/PlantillaAutobus.docx");
        }
    }
}