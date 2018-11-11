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

namespace AB120_05_A3_Vorlage
{
    /// <summary>
    /// Interaktionslogik für Kundenverwaltung.xaml
    /// </summary>
    public partial class Kundenverwaltung : Window
    {
        public Kundenverwaltung()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txb1.Text = Program.AusgabeListeAlleKunden();

        }

     
    }
}
