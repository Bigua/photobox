using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Microsoft.Phone.Controls;
using PhotoBox.ViewModels;


namespace PhotoBox
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.Loaded += new RoutedEventHandler(MainPage_Loaded);
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            var viewModel = new PhotosViewModel();
            DataContext = viewModel;

            PhotoHubLLS.ScrollTo(PhotoHubLLS.ItemsSource[PhotoHubLLS.ItemsSource.Count - 1]);
        }
    }
}