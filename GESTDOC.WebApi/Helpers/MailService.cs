using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace GESTDOC.WebApi.Helpers
{
    public class MailService
    {
        IConfiguration configuration;

        public MailService(IConfiguration configuration_)
        {
            configuration = configuration_;
        }


        /// <summary>
        /// Envia un mensaje a uno o varios correos
        /// </summary>
        /// <param name="Receptor">Correos (puede ir separador por ;)</param>
        /// <param name="asunto"></param>
        /// <param name="mensaje"></param>
        /// <returns></returns>
        public bool Enviar_Correo(string Receptor, string asunto, string mensaje)
        {
            try
            {
                // --- Obteniendo lista de correos
                string[] liCorreos = Receptor.Split(";");                

                MailMessage mail = new MailMessage();
                string userName = configuration["Mail_userName"];
                string password = configuration["Mail_password"];
                string Host = configuration["Mail_Host"];
                int port = Convert.ToInt32(configuration["Mail_port"]);
                bool enableSsl = Convert.ToBoolean(configuration["Mail_enableSsl"]);
                bool defaultCredentials = Convert.ToBoolean(configuration["Mail_defaultCredentials"]);

                mail.From = new MailAddress(userName);

                // --- Agregando lista de receptores de correo
                foreach (string correo in liCorreos)
                {
                    mail.To.Add(new MailAddress(correo));
                }
                
                mail.Subject = asunto;
                mail.Body = mensaje;
                mail.IsBodyHtml = true;

                SmtpClient smtpclient = new SmtpClient();
                smtpclient.Host = Host;
                smtpclient.Port = port;
                smtpclient.EnableSsl = enableSsl;
                smtpclient.UseDefaultCredentials = defaultCredentials;

                NetworkCredential userCredential = new NetworkCredential(userName, password);

                smtpclient.Credentials = userCredential;

                // --- Enviando correo
                smtpclient.Send(mail);
                return true;
            }
            catch(Exception ex)
            {
                LibreriaBSNetCore.Exceptions.Logger.Fatal(ex);
                return false;
            }
        }

    }
}
