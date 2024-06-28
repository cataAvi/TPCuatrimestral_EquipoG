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
    public partial class ListadoCargos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CargosNegocio negocio = new CargosNegocio();
            dgvCargos.DataSource = negocio.listar();
            dgvCargos.DataBind();
        }

        protected void dgvCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Codigo = dgvCargos.SelectedDataKey.Value.ToString(); //Obtenngo el valor, y lo covierto en cadena para poder
                                                                     //usarlo como parametro en una URL.
            Response.Redirect("FormularioCargos.aspx?Codigo=" + Codigo);

        }

        protected void btnAgregarCargo_Click(object sender, EventArgs e)
        {
            Response.Redirect("FormularioCargos.aspx");
        }

      
    }
}