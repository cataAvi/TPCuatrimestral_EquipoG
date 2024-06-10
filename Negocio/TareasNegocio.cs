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
      
      public List<Tarea> listar()
      {

            List<Tarea> lista = new List<Tarea>();  
            AccesoDatos datos = new AccesoDatos();  

            try
            {
                datos.setearConsulta("SELECT * FROM Tareas");
                datos.ejecutarLectura();
                
                
                while (datos.Lector.Read())
                {
                    int nroActual = (int)datos.Lector["Numero"];
                    Tarea aux = lista.FirstOrDefault(a => a.Numero == nroActual);

                    if (aux == null)
                    {
                        aux = new Tarea
                        {

                            Numero = (int)datos.Lector["Numero"],
                            Asignacion = (int)datos.Lector["Asignacion"],
                            Asunto = (string)datos.Lector["Asunto"],
                            Cierre = (DateTime)datos.Lector["Cierre"],
                            FechaInicio = (DateTime)datos.Lector["FechaInicio"],
                            FechaVencimiento = (DateTime)datos.Lector["FechaVencimiento"],
                            
                            
                            Cliente = new Cliente
                            {
                                Codigo = (int)datos.Lector["Codigo"],
                                Nombre = (string)datos.Lector["Nombre"],
                                Telefono = (string)datos.Lector["Telefono"],
                                Mail = (string)datos.Lector["Mail"]
                            },


                            Incidente = new Incidente
                            {
                                Numero = (int)datos.Lector["Codigo"],
                                Cliente = (int)datos.Lector["Cliente"],
                                Detalle = (string)datos.Lector["Telefono"],
                                FechaRegistro = (DateTime)datos.Lector["Fecha_Registro"],
                                RazonSocial = (int)datos.Lector["Razon_Social"],
                                SubTipo = (int)datos.Lector["SubTipo"],
                                Tipo = (int)datos.Lector["Tipo"],
                                UsuarioRegistro = (int)datos.Lector["Usuario_Registro"]
                            }
                           /* RazonSocial = new RazonSocial
                            {
                               
                            },*/
                           /* Tipo = new Tipo
                            {
                                ID = (int)datos.Lector["TipoID"],
                                Descripcion = (string)datos.Lector["TipoDescripcion"]
                            }*/

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
            finally {

                datos.cerrarConexion();
            
            }






       }
    
    
    
    
    
    
    }




}
