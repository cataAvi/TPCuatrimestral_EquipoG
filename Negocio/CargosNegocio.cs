using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class CargosNegocio
    {

        //Listar, Agregar, Eliminar, Modificar

        public List<Cargos> listar()
        {
            List<Cargos> lista = new List<Cargos>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT C.Codigo, C.Nombre FROM Cargos AS C ");
                
                datos.ejecutarLectura();



                while (datos.Lector.Read())
                {
                    int codigoActual = (int)datos.Lector["Codigo"];
                    Cargos aux = lista.FirstOrDefault(a => a.Codigo == codigoActual);

                    if (aux == null)
                    {
                        aux = new Cargos
                        {
                            Codigo = (int)datos.Lector["Codigo"],
                            Nombre = (string)datos.Lector["Nombre"],

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

        public void altaCargoSP(Cargos nuevo)
        {
            AccesoDatos acceso = new AccesoDatos();
            try
            {


                //acceso.setearConsulta("INSERT INTO Clientes (Codigo, Nombre, Telefono, Mail) VALUES (@Codigo, @Nombre, @Telefono, @Mail)");
                acceso.setearProcedimiento("storedAltaCargo");
                acceso.setearParametro("@Codigo", nuevo.Codigo);
                acceso.setearParametro("@Nombre", nuevo.Nombre);
                

                acceso.ejecutarAccion();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                // Cerrar la conexión
                acceso.cerrarConexion();
            }
        }

        public void modificarCargoSP(Cargos modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("storedModificarCargo");
                datos.setearParametro("@Codigo", modificar.Codigo);
                datos.setearParametro("@Nombre", modificar.Nombre);
                
                datos.cerrarConexion();
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void eliminarCargoSP(int codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("storedBajaCargo");
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
