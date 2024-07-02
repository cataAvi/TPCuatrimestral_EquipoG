using dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPCuatrimestral_EquipoG
{
    public partial class ListadoRazonSocial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarRazonesSociales();
            }
        }

        private void CargarRazonesSociales()
        {
            RazonSocialNegocio negocio = new RazonSocialNegocio();
            List<RazonSocial> lista = negocio.listarSP();
            dgvRazonesSociales.DataSource = lista;
            dgvRazonesSociales.DataBind();
        }

        protected void dgvRazonesSociales_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(dgvRazonesSociales.SelectedDataKey.Value);
            Response.Redirect("FormularioRazonSocial.aspx?Codigo=" + codigo);
        }

        protected void btnAgregarRazonSocial_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioRazonSocial.aspx");
        }
    }
}