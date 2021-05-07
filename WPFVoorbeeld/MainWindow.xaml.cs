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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFVoorbeeld
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("Hello world");
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            //Console.WriteLine(BtnMyButton1.Content.ToString());
            //MessageBox.Show(BtnMyButton1.Content.ToString());
        }

        private void BtnOefening1_Click(object sender, RoutedEventArgs e)
        {
            Oefening1 oefening1 = new Oefening1();
            oefening1.ShowDialog();
        }

        private void BtnOefening2_Click(object sender, RoutedEventArgs e)
        {
            Oefening2 oefening2 = new Oefening2();
            oefening2.ShowDialog();
        }

        private void BtnOefening3_Click(object sender, RoutedEventArgs e)
        {
            Oefening3 oefening3 = new Oefening3();
            oefening3.ShowDialog();
        }

        private void BtnOefening4_Click(object sender, RoutedEventArgs e)
        {
            Oefening4 oefening4 = new Oefening4();
            oefening4.ShowDialog();
        }

        private void BtnOefening5_Click(object sender, RoutedEventArgs e)
        {
            Oefening5 oefening5 = new Oefening5();
            oefening5.ShowDialog();
        }

        private void BtnOefening6_Click(object sender, RoutedEventArgs e)
        {
            Oefening6 oefening6 = new Oefening6();
            oefening6.ShowDialog();
        }

        private void BtnOefening21_Click(object sender, RoutedEventArgs e)
        {
            Oefening21 oefening21 = new Oefening21();
            oefening21.ShowDialog();
        }

        private void BtnOefening22_Click(object sender, RoutedEventArgs e)
        {
            Oefening22 oefening22 = new Oefening22();
            oefening22.ShowDialog();
        }

        private void BtnOefening23_Click(object sender, RoutedEventArgs e)
        {
            Oefening23 oefening23 = new Oefening23();
            oefening23.ShowDialog();
        }

        private void BtnOefening24_Click(object sender, RoutedEventArgs e)
        {
            Oefening24 oefening24 = new Oefening24();
            oefening24.ShowDialog();
        }

        private void BtnOefening31_Click(object sender, RoutedEventArgs e)
        {
            Oefening31 oefening31 = new Oefening31();
            oefening31.ShowDialog();
        }

        private void BtnOefening32_Click(object sender, RoutedEventArgs e)
        {
            Oefening32 oefening32 = new Oefening32();
            oefening32.ShowDialog();
        }

        private void BtnOefening33_Click(object sender, RoutedEventArgs e)
        {
            Oefening33 oefening33 = new Oefening33();
            oefening33.ShowDialog();
        }

        private void BtnOefening34_Click(object sender, RoutedEventArgs e)
        {
            Oefening34 oefening34 = new Oefening34();
            oefening34.ShowDialog();
        }

        private void BtnOefening35_Click(object sender, RoutedEventArgs e)
        {
            Oefening35 oefening35 = new Oefening35();
            oefening35.ShowDialog();
        }

        private void BtnOefening36_Click(object sender, RoutedEventArgs e)
        {
            Oefening36 oefening36 = new Oefening36();
            oefening36.ShowDialog();
        }

        private void BtnOefening37_Click(object sender, RoutedEventArgs e)
        {
            Oefening37 oefening37 = new Oefening37();
            oefening37.ShowDialog();
        }
    }
}
