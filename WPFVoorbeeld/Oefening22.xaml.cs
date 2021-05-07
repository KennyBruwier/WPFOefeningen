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
    /// Interaction logic for Oefening22.xaml
    /// </summary>
    public partial class Oefening22 : Window
    {
        public string[] myImages { get; set; }
        public Oefening22()
        {
            InitializeComponent();
            var imagesDir = @"C:\Users\kenny\source\repos\WPFVoorbeeld\WPFVoorbeeld\Images\";
            myImages = Directory.GetFiles(imagesDir, "*.*", SearchOption.AllDirectories);
            sbPictures.Maximum = myImages.GetUpperBound(0);
            sbPictures.SmallChange = 1;
        }

        private void sbPictures_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {
            var myValue = sbPictures.Value;
            imgPicture.Source = new BitmapImage(new Uri(myImages[Convert.ToInt32(sbPictures.Value)], UriKind.Absolute));
        }
    }
}
