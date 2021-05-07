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
    /// Interaction logic for Oefening24.xaml
    /// </summary>
    public partial class Oefening24 : Window
    {
        public Oefening24()
        {
            InitializeComponent();
        }

        private void btRecap_Click(object sender, RoutedEventArgs e)
        {
            Oefening24_Recap oefening24_Recap = new Oefening24_Recap(
                voornaam: tbVoornaam.Text,
                achternaam: tbAchternaam.Text,

                geslacht: cbMan.IsChecked.Value ? "man" : cbVrouw.IsChecked.Value ? "vrouw" : "onbekend",
                leeftijd: tbLeeftijd.Text,
                straat: tbStraat.Text,
                nr: tbNr.Text,
                woonplaats: tbWoonplaats.Text,
                land: tbLand.Text,
                postcode: tbPostcode.Text
                );
            this.Hide();
            oefening24_Recap.ShowDialog();
        }
    }
}
