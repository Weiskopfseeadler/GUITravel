using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AB120_05_A3_Vorlage.Ansicht.Kunden
{
    /// <summary>
    /// Interaktionslogik für NewClient.xaml
    /// </summary>
    public partial class NewClient : Window
    {
        public DB.Kunde Client;
        public bool ifNewL;


        public NewClient()
        {
            InitializeComponent();
            ifNewL = true;
            Client = new DB.Kunde();
        }
        public NewClient(DB.Kunde client)
        {
            InitializeComponent();
            Client = client;
            ifNewL = false;
            InitializeComponent();
            Client = client;
            ifNewL = false;
            tbLastName.Text= Client.Anrede;
            tbAnrede.Text= Client.Name;
            tbNameZusatz.Text= Client.NameZusatz;
            tbStrasseNr.Text= Client.StrasseNr;
            tbPLZ.Text= Convert.ToString(Client.PLZ);
            tbOrt.Text= Client.Ort;
            tbTelefon.Text= Client.Telefon;
            tbMobile.Text= Client.Mobile;
            tbEmail.Text= Client.Email;
        }

        public bool checktb()
        {
            return true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (checktb())
            {
                if (ifNewL)
                {
                    DB.Kunde Client = new DB.Kunde();
                    Client.Name    =tbName.Text;
                    Client.Vorname     =tbLastName.Text;
                    Client.Anrede       =tbAnrede.Text;
                    Client.NameZusatz =tbNameZusatz.Text;
                    Client.StrasseNr  =tbStrasseNr.Text;
                    Client.PLZ        =Convert.ToInt16(tbPLZ.Text);
                    Client.Ort        =tbOrt.Text;
                    Client.Telefon    =tbTelefon.Text;
                    Client.Mobile     =tbMobile.Text;
                    Client.Email      =tbEmail.Text;
                    
                    APP.Kunde.Erstellen(Client);
                    KundenListe.Clients.Add(Client);
                }
                else
                {
                       Client.KundeID    =Convert.ToInt16(tbName.Text);
                       Client.Anrede     =tbAnrede.Text;
                       Client.Vorname    =tbLastName.Text;
                       Client.Name       =tbName.Text;
                       Client.NameZusatz =tbNameZusatz.Text;
                       Client.StrasseNr  =tbStrasseNr.Text;
                       Client.PLZ        =Convert.ToInt16(tbPLZ.Text);
                       Client.Ort        =tbOrt.Text;
                       Client.Telefon    =tbTelefon.Text;
                       Client.Mobile     =tbMobile.Text;
                       Client.Email      =tbEmail.Text;
                    DB.Kunde Kunde = APP.Kunde.Lesen_KundeID(Client.KundeID);
                    APP.Kunde.Aktualisieren(Kunde);
                                        
                }
                this.Close();
            }

        }

 

        private void focus(object sender, MouseEventArgs e)
        {
            

                (sender as TextBox).SelectAll();
                (sender as TextBox).Focus();

            
        }
    }
}