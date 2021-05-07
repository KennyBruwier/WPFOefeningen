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
    /// Interaction logic for Oefening5.xaml
    /// </summary>
    public partial class Oefening5 : Window
    {
        public List<Persoon> persoons = new List<Persoon>();
        public Oefening5()
        {
            InitializeComponent();
        }

        private void btToevoegen_click(object sender, RoutedEventArgs e)
        {
            if ((tbVoornaam.Text != "") && (tbAchternaam.Text != ""))
            {
                persoons.Add(new Persoon(tbVoornaam.Text, tbAchternaam.Text));
                MessageBox.Show(tbVoornaam.Text + " " + tbAchternaam.Text + " is toegevoegd");
            }
        }

        private void btIndex_click(object sender, RoutedEventArgs e)
        {
            int iIndex = Convert.ToInt32(tbIndex.Text);
            if (iIndex <= persoons.Count)
                MessageBox.Show("Persoon " + tbIndex.Text + " = " + persoons[iIndex-1].Voornaam + " " + persoons[iIndex-1].Achternaam);
        }
    }
    public class Persoon
    {
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public Persoon(string voornaam, string achternaam)
        {
            Voornaam = voornaam;
            Achternaam = achternaam;
        }
    }
}
