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
using AB120_05_A3_Vorlage.Ansicht;
using AB120_05_A3_Vorlage.Reise;

namespace AB120_05_A3_Vorlage
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void KundenListe_Click(object sender, RoutedEventArgs e)
        {
            KundenListe kundenListe = new KundenListe();
            DockPanel.SetDock(kundenListe, Dock.Top);
            DP.Children.Clear();
            DP.Children.Add(kundenListe);
        }

        private void PromotionMode_Click(object sender, RoutedEventArgs e)
        {
            PpromotionWindow win1 = new PpromotionWindow();
            win1.Show();
        }

        private void HotelAdministrationel_Click(object sender, RoutedEventArgs e)
        {
            HotelAdministration hotel = new HotelAdministration();
            DockPanel.SetDock(hotel, Dock.Top);
            DP.Children.Clear();
            DP.Children.Add(hotel);
        }

        private void CustomerAdministration_Click(object sender, RoutedEventArgs e)
        {
            TravelAdministration travel = new TravelAdministration();
            DockPanel.SetDock(travel, Dock.Top);
            DP.Children.Clear();
            DP.Children.Add(travel);
        }
    }
}