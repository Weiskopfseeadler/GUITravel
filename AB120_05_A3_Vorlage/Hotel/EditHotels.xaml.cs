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
using AB120_05_A3_Vorlage.DB;
using Microsoft.Win32;
using System.Text.RegularExpressions;

namespace AB120_05_A3_Vorlage.Hotel
{
    /// <summary>
    /// Interaktionslogik für EditHotels.xaml
    /// </summary>
    public partial class EditHotels : Window
    {
        public DB.Hotel Hotel;
        public bool ifNew;
        byte[] Byte;
        int erors;
        BitmapImage image = new BitmapImage();

        public static IEnumerable<T> FindVisualChildren<T>(DependencyObject depObj) where T : DependencyObject
        {
            if (depObj != null)
            {
                for (int i = 0; i < VisualTreeHelper.GetChildrenCount(depObj); i++)
                {
                    DependencyObject child = VisualTreeHelper.GetChild(depObj, i);
                    if (child != null && child is T)
                    {
                        yield return (T) child;
                    }

                    foreach (T childOfChild in FindVisualChildren<T>(child))
                    {
                        yield return childOfChild;
                    }
                }
            }
        }

        public EditHotels()
        {
            InitializeComponent();
            ifNew = true;
            Hotel = new DB.Hotel();
        }

        public EditHotels(DB.Hotel Hotel)
        {
            InitializeComponent();
            this.Hotel = Hotel;
            ifNew = false;
            preShow.Source = Hotel.BitmapImage;

            tbName.Text = Hotel.Name;
            tbOrt.Text = Hotel.Ort;
            tbLand.Text = Convert.ToString(Hotel.Land);
            tbManager.Text = Hotel.Manager;
            tbAnzahlZimmer.Text = Convert.ToString(Hotel.AnzahlZimmer);
            tbTagesPreis.Text = Convert.ToString(Hotel.TagesPreis);
            tbTelefon.Text = Hotel.Telefon;
            tbEmail.Text = Hotel.Email;
            tbWeb.Text = Hotel.Web;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (checktb())
            {
                if (ifNew)
                {
                    DB.Hotel Hotel = new DB.Hotel();
                    Hotel.Name = tbName.Text;
                    Hotel.Ort = tbOrt.Text;
                    Hotel.Land = Convert.ToInt64(tbLand.Text);
//                    Hotel.Sterne        = tbManager.Text;
                    Hotel.Manager = Sterne.Text;
                    Hotel.AnzahlZimmer = Convert.ToInt16(tbAnzahlZimmer.Text);
                    Hotel.TagesPreis = Convert.ToDecimal(tbTagesPreis.Text);
                    Hotel.Telefon = tbTelefon.Text;
                    Hotel.BitmapImage = image;
                    Hotel.Manager = tbManager.Text;
                    Hotel.Email = tbEmail.Text;
                    Hotel.Web = tbWeb.Text;
                    APP.Hotel.Erstellen(Hotel);
                    HotelBild HB = new HotelBild();
                    HB.Bild = Byte;
                    Hotel.HotelBild.Add(HB);
                    HotelAdministration.Hotels.Add(Hotel);
                }
                else
                {
                    //  Hotel.BitmapImage = Program.BitmapImageFromBytes((Program.BytesFromPath(tblastName.Text)));
                    Hotel.Name = tbName.Text;
                    Hotel.Ort = tbOrt.Text;
                    Hotel.Land = Convert.ToInt64(tbLand.Text);
//                    Hotel.Sterne        = tbManager.Text;
                    Hotel.Manager = Sterne.Text;
                    Hotel.AnzahlZimmer = Convert.ToInt16(tbAnzahlZimmer.Text);
                    Hotel.TagesPreis = Convert.ToDecimal(tbTagesPreis.Text);
                    Hotel.Telefon = tbTelefon.Text;
                    Hotel.BitmapImage = image;
                    Hotel.Manager = tbManager.Text;
                    Hotel.Email = tbEmail.Text;
                    Hotel.Web = tbWeb.Text;
                    APP.Hotel.Aktualisieren(Hotel);
                    HotelBild HB = new HotelBild();
                    HB.Bild = Byte;
                    Hotel.HotelBild.Add(HB);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show("Input Erreor");
            }
        }

        private bool checktb()
        {
            Color col = Colors.Red;
            var errorFields = FindVisualChildren<TextBox>(this).ToList();
            foreach (var error in errorFields)
            {
                error.Focus();
            }

            foreach (var error in errorFields)
            {
                if (((SolidColorBrush) error.Background).Color.Equals(col))
                {
                    return false;
                }
            }

            return true;
        }

        private void openDialog(object sender, RoutedEventArgs e)
        {
            OpenFileDialog o1 = new OpenFileDialog();
            o1.Filter = "Bilder(.jpg,.png)|*.png;*.jpg";
            if (o1.ShowDialog() == true)
            {
                string filePath = o1.FileName;
                preShow.Source = new BitmapImage(new Uri(filePath));

                Byte = Program.BytesFromPath(filePath);

                //checkData.SaveImageToByte(o1.FileName);
            }
        }


        private void tbManager_LostFocus(object sender, RoutedEventArgs e)
        {
            if (!IsOnlyNumbers((sender as TextBox).Text))
            {
                (sender as TextBox).Background = new SolidColorBrush(Colors.Red);
                (sender as TextBox).ToolTip = "Darf nur Zahlen enthalten";
            }
            else
            {
                (sender as TextBox).Background = new SolidColorBrush(Colors.White);
            }
        }

        public bool IsOnlyNumbers(string text)
        {
            Regex regex = new Regex("^[0-9]+$");
            return regex.IsMatch(text);
        }

        private void tbEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress((sender as TextBox).Text);
                    (sender as TextBox).Background = new SolidColorBrush(Colors.White);
                }
                catch
                {
                    (sender as TextBox).Background = new SolidColorBrush(Colors.Red);
                }
            }
        }
    }
}