using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Microsoft.Xna.Framework.Media;
using Photobox.Resources;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Diagnostics;
using Photobox.Src;
using System.Threading.Tasks;

namespace Photobox
{
    public partial class MainPage : PhoneApplicationPage
    {
        private SolidColorBrush colorBorder;
        // Constructor
        public MainPage()
        {
            InitializeComponent();
            this.loadPictures();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}

        private void loadPictures()
        {
            MediaLibrary library = new MediaLibrary();
            PictureCollection pictures = library.Pictures;
            List<BitmapImage> list = new List<BitmapImage>();
            
            foreach (Picture pic in pictures)
            {
                BitmapImage image = new BitmapImage();
                image.SetSource(pic.GetImage());
                image.CreateOptions = BitmapCreateOptions.BackgroundCreation;
                list.Add(image);
            }

            listImage.ItemsSource = list;
            this.colorBorder = new SolidColorBrush(Colors.Red);
        }

        private void OnTapImage(object sender, System.Windows.Input.GestureEventArgs e)
        {
            Border border = sender as Border;

            if (border.BorderBrush == null)
            {
                border.BorderBrush = this.colorBorder;
            }
            else
            {
                border.BorderBrush = null;
            }
        }

        private void OnTapShareButtonIcon(object sender, EventArgs e)
        {
            Bluetooth bt = new Bluetooth();
            bt.start();
            bt.findPeers();
        }
    }
}