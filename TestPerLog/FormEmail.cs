using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TestPerLog
{
    public partial class FormEmail : Form
    {
        public FormEmail()
        {
            InitializeComponent();
        }

        private void labelOggetto_Click(object sender, EventArgs e)
        {

        }

        private void buttonInvio_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> placeholders = new Dictionary<string, string>();
            placeholders.Add("Matricola", textDestinatario.Text);
            placeholders.Add("Descrizione", "03090909");
            List<string> list = new List<string>();
            list.Add("ricambio1");
            list.Add("ricambio2");
            list.Add("ricambio3");
            list.Add("ricambio4");
            placeholders.Add("Ricambi", HelperEmail.CreaStringaRicambi(list));

            //bool inviato = HelperEmail.InviaEmailConTemplate(ConfigurationManager.AppSettings["Mail_PathTemplate"], textOggetto.Text, textTesto.Text, placeholders);

            //if (inviato)
            //    MessageBox.Show("Email inviata con successo", "Invio riuscito");
            //else
            //    MessageBox.Show("Invio email non possibile", "errore");



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
