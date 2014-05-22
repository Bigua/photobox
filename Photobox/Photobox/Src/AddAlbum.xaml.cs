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
using System.Windows.Media.Imaging;

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

            for (int i = 0; i < pictureCollection.Count; ++i)
            {
                BitmapImage bitImg = new BitmapImage();
                bitImg.SetSource(pictureCollection.ElementAt(i).GetImage());
                listBox.Items.Add(bitImg);
            }
        }
    }
}