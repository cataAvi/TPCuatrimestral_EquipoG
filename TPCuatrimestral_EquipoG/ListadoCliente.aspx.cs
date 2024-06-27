using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;

namespace TPCuatrimestral_EquipoG
{
    public partial class ListadoCliente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClienteNegocio negocio = new ClienteNegocio();
            dgvClientes.DataSource = negocio.listar();
            dgvClientes.DataBind();

        }

        protected void dgvClientes_SelectedIndexChaged(object sender, EventArgs e)
        {

            var Codigo = dgvClientes.SelectedDataKey.Value.ToString();
            Response.Redirect("FormularioCliente.aspx?Codigo=" + Codigo);

        }

        public void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioCliente.aspx");
        }
    }
}