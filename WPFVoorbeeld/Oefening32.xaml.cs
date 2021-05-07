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
    /// Interaction logic for Oefening32.xaml
    /// </summary>
    public partial class Oefening32 : Window
    {
        public Oefening32()
        {
            InitializeComponent();
        }

        private void tbTab1_KeyUp(object sender, KeyEventArgs e)
        {
            tbTab2.Text = tbTab1.Text;
        }

        private void tbTab2_KeyUp(object sender, KeyEventArgs e)
        {
            tbTab1.Text = tbTab2.Text;
        }

    }
}
