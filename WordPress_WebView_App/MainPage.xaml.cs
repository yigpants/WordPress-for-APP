using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WordPress_WebView_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoBackButton_Clicked(Object sender, EventArgs e)
        {
            if (mainWebView.CanGoBack)
            {
                mainWebView.GoBack();
            }
        }

        private void GoForwardButton_Clicked(Object sender, EventArgs e)
        {
            if (mainWebView.CanGoForward)
            {
                mainWebView.GoForward();
            }
        }
        private void ReloadButton_Clicked(Object sender, EventArgs e)
        {
            mainWebView.Reload();
        }

        private void mainWebView_Navigated(Object sender, WebNavigatedEventArgs e)
        {
            displayLabel.Text = (mainWebView.Source as UrlWebViewSource).Url;
        }
    }
}
