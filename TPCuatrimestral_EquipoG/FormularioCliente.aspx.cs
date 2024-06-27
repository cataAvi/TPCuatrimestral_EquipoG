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
        List<Cliente> lista = new List<Cliente>();
        int posicion;
        int LargoLista;

        protected void Page_Load(object sender, EventArgs e)
        {
            ConfirmaEliminacion = false;

            ClienteNegocio negocio = new ClienteNegocio();
            Cliente cliente = new Cliente();    
            

            if (Request.QueryString["Codigo"] != null && !IsPostBack)
            {
                int id = int.Parse(Request.QueryString["Codigo"].ToString());
                lista = negocio.listar();
                Cliente seleccionado = lista.Find(x => x.Codigo == id);

                posicion = lista.IndexOf(seleccionado);   //Varibles para hacer funcionar el botón de siguiente y anterior del formulario para navegar
                LargoLista = lista.Count;   
                
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
                



                Response.Redirect("Mensaje.aspx", false); //Cambiar a un form que diga que el registro se agregó correctamente
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

        public void btnAnterior_Click(object sender, EventArgs e)
        {
            if (posicion > 1 && posicion <= LargoLista)
            {
                Cliente anterior = lista[posicion - 1];
                Response.Redirect("FormularioCliente.aspx?Codigo=" + anterior.Codigo);
            }
            
        }

        public void btnSiguiente_Click(object sender, EventArgs e)
        {

            if (posicion >= 0  && posicion < LargoLista) //Consultar por qué llega en 0 los valores
            {
                Cliente siguiente = lista[posicion + 1];
                Response.Redirect("FormularioCliente.aspx?Codigo=" + siguiente.Codigo);
            }
                
        }


    }
}