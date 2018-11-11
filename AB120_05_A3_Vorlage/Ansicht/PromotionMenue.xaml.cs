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

namespace AB120_05_A3_Vorlage.Ansicht
{
    /// <summary>
    /// Interaktionslogik für Menü.xaml
    /// </summary>
    public partial class Menü : UserControl
    {
        public Menü()
        {
            InitializeComponent();
        }

        private void red_MouseMove(object sender, MouseEventArgs e)
        {
            this.Background = new SolidColorBrush(Colors.Red);
        }

        private void Label_MouseMove(object sender, MouseEventArgs e)
        {
            BrushConverter bc = new BrushConverter();
            this.Background = (Brush) bc.ConvertFrom("#FF2D692D");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Serching.SerchString = Serchfild.Text;
            Serching ser = new Serching();
            PpromotionWindow.WinPromotion.DP.Children.Clear();
            PpromotionWindow.WinPromotion.DP.Children.Add(ser);
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
    }
}