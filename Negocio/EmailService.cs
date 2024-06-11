using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class EmailService
    {
        private MailMessage email; // a quien se lo envio, cuerpo, asunto, etc
        private SmtpClient server; // servidor con el cual envio el email;

        public EmailService()
        {
            server = new SmtpClient(); //declarar la instacia del servidor cuando la crea y lo configuro
            server.Credentials = new NetworkCredential("c8c678d6eab9de", "********f726"); // le doy las credenciales.
            server.EnableSsl = true;
            server.Port = 2525;
            server.Host = "smpt.mailtrap.io";
            //estos son los datos que debemos conocer, depende del server que usemos, en
            ///este caso es (Gmail).
        }

        public void armarCorreo(string emailDestino, string asunto, string cuerpo)
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponder@ecommerceporgramacionii.com");
            email.To.Add(emailDestino);
            email.Subject = asunto;
            email.IsBodyHtml = true;
            email.Body = "<h1>Reporte de materias a las que se ha inscripto</h1>";
            //email.Body= cuerpo;
        }


        public void enviarEmail()
        {
            try
            {
                server.Send(email);
     
                    
             }


            catch (Exception ex)
            {
                throw ex;
            }

        }


    }







}
