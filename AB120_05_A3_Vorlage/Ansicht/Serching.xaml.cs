using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AB120_05_A3_Vorlage.Ansicht
{
    /// <summary>
    /// Interaktionslogik für Serching.xaml
    /// </summary>
    public partial class Serching : UserControl
    {
        public ObservableCollection<DB.Hotel> Hotel = new ObservableCollection<DB.Hotel>();
        public static string SerchString;

        public Serching()
        {
            InitializeComponent();

            MakeList();
        }

        private void MakeList()
        {
            Hotel.Clear();
            foreach (DB.Hotel Client in APP.Hotel.Lesen_Alle())
            {
                Hotel.Add(Client);
            }

            lb.ItemsSource = Hotel;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            ChekPassWordForClose Close = new ChekPassWordForClose("Password:", "Password");
            if (Close.ShowDialog() == true)
            {
                if (Close.Answer == "Patrick_is_the_coolest")
                {
                    PpromotionWindow.WinPromotion.Close();
                }
            }
        }

        private void Serch_Click(object sender, RoutedEventArgs e)
        {
            SerchString = Serchfield.Text;
            MakeList();
        }


    }
}
