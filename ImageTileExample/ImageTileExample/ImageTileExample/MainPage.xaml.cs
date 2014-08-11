using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace ImageTileExample
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.imgTile.ItemsSource = this.GetImageData();
        }


        private List<Uri> GetImageData()
        {
			List<Uri> data = new List<Uri>();

			for (int i = 0; i <= 4; i++)
			{
				data.Add(new Uri(String.Format("Images/bmw{0}.jpg", i), UriKind.RelativeOrAbsolute));
			}

            return data;
        }
    }
}