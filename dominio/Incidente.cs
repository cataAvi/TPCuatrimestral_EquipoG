using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dominio
{
    public class Incidente
    {
        public int Numero { get; set; }
        public int Cliente { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaRegistro  { get; set;} 
        public int RazonSocial { get; set;}
        public int SubTipo { get; set;} 
        public int Tipo { get; set;} 
        public int UsuarioRegistro { get; set;} 



    }
}