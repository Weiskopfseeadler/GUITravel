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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AB120_05_A3_Vorlage.Ansicht.Kunden;
using System.Collections.ObjectModel;
using AB120_05_A3_Vorlage.DB;

namespace AB120_05_A3_Vorlage
{
    /// <summary>
    /// Interaktionslogik für KundenListe.xaml
    /// </summary>
    public partial class KundenListe : UserControl
    {
        public static ObservableCollection<DB.Kunde> Clients = new ObservableCollection<DB.Kunde>();

        public KundenListe()
        {
            InitializeComponent();
            LoadList();
        }
        public void LoadList()
        {
            Clients.Clear();
            foreach (DB.Kunde Client in APP.Kunde.ReadingAll())
            {
                Clients.Add(Client);
            }
            lb.ItemsSource = Clients;
            
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            NewClient NewClient = new NewClient();
            NewClient.Show();
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (lb.SelectedItem != null) {

                NewClient win = new NewClient(lb.SelectedItem as DB.Kunde);
                win.Show();

            }
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (lb.SelectedItem != null)
            {
                APP.Kunde.Loeschen(Clients.Single(Kunde => Kunde.KundeID == ((Kunde) lb.SelectedItem).KundeID));
                Clients.Remove((Clients.Single(Kunde => Kunde.KundeID == ((Kunde) lb.SelectedItem).KundeID)));
            }
        }
    }
}
