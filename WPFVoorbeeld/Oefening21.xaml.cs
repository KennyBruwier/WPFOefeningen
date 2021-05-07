using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for Oefening21.xaml
    /// </summary>
    public partial class Oefening21 : Window
    {
        public List<Persoon> cbList { get; set; } = new List<Persoon>();
        public Oefening21()
        {
            InitializeComponent();
            cbList.Add(new Persoon("Kenny", "Bruwier", "Images/emo-2.png"));
            cbList.Add(new Persoon("Kenny2", "Bruwier2", "Images/Me.jpg"));
            var test = typeof(Color).GetProperties();
            cbPersonen.ItemsSource = cbList;
            cbPersonen.SelectedIndex = 0;
        }

        public class Persoon
        {
            public string Voornaam { get; set; }
            public string Achternaam { get; set; }
            public string ImagePath { get; set; }
            public Persoon(string voornaam, string achternaam, string imagePath)
            {
                Voornaam = voornaam;
                Achternaam = achternaam;
                ImagePath = imagePath;
            }
            //public StylusPointPropertyInfo 
        }
        //private test()
        //{
        //    var request = WebRequest.Create("http://www.gravatar.com/avatar/6810d91caff032b202c50701dd3af745?d=identicon&r=PG");

        //    using (var response = request.GetResponse())
        //    using (var stream = response.GetResponseStream())
        //    {
        //        pictureBox1.Image = Bitmap.FromStream(stream);
        //    }

        //}

        private void cbPersonen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Persoon selectedItem = (cbPersonen.SelectedItem as Persoon);
            //var imgBrush = (ImageBrush)borderPersoon.Background;
            //var path = selectedItem.ImagePath;
            //imgBrush.ImageSource = new BitmapImage(new Uri(path, UriKind.Relative));
            imgPersoon.Source = new BitmapImage(new Uri(selectedItem.ImagePath, UriKind.Relative));
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (targetType == typeof(ImageSource))
            {
                if (value is string)
                {
                    string str = (string)value;
                    return new BitmapImage(new Uri(str, UriKind.RelativeOrAbsolute));
                }
                else if (value is Uri)
                {
                    Uri uri = (Uri)value;
                    return new BitmapImage(uri);
                }
            }
            return value;
        }
    }
}
