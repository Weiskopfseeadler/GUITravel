using AB120_05_A3_Vorlage.Hotel;
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

namespace AB120_05_A3_Vorlage
{
    /// <summary>
    /// Interaktionslogik für HotelAdministration.xaml
    /// </summary>
    public partial class HotelAdministration : UserControl
    {
        public static ObservableCollection<DB.Hotel> Hotels = new ObservableCollection<DB.Hotel>();
      

        public HotelAdministration()
        {
            InitializeComponent();

            Hotels.Clear();
            Hotels = new ObservableCollection<DB.Hotel>(APP.Hotel.Lesen_Alle());

            /*foreach (DB.Hotel Hotel in APP.Hotel.Lesen_Alle())
            {
                
                Hotels.Add(Hotel);
            }*/
            foreach (var Hotel in Hotels)
            {
                try
                {
                    if (Hotel.HotelBild != null)
                    {


                        if (Hotel.HotelBild.Count > 0)
                        {
                            if ((Hotel.HotelBild as List<DB.HotelBild>)?[0].Bild != null)
                            {
                                Hotel.BitmapImage =
                                    Program.BitmapImageFromBytes((Hotel.HotelBild as List<DB.HotelBild>)?[0].Bild);
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                   
                    Console.WriteLine(e);
                   
                }
               
            }

            lb.ItemsSource = Hotels;
            
        }

   

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            EditHotels edit = new EditHotels(lb.SelectedItem as DB.Hotel);
            edit.Show();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            EditHotels edit = new EditHotels();
            edit.Show();
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            if (lb.SelectedItem != null)
            {
                APP.Hotel.Loeschen(Hotels.Single(Hotel => Hotel.HotelID == (lb.SelectedItem as DB.Hotel).HotelID));
                Hotels.Remove((Hotels.Single(Hotel => Hotel.HotelID == (lb.SelectedItem as DB.Hotel).HotelID)));
            }
        }
    }
}
