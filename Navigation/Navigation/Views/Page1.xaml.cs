﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Navigation.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Page1 : Page
    {
        public Page1()
        {
            this.InitializeComponent();
        }

        void Page1_Button_Click(object sender, RoutedEventArgs e)
        {
            // Frame.Navigate(typeof(Page1));
        }

        void Page2_Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page2));
        }

        void Page3_Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Page3));
        }

        private void Grid_DoubleTapped(object sender, DoubleTappedRoutedEventArgs e)
        {

        }
    }
}
