using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EmpleadoNegocio
    {

        public List<Empleado> listar()
        {
            List<Empleado> lista = new List<Empleado>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM Empleados");
                datos.ejecutarLectura();



                while (datos.Lector.Read())
                {
                    int codigoActual = (int)datos.Lector["ID_Empleado"];
                    Empleado aux = lista.FirstOrDefault(a => a.IDEmpleado == codigoActual);

                    if (aux == null)
                    {
                        aux = new Empleado
                        {

                            IDEmpleado = (int)datos.Lector["ID_Empkeado"],
                            Nombre = (string)datos.Lector["Nombre"],
                            Apellido = (string)datos.Lector["Apellido"],
                            Mail = (string)datos.Lector["Mail"],
                            Usuario = (string)datos.Lector["Usuario"],
                            Contrasena = (string)datos.Lector["Contraseña"],
                            Puesto = (int)datos.Lector["Puesto"]


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

        public void agregar(Empleado nuevo)
        {
            AccesoDatos acceso = new AccesoDatos();
            try
            {

                acceso.setearConsulta("INSERT INTO Empleados (ID_Empleado, Apellido, Nombre, Usuario, Mail, Contraseña, Puesto) VALUES (@IDEmpleado, @Apellido, @Nombre, @Usuario, @Mail, @Contraseña, @Puesto)");

                acceso.setearParametro("@IDEmpleado", nuevo.IDEmpleado);
                acceso.setearParametro("@Apellido", nuevo.Apellido);
                acceso.setearParametro("@Nombre", nuevo.Nombre);
                acceso.setearParametro("@Usuario", nuevo.Usuario);
                acceso.setearParametro("@Mail", nuevo.Mail);
                acceso.setearParametro("@Contraseña", nuevo.Contrasena);
                acceso.setearParametro("@Puesto", nuevo.Puesto);

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

        public void eliminarEmpleado(int IDEmpleado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM Empleados WHERE ID_Empleado = @IDEmpleado");
                datos.setearParametro("@IDEmpleado", IDEmpleado);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally { datos.cerrarConexion(); }
        }


        public void modificar(Empleado modificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("UPDATE Empleados SET ID_Empleado = @ID_Empleado, Apellido = @Apellido, Nombre = @Nombre, Usuario = @Usuario, Mail = @Mail, Contraseña = @Contraseña, Puesto = @Puesto WHERE ID_Empleado = @ID_Empleado");
                datos.setearParametro("@ID_Empleado", modificar.IDEmpleado);
                datos.setearParametro("@Apellido", modificar.Apellido);
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@Usuario", modificar.Usuario);
                datos.setearParametro("@Mail", modificar.Mail);
                datos.setearParametro("@Contraseña", modificar.Contrasena);
                datos.setearParametro("@Puesto", modificar.Puesto);
                datos.cerrarConexion();
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
