using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Text.RegularExpressions;


namespace TestPerLog
{
    public static class HelperEmail
    {

        public static bool InviaEmailConTemplate(string pathTemplate, string subject, Dictionary<string, string> placeholders)
        {
            string templateValorizzato = getTemplateValorizzato(pathTemplate, placeholders);
            if (templateValorizzato != string.Empty)
                return InviaEmail(subject, templateValorizzato);
            return false;
        }

        public static string CreaStringaRicambi(List<string> lista)
        {
            string ricambi = lista.Count > 1 ? "lista ricambi : <br>" : "ricambio ";
            ricambi += string.Join(",<br>", lista);

            return ricambi;
        }

        public static bool InviaEmail(string subject, string templateValorizzato)
        {
            var MessaggioDaInviare = new MimeMessage();
            MessaggioDaInviare.From.Add(new MailboxAddress("Linaus-Notifiche", ConfigurationManager.AppSettings["Mail_From"]));
            MessaggioDaInviare.To.Add(new MailboxAddress("ProvaDestinatario", ConfigurationManager.AppSettings["Mail_To"]));
            MessaggioDaInviare.Subject = subject;
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.HtmlBody = templateValorizzato;
            MessaggioDaInviare.Body = bodyBuilder.ToMessageBody();

            string host = ConfigurationManager.AppSettings["Mail_Host"];
            string porta = ConfigurationManager.AppSettings["Mail_Porta"];
            string username = ConfigurationManager.AppSettings["Mail_Username"];
            string password = ConfigurationManager.AppSettings["Mail_Password"];

            //TODO leggere da appconfig enum tipo protocollo sicurezza (es ssl, ..)

            bool inviato = false;
            var client = new SmtpClient();
            try
            {
                client.Connect(host, int.Parse(porta));
                client.Authenticate(username, password);
                client.Send(MessaggioDaInviare);
                client.Disconnect(true);
                inviato = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore durante la connessione : " + ex.Message);
            }
            return inviato;
        }

        private static string getTemplateValorizzato(string filePath, Dictionary<string, string> placeholders)
        {
            string templateValorizzato = string.Empty;
            string template = string.Empty;
            string pattern = @"\[(.*?)\]";
            Regex regex = new Regex(pattern);


            if (!File.Exists(filePath))
                return string.Empty;


            using (StreamReader sr = new StreamReader(filePath))
            {
                template = sr.ReadToEnd();
            }

            templateValorizzato = Regex.Replace(template, pattern, match =>
            {
                string chiave = match.Groups[1].Value;
                if (placeholders.ContainsKey(chiave))
                {
                    return placeholders[chiave];
                }
                else
                {
                    return match.Value;
                }

            });



            return templateValorizzato;
        }
    }
}
