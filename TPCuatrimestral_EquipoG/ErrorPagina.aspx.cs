using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPCuatrimestral_EquipoG
{
    public partial class ErrorPagina : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["error"]!= null)// verificamos primero si hay un oobjeto de errror en la sesion.
            {
                Exception ex =(Exception)Session["error"]; // recupero la excepcion desde la sesion.

                lblErrorMessage.Text = "Error: " + ex.Message; //Muestro el msj de error.

                Session.Remove("error"); //Limpio la sesion para que el error no siga.



            }




        }
    }
}