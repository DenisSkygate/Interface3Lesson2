using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MonTextBlock.Text = "Coucou " + FirstnameTextBox.Text + " " + LastnameTextBox.Text + "!\nTon mot de passe est : " + MyPassword.Password;
            if(Img.Visibility == Visibility.Collapsed)
            {
                Img.Visibility = Visibility.Visible;
            }
            else
            {
                Img.Visibility = Visibility.Collapsed;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(Damier));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(LoginPage));
        }
    }
}
