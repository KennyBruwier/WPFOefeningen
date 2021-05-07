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
    /// Interaction logic for Oefening3.xaml
    /// </summary>
    public partial class Oefening3 : Window
    {
        public Oefening3()
        {
            InitializeComponent();
        }

        private void btSom_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(tbValue1.Text + " + " + tbValue2.Text + " = " + (Convert.ToInt32(tbValue1.Text) + Convert.ToInt32(tbValue2.Text)));
        }
    }
}
