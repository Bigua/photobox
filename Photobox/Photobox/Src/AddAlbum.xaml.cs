﻿using System;
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
using System.Diagnostics;
using System.Windows.Media;

namespace PhotoBox.Src
{
    public partial class AddAlbum : PhoneApplicationPage
    {
        public AddAlbum()
        {
            InitializeComponent();

            BuildLocalizedApplicationBar();

            this.loadPictures();
        }

        private void BuildLocalizedApplicationBar()
        {
            ApplicationBar = new ApplicationBar();

            ApplicationBarIconButton appBarButtonSave = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.save.png", UriKind.Relative));
            appBarButtonSave.Text = "Salvar";
            appBarButtonSave.Click += this.ClickSaveAlbumButton;
            ApplicationBar.Buttons.Add(appBarButtonSave);
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

        private void ClickSaveAlbumButton(object sender, EventArgs e)
        {

        }

        private void OnTapImage(object sender, System.Windows.Input.GestureEventArgs e)
        {
            StackPanel panel = (StackPanel)sender;
            Image iconCheck = new Image();
            iconCheck.Source = new BitmapImage(new Uri("/Assets/Icon/icon.check.png", UriKind.Relative));
            Image background = (Image)panel.Children.ElementAt(0);
            ImageBrush brush = new ImageBrush();
            brush.ImageSource = background.Source;
            panel.Background = brush;
            panel.Children.Clear();
            panel.Children.Add(iconCheck);
            panel.UpdateLayout();
        }
    }
}