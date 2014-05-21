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

namespace PhotoBox.Src
{
    public partial class AddAlbum : PhoneApplicationPage
    {
        public AddAlbum()
        {
            InitializeComponent();
            this.loadPictures();
        }

        private void loadPictures()
        {
            MediaLibrary mediaLibrary = new MediaLibrary();
            PictureCollection pictureCollection = mediaLibrary.Pictures;
            listBox.ItemsSource = pictureCollection.ToList();
        }
    }
}