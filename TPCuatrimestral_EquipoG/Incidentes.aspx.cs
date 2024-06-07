using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPCuatrimestral_EquipoG
{
    public partial class Incidentes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                

                ddlPrioridad.Items.Add("Alta");
                ddlPrioridad.Items.Add("Media");
                ddlPrioridad.Items.Add("Baja");


            }









        }
    }
}