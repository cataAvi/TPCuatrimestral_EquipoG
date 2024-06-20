using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using Negocio;

namespace TPCuatrimestral_EquipoG
{
    public partial class Cliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                dominio.Cliente nuevo = new dominio.Cliente();
                ClienteNegocio negocio = new ClienteNegocio();

                nuevo.Codigo = int.Parse(txbCodigo.Text);
                nuevo.Nombre = txbNombre.Text;
                nuevo.Telefono = txbTelefono.Text;
                nuevo.Mail = txbEmail.Text;

                negocio.altaCliente(nuevo);
                Response.Redirect("Default.aspx", false);
            }
            catch(Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }
    }
}