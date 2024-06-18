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
        public List<Incidente>listar()
        {
            //Inicializa una lista vacia de objeto.
            List<Incidente> lista = new List<Incidente>(); 
            //Crea una instancia para manejar la conexion a base de datos.
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT * FROM Incidentes");
                datos.ejecutarLectura();
               
                while (datos.Lector.Read())
                {
                    int nroActual = (int)datos.Lector["Numero"]; //Obtenemos el valor de la fila actual.
                    Incidente aux = lista.FirstOrDefault(a => a.Numero == nroActual); //Busca en la lista si ya existe un incidente con ese codigo.
                    //si no existe, crea un nuevo objeto incidente y lo agrega a la lista.
                    if (aux != null) {

                        aux = new Incidente //Crea una nueva instancia de incidente y le asigna los valores de la fila actual.
                        {

                            Numero = (int)datos.Lector["Codigo"],
                            IDCliente = (int)datos.Lector["Cliente"],
                            Detalle = (string)datos.Lector["Telefono"],
                            FechaRegistro = (DateTime)datos.Lector["Fecha_Registro"],
                            IDRazonSocial = (int)datos.Lector["Razon_Social"],
                            IDSubTipo = (int)datos.Lector["SubTipo"],
                            IDTipo = (int)datos.Lector["Tipo"],
                            IDUsuarioRegistro = (int)datos.Lector["Usuario_Registro"]


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





            
        }//Fin de funcion listar();
        
    
        
    
    
    
    }



}
