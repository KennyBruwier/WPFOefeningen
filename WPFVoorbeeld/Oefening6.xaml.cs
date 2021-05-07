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
    /// Interaction logic for Oefening6.xaml
    /// </summary>
    public partial class Oefening6 : Window
    {
        public Oefening6()
        {
            InitializeComponent();
        }

        private void btBlad_Click(object sender, RoutedEventArgs e)
        {
            if (BladSteenSchaar("blad"))
                MessageBox.Show("je hebt gewonnen");
            else
                MessageBox.Show("Je hebt verloren");
        }
        private bool BladSteenSchaar(string keuzeGebruiker)
        {
            string[] keuzes = { "blad", "steen", "schaar" };
            Random rnd = new Random();
            string keuzeComputer = keuzes[rnd.Next(0,2)];
            tbKeuzeComputer.Text = keuzeComputer;
            bool gewonnen = false;
            switch(keuzeGebruiker.ToLower())
            {
                case "blad": if (keuzeComputer == keuzes[1]) gewonnen = true; break;
                case "steen": if (keuzeComputer == keuzes[2]) gewonnen = true; break;
                case "schaar": if (keuzeComputer == keuzes[0]) gewonnen = true; break;
            }
            return gewonnen;
        }

        private void btSteen_Click(object sender, RoutedEventArgs e)
        {
            if (BladSteenSchaar("steen"))
                MessageBox.Show("je hebt gewonnen");
            else
                MessageBox.Show("Je hebt verloren");
        }

        private void btSchaar_Click(object sender, RoutedEventArgs e)
        {
            if (BladSteenSchaar("schaar"))
                MessageBox.Show("je hebt gewonnen");
            else
                MessageBox.Show("Je hebt verloren");
        }
    }
}
