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

namespace AB120_05_A3_Vorlage.Ansicht
{
    /// <summary>
    /// Interaktionslogik für PpromotionWindow.xaml
    /// </summary>
    public partial class PpromotionWindow : Window
    {
        public static PpromotionWindow WinPromotion;

        public PpromotionWindow()
        {
            InitializeComponent();
            WinPromotion = this;
            Menü Menu = new Menü();
            DockPanel.SetDock(Menu, Dock.Top);
            DP.Children.Clear();
            DP.Children.Add(Menu);
            
        }
       
    }
}
