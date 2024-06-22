using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPCuatrimestral_EquipoG
{
    public partial class AltaCargo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try 
            {
              
                dominio.Cargos nuevo = new dominio.Cargos();
                CargosNegocio negocio = new CargosNegocio();

                nuevo.Codigo = int.Parse(txbCodigo.Text);
                nuevo.Nombre = txbCodigo.Text;

                negocio.altaCargoSP(nuevo);
                Response.Redirect("Default.aspx", false); // Cambiar a un Form que me diga que se cargo correctamente...



             
            
            
            } 
            catch (Exception ex) {Session.Add("error", ex); throw; }    
            
            
        }
            
            




    
    }
}