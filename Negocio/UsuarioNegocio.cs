using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class UsuarioNegocio
    {
        // Método para autenticar a un usuario
        public bool Loguear(Usuario usuario)
        {
            // Instancia de la clase AccesoDatos para manejar la conexión y las consultas a la base de datos
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Establece la consulta SQL para verificar el usuario y la contraseña
                datos.setearConsulta("SELECT Id, TipoUser FROM USUARIOS WHERE usuario = @user AND pass = @pass");

                // Agrega los parámetros a la consulta para prevenir inyecciones SQL
                datos.setearParametro("@user", usuario.User);
                datos.setearParametro("@pass", usuario.Pass);

                // Ejecuta la consulta
                datos.ejecutarLectura();

                // Itera sobre los resultados de la consulta
                while (datos.Lector.Read())
                {
                    // Asigna el valor del campo "Id" de la base de datos a la propiedad "Id" del usuario
                    usuario.ID = (int)datos.Lector["Id"];

                    // Asigna el tipo de usuario basado en el valor del campo "TipoUser"
                    // Si "TipoUser" es 2, el tipo de usuario es ADMIN, de lo contrario es NORMAL
                    int tipoUser = (int)datos.Lector["TipoUser"];
                    switch (tipoUser) {
                        case 0:
                            usuario.TipoUsuario = TipoUsuario.Administrador;
                            break;
                        case 1:
                            usuario.TipoUsuario = TipoUsuario.Telefonista;
                            break;
                        case 2:
                            usuario.TipoUsuario = TipoUsuario.Supervisor;
                            break;
                        default:
                            throw new Exception("Tipo de usuario no reconocido");



                    }


                    return true;
                }

                // Si no se encuentra ningún registro, retorna false
                return false;
            }
            catch (Exception ex)
            {
                // Lanza cualquier excepción que ocurra durante la ejecución
                throw ex;
            }
            finally
            {
                // Cierra la conexión a la base de datos
                datos.cerrarConexion();
            }
        } // Fin del método Loguear
    } // Fin de la clase UsuarioNegocio
}
