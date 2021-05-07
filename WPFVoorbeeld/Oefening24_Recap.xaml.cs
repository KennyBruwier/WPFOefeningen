using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFVoorbeeld
{
    /// <summary>
    /// Interaction logic for Oefening24_Recap.xaml
    /// </summary>
    public partial class Oefening24_Recap : Window
    {
        public Oefening24_Recap()
        {
            InitializeComponent();
        }

        public Oefening24_Recap(string voornaam, string achternaam, string geslacht, string leeftijd, string straat, string nr, string woonplaats, string postcode, string land)
        {
            InitializeComponent();
            lbVoornaam.Content = voornaam;
            lbAchternaam.Content = achternaam;
            lbGeslacht.Content = geslacht;
            lbLand.Content = land;
            lbLeeftijd.Content = leeftijd;
            lbNr.Content = nr;
            lbPostcode.Content = postcode;
            lbStraat.Content = straat;
            lbWoonplaats.Content = woonplaats;
        }

        private void btExit_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }
    }
}
