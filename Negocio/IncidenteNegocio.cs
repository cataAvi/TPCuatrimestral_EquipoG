using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;


namespace Negocio
{
    public class IncidenteNegocio
    {
        public List<Incidente>listarSP()
        {
           
          
            List<Incidente> lista = new List<Incidente>(); 
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("storedListarIncidentes");
                datos.ejecutarLectura();
               
                while (datos.Lector.Read())
                {
                    int nroActual = (int)datos.Lector["Numero"]; //Obtenemos el valor de la fila actual.
                    Incidente aux = lista.FirstOrDefault(a => a.Numero == nroActual); //Busca en la lista si ya existe un incidente con ese codigo.
                    //si no existe, crea un nuevo objeto incidente y lo agrega a la lista.
                    //Se pregunta para evitar duplicados.
                    if (aux != null) {

                        aux = new Incidente //Crea una nueva instancia de incidente y le asigna los valores de la fila actual.
                        {

                            Numero = (int)datos.Lector["Numero"],
                            UsuarioRegistro = (int)datos.Lector["Usuario_Registro"],
                            FechaRegistro = (DateTime)datos.Lector["Fecha_Registro"],
                            Cliente = (int)datos.Lector["Cliente"],
                            RazonSocial = (int)datos.Lector["Razon_Social"],
                            Tipo = (int)datos.Lector["Tipo"],
                            SubTipo = (int)datos.Lector["SubTipo"],
                            Detalle = (string)datos.Lector["Detalle"],
                        };


                        lista.Add(aux); 

                    }

                }

              return lista;
                    
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {


                datos.cerrarConexion();
            }

        }

        public void altaIncidenteSP(Incidente nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("storedAltaIncidente");
                datos.setearParametro("@Numero", nuevo.Numero);
                datos.setearParametro("@Usuario_Registro", nuevo.UsuarioRegistro);
                datos.setearParametro("@Fecha_Registro", nuevo.FechaRegistro);
                datos.setearParametro("@Cliente", nuevo.Cliente);
                datos.setearParametro("@Razon_Social", nuevo.RazonSocial);
                datos.setearParametro("@Tipo", nuevo.Tipo);
                datos.setearParametro("@SubTipo", nuevo.SubTipo);
                datos.setearParametro("@Detalle", nuevo.Detalle);



                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                // Cerrar la conexión
                datos.cerrarConexion();
            }


        }


        public void modificarIncidenteSP(Incidente modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.setearProcedimiento("storedModificarIncidente");
                datos.setearParametro("@Numero", modificar.Numero);
                datos.setearParametro("@Usuario_Registro", modificar.UsuarioRegistro);
                datos.setearParametro("@Fecha_Registro", modificar.FechaRegistro);
                datos.setearParametro("@Cliente", modificar.Cliente);
                datos.setearParametro("@Razon_Social", modificar.RazonSocial);
                datos.setearParametro("@Tipo", modificar.Tipo);
                datos.setearParametro("@SubTipo", modificar.SubTipo);
                datos.setearParametro("@Detalle", modificar.Detalle);


                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                // Cerrar la conexión
                datos.cerrarConexion();
            }




        }

        public void bajaIncidenteSP(int numero)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("storedBajaIncidente");
                datos.setearParametro("@Numero", numero);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }




    }



}
