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
    /// Interaction logic for Oefening33.xaml
    /// </summary>
    public partial class Oefening33 : Window
    {
        public Oefening33()
        {
            InitializeComponent();
        }

        private void btClick_Click(object sender, RoutedEventArgs e)
        {
            if (lbLabel.Background == Brushes.White)
            {
                lbLabel.Background = Brushes.Blue;
                lbLabel.Foreground = Brushes.White;
            }
            else
            {
                if (lbLabel.Background == Brushes.Blue)
                {
                    lbLabel.Background = Brushes.White;
                    lbLabel.Foreground = Brushes.Black;
                }
                else
                {
                    lbLabel.Background = Brushes.Blue;
                    lbLabel.Foreground = Brushes.White;
                }
            }
        }
    }
}
