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
    /// Interaction logic for Oefening31.xaml
    /// </summary>
    public partial class Oefening31 : Window
    {
        public Oefening31()
        {
            InitializeComponent();
        }

        private void btClick_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(cbLeeftijd.Text.ToLower() + " " + cbGeslacht.Text.ToLower());
        }
    }
}
