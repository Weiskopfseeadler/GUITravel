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

namespace AB120_05_A3_Vorlage.Reise
{
    /// <summary>
    /// Interaktionslogik für EditTravel.xaml
    /// </summary>
    public partial class EditTravel : Window
    {
        public EditTravel()
        {
            InitializeComponent();
        }
        
        public EditTravel(DB.Reise Reise)
        {
            InitializeComponent();
        }

        private void Save(object sender, RoutedEventArgs e)
        {

        }

        private void focus(object sender, MouseEventArgs e)
        {

        }


    }
}
