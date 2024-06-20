using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace dominio
{

    // enum me define los tipos de usuarios disponibles...
    public enum TipoUsuario
    {    // Segun  nuestro enunciado tendriamos:
        // Administrador, Telefonista y Supervisor
        Administrador = 1,
        Telefonista = 2,
        Supervisor = 3
    }


    public class Usuario
    {
        //Atributos de mi usuario.
        public int ID { get; set; }

        public string User { get; set; }
        public string Pass { get; set; }

        public TipoUsuario TipoUsuario { get; set; }

        public Usuario(string user, string pass, TipoUsuario tipousuario)
        {
            User = user;
            Pass = pass;
            TipoUsuario = tipousuario; 
            
        }



      
        


     

    }

  }









