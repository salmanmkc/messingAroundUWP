﻿using MyToolkit.Multimedia;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App21
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        internal async Task<Uri> GetYoutubeUri(string VideoID)
        {
            YouTubeUri uri = await YouTube.GetVideoUriAsync(VideoID, YouTubeQuality.Quality1080P);
            return uri.Uri;
           
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Uri _videoUri = await GetYoutubeUri("s1EOxMrbPb4");
            if (_videoUri != null)
            {
                player.Source = _videoUri;
                player.Play();
            }
        }
    }


}
