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
    /// Interaction logic for Oefening36.xaml
    /// </summary>
    public partial class Oefening36 : Window
    {
        public Oefening36()
        {
            InitializeComponent();
        }



        private void btnTest_Click(object sender, RoutedEventArgs e)
        {
            string strTemp = string.Empty;
            foreach (var item in checkboxContainer.Children)
            {
                CheckBox tmp = item as CheckBox;
                if (tmp != null && tmp.IsChecked.Value)
                {
                    strTemp += tmp.Content + "\n";
                }
            }
            MessageBox.Show("de aangevinkte checkboxen zijn\n" + strTemp);
        }
    }
}
