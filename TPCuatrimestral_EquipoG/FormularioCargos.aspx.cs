using dominio;
using Negocio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPCuatrimestral_EquipoG
{
    public partial class FormularioCargos : System.Web.UI.Page
    {
        public bool ConfirmaEliminacion { get; set; }
        List<Cargos> lista = new List<Cargos>();

        protected void Page_Load(object sender, EventArgs e)
        {

            ConfirmaEliminacion = false;

            CargosNegocio negocio = new CargosNegocio();// para obtener la lista de cargos.

            //Verificamos si hay un codigo dentro de la url y si no es una devolucion de datos.
            //si existe el codigo, estamos en modo de edicion.
            if (Request.QueryString["Codigo"] != null && !IsPostBack)
            {
                int id = int.Parse(Request.QueryString["Codigo"].ToString());
                lista = negocio.listar();
                Cargos seleccionado = lista.Find(x => x.Codigo == id);

                // Pre-carga de los datos del cargo seleccionado en los controles del formulario
                txbCodigo.ReadOnly = true;
                txbCodigo.Text = seleccionado.Codigo.ToString();
                txbNombre.Text = seleccionado.Nombre.ToString();
                
            }




        }

        //Graabando el registro.
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                dominio.Cargos nuevo = new dominio.Cargos();
                CargosNegocio negocio = new CargosNegocio();

                //Agarro los valores del formulario y creo un nuevo objeto.
                nuevo.Codigo = int.Parse(txbCodigo.Text);
                nuevo.Nombre = txbNombre.Text;
                

                if(Request.QueryString["Codigo"] != null)
                {
                    negocio.modificarCargoSP(nuevo);
                }
                else
                {
                    negocio.altaCargoSP(nuevo);
                }

               Response.Redirect("Mensaje.aspx", false); //Cambiar a un form que diga que el registro se agregó correctamente
            }



            catch (Exception ex)
            {
                Session.Add("error", ex);
                Response.Redirect("ErrorPagina.aspx");
            }


        }


        //BORRANDO EL REGISTRO;
        protected void btnBorrar_Click(object sender, EventArgs e)
        {

            ConfirmaEliminacion = true;
        }

        protected void btnConfirmarEliminacion_Click(object sender, EventArgs e)
        {
            try
            {

                if (chbConfirmarEliminacion.Checked)
                {
                    CargosNegocio negocio = new CargosNegocio();
                    negocio.eliminarCargoSP(int.Parse(txbCodigo.Text));
                    Response.Redirect("ListadoCargos.aspx");
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