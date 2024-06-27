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
    public partial class FormularioCliente : System.Web.UI.Page
    {
        public bool ConfirmaEliminacion {  get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {
            ConfirmaEliminacion = false;

            ClienteNegocio negocio = new ClienteNegocio();

            if (Request.QueryString["Codigo"] != null && !IsPostBack)
            {
                int id = int.Parse(Request.QueryString["Codigo"].ToString());
                List<Cliente> lista = negocio.listar();
                Cliente seleccionado = lista.Find(x => x.Codigo == id);
                txbCodigo.ReadOnly = true;
                txbCodigo.Text = seleccionado.Codigo.ToString();
                txbNombre.Text = seleccionado.Nombre.ToString();
                txbEmail.Text = seleccionado.Mail.ToString();
                txbTelefono.Text = seleccionado.Telefono.ToString();

            }



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

                if (Request.QueryString["Codigo"] != null)
                {
                    negocio.modificarCliente(nuevo);
                }
                else
                {
                    negocio.altaCliente(nuevo);
                }
                



                Response.Redirect("ListadoCliente.aspx", false); //Cambiar a un form que diga que el registro se agregó correctamente
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                throw;
            }
        }


        public void btnBorrar_Click (object sender, EventArgs e)
        {
            ConfirmaEliminacion = true;
        }

        public void btnConfirmaEliminacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbConfirmarEliminacion.Checked)
                {
                    ClienteNegocio negocio = new ClienteNegocio();
                    negocio.eliminarCliente(int.Parse(txbCodigo.Text));
                    Response.Redirect("ListadoCliente.aspx");
                }
                
            }
            catch (Exception ex)
            {
                Session.Add ("error", ex);
            }
            

        }

        public void btnBuscar_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListadoCliente.aspx");
        }


    }
}