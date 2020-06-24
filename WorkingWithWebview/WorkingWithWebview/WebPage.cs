using Xamarin.Forms;

namespace WorkingWithWebview
{
    public class WebPage : ContentPage
    {
        public WebPage()
        {
            var browser = new WebView();
            browser.Source = "https://mx.stickymongoose.org.uk/sogo";
            Content = browser;
        }
    }
}

