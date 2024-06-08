using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dominio
{
    public class Tarea
    {
        public int Numero { get; set; }
        public int Asignacion { get; set; }
        public string Asunto { get; set; }
        public DateTime Cierre { get; set; }
        public Cliente Cliente { get; set;}
        public DateTime FechaInicio { get; set;}
        public DateTime FechaVencimiento { get; set;} 

        public Incidente Incidente { get; set;} 
        public RazonSocial RazonSocial { get; set;} 
        public Tipo Tipo { get; set;}






    }



}