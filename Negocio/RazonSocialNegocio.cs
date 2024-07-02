using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace Negocio
{
    public class RazonSocialNegocio
    {

        public List<RazonSocial> listarSP()
        {
            AccesoDatos datos = new AccesoDatos();
            List<RazonSocial> lista = new List<RazonSocial>();

            try
            {
                datos.setearProcedimiento("storedListarRazonSocial");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    int codigoActual = (int)datos.Lector["Codigo"];
                    RazonSocial aux = lista.FirstOrDefault(a => a.Codigo == codigoActual);
                    if (aux == null)
                    {
                        aux = new RazonSocial
                        {
                            Codigo = (int)datos.Lector["Codigo"],
                            Nombre = (string)datos.Lector["Nombre"],
                            CUIT = (string)datos.Lector["CUIT"],
                            CodigoCliente = (int)datos.Lector["Cliente"]

                        };
                        
                        lista.Add(aux);

                    }



                }
                return lista;


            }
            catch (InvalidCastException ex)
            {

                // Log the details of the InvalidCastException
                System.Diagnostics.Debug.WriteLine("InvalidCastException: " + ex.Message);
                throw ex;
            }
            catch (Exception ex)
            {
                // Log general exceptions
                System.Diagnostics.Debug.WriteLine("General Error: " + ex.Message);
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }



        }

        public void altaRazonSocialSP(RazonSocial nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("storedAltaRazonSocial");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@CUIT", nuevo.CUIT);
                datos.setearParametro("@Cliente", nuevo.CodigoCliente);




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

        public void modificarRazonSocialSP(RazonSocial modificar)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("storedModificarRazonSocial");
                datos.setearParametro("@Codigo", modificar.Codigo);
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@CUIT",   modificar.CUIT);
                datos.setearParametro("@Cliente",modificar.CodigoCliente);

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


        public void eliminarRazonSocialSP(int codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("storedBajaRazonSocial");
                datos.setearParametro("@Codigo", codigo);
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
