using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
namespace AB120_05_A3_Vorlage.Reise
{
    public partial class TravelAdministration : UserControl
    {
        public static ObservableCollection<DB.Reise> Reisen = new ObservableCollection<DB.Reise>();

        public TravelAdministration()
        {
            InitializeComponent();
            Reisen = new ObservableCollection<DB.Reise>(APP.Reise.Lesen_Alle());
        }

        private void Save(object Sender, RoutedEventArgs e)
        {
        
        }

        private void Focus(object Sender, MouseEventArgs e)
        {

        }
        private void New_Click(object Sender, RoutedEventArgs E)
        {
            EditTravel Edit = new EditTravel();
            Edit.Show();
        }

        private void Edit_Click(object Sender, RoutedEventArgs E)
        {
            if (lb.SelectedItem != null)
            {

               EditTravel Edit = new EditTravel(lb.SelectedItem as DB.Reise);
               Edit.Show();

            }
        }

        private void Delete_Click(object Sender, RoutedEventArgs e)
        {
            if (lb.SelectedItem != null)
            {
                APP.Kunde.Loeschen(Reisen.Single(Reise => Reise.ReiseID  == ((DB.Reise) lb.SelectedItem).ReiseID));
                Reisen.Remove((Reisen.Single(Reise =>    Reise.ReiseID == ((DB.Reise) lb.SelectedItem).ReiseID)));
            }
        }
    }
}
