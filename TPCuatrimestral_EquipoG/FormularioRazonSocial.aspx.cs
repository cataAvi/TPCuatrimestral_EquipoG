using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio;
using Negocio;


namespace TPCuatrimestral_EquipoG
{
    public partial class FormularioRazonSocial : System.Web.UI.Page
    {
        
        List<RazonSocial> listaRazonesSociales = new List<RazonSocial>(); //lista para almacenar razones sociales.

        public bool ConfirmaEliminacion;

        public void Page_Load(object sender, EventArgs e)
        {
            ConfirmaEliminacion = false; 

            if (!IsPostBack)
            {
                CargarDropDownClientes();

                // Verificar si hay un código dentro de la URL para modo de edición
                string codigo = Request.QueryString["Codigo"];
                if (!string.IsNullOrEmpty(codigo)) //verifica si codigo no es nulo (null) y no está vacío.
                {
                    int codigoURL;

                    if (int.TryParse(codigo, out codigoURL)) //intenta convertir la cadena codigo a un entero.
                    {                                        //TryParse devuelve true si la conversión tiene éxito y false si falla.
                        CargarDatosEdicion(codigoURL);
                    }
                                                            
                    
                }
              
            }
        }

        public void CargarDropDownClientes()
        {
            ClienteNegocio clienteNegocio = new ClienteNegocio();

            // Cargar el DropDownList solo una vez al cargar la página por primera vez
            List<Cliente> listaClientes = clienteNegocio.listar();
            ddlClientes.DataSource = listaClientes;
            ddlClientes.DataTextField = "Nombre";
            ddlClientes.DataValueField = "Codigo";
            ddlClientes.DataBind();
        }

        public void CargarDatosEdicion(int codigoURL)
        {
            RazonSocialNegocio negocio = new RazonSocialNegocio();
            
            listaRazonesSociales = negocio.listarSP(); //Listamos RZ.

            RazonSocial seleccionado = listaRazonesSociales.Find(x => x.Codigo == codigoURL);

            if (seleccionado != null)
            {
                // Pre-cargar los datos seleccionados en los controles del formulario
                txtCodigo.Text = seleccionado.Codigo.ToString();
                txtNombre.Text = seleccionado.Nombre;
                txtCUIT.Text = seleccionado.CUIT;

                // Verificar si el cliente seleccionado existe en el DropDownList y seleccionarlo.
                ListItem item = ddlClientes.Items.FindByValue(seleccionado.CodigoCliente.ToString()); //busca el ítem con el valor correspondiente.
                                                                                                     //FindByValue para buscar en la colección de ítems (ListItem)
                                                                                                    //dentro del DropDownList.

                if (item != null)
                {
                    ddlClientes.SelectedValue = item.Value;
                }



            }
        }

        public void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                RazonSocial nuevo = new RazonSocial();
                RazonSocialNegocio negocio = new RazonSocialNegocio();

                // Agarro los valores del formulario y creo un nuevo objeto.
                nuevo.Codigo = int.Parse(txtCodigo.Text);
                nuevo.Nombre = txtNombre.Text;
                nuevo.CUIT = txtCUIT.Text;
                nuevo.CodigoCliente = int.Parse(ddlClientes.SelectedValue);

                if (Request.QueryString["Codigo"] != null)
                {
                    negocio.modificarRazonSocialSP(nuevo);
                }
                else
                {
                    negocio.altaRazonSocialSP(nuevo);
                }

                Response.Redirect("Mensaje.aspx", false); // Cambiar a un form que diga que el registro se agregó correctamente
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                Response.Redirect("errorPagina.aspx");
            }
        }

        public void btnEliminar_Click(object sender, EventArgs e)
        {
            ConfirmaEliminacion = true;
        }

        public void btnConfirmarEliminacion_Click(object sender, EventArgs e)
        {
            try
            {
                if (chbConfirmarEliminacion.Checked)
                {
                    RazonSocialNegocio negocio = new RazonSocialNegocio();
                    negocio.eliminarRazonSocialSP(int.Parse(txtCodigo.Text));
                    Response.Redirect("ListadoRazonSocial.aspx", false);
                }
            }
            catch (Exception ex)
            {
                Session.Add("error", ex);
                Response.Redirect("errorPagina.aspx", false);
            }
        }
    }
}