using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dominio
{
    public class Incidente
    {
        public int Numero { get; set; }
        public int IDCliente { get; set; }
        public string Detalle { get; set; }
        public DateTime FechaRegistro  { get; set;} 
        public int IDRazonSocial { get; set;}
        public int IDSubTipo { get; set;} 
        public int IDTipo { get; set;} 
        public int IDUsuarioRegistro { get; set;} 



    }
}