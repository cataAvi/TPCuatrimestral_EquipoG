using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using dominio;



namespace Negocio
{
    public class TareasNegocio
    {
        public List<Tarea> Listar()
        {
            List<Tarea> lista = new List<Tarea>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM Tareas");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Tarea aux = new Tarea
                    {
                        Numero = (int)datos.Lector["Numero"],
                        Asunto = (string)datos.Lector["Asunto"],
                        FechaInicio = (DateTime)datos.Lector["Fecha_Inicio"],
                        FechaVencimiento = (DateTime)datos.Lector["Fecha_Vencimiento"],
                        Cierre = datos.Lector["Cierre"] != DBNull.Value ? (DateTime?)datos.Lector["Cierre"] : null,
                        Cliente = new Cliente
                        {
                            Codigo = (int)datos.Lector["Cliente"],
                            Nombre = datos.Lector["Nombre_Cliente"].ToString() // Suponiendo que este campo está en la consulta
                        },
                        AsignadoA = new Empleado
                        {
                            IDEmpleado = (int)datos.Lector["AsignadoA"],
                            Nombre = datos.Lector["Nombre_Asignado"].ToString() // Suponiendo que este campo está en la consulta
                        },
                        Incidente = new Incidente
                        {
                            Numero = (int)datos.Lector["Incidente"]
                        },
                        RazonSocial = new RazonSocial
                        {
                            Codigo = (int)datos.Lector["Razon_Social"],
                            Nombre = datos.Lector["Nombre_Razon_Social"].ToString() // Suponiendo que este campo está en la consulta
                        },
                        Tipo = new Tipo
                        {
                            Codigo = (int)datos.Lector["Tipo"],
                            Nombre = datos.Lector["Nombre_Tipo"].ToString() // Suponiendo que este campo está en la consulta
                        }
                    };

                    lista.Add(aux);
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
    }



}
