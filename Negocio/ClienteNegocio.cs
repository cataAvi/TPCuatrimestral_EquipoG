using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient; //(0) Agrego esto para la conexion.

namespace Negocio
{
    internal class ClienteNegocio
    {
        
        
        
        //Listar, Agregar, Eliminar.
        
        public List<Cliente> listar()
        {
            List<Cliente> lista = new List<Cliente>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT C.Codigo, C.Nombre, C.Telefono, C.Mail FROM Clientes AS C");
                datos.ejecutarLectura();



                while (datos.Lector.Read())
                {
                    int codigoActual = (int)datos.Lector["Codigo"];
                    Cliente aux = lista.FirstOrDefault(a => a.Codigo == codigoActual);

                    if (aux == null)
                    {
                        aux = new Cliente
                        {
                            
                            Codigo = (int)datos.Lector["Codigo"],
                            Nombre = (string)datos.Lector["Nombre"],
                            Telefono = (string)datos.Lector["Telefono"],
                            Mail = (string)datos.Lector["Mail"]
                            

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

        public void agregar(Cliente nuevo)
        {
            AccesoDatos acceso = new AccesoDatos();
            try
            {

                acceso.setearConsulta("INSERT INTO Clientes (Codigo, Nombre, Telefono, Mail) VALUES (@Codigo, @Nombre, @Telefono, @Mail)");

                acceso.setearParametro("@Codigo", nuevo.Codigo);
                acceso.setearParametro("@Nombre", nuevo.Nombre);
                acceso.setearParametro("@Telefono", nuevo.Telefono);
                acceso.setearParametro("@Mail", nuevo.Mail);


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

        public void eliminarArticulo(int codigo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM Articulos WHERE Codigo = @Codigo");
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
