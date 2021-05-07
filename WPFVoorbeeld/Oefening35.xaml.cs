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
    /// Interaction logic for Oefening35.xaml
    /// </summary>
    public partial class Oefening35 : Window
    {
        public Oefening35()
        {
            InitializeComponent();
            lbPersonen.Items.Add(new Person("kenny", "bruwier", true));
            lbPersonen.Items.Add(new Person("kenny", "bruwier", false));
            lbPersonen.Items.Add(new Person("kenny", "bruwier", true));
            lbPersonen.Items.Add(new Person("kenny", "bruwier", true));
        }
    }
    public class Person 
    {
        private string firstname, lastname;
        bool ingelogd;
        public string Firstname { get => firstname; set => firstname = value; }
        public string Lastname { get => lastname; set => lastname = value; }
        public bool Ingelogd { get => ingelogd; set => ingelogd = value; }
        public Person(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public Person(string firstname, string lastname, bool ingelogd) : this(firstname, lastname)
        {
            Ingelogd = ingelogd;
        }
    }
       
}
