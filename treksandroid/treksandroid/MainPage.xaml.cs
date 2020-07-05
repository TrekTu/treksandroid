using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace treksandroid
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            
            
        }
         
        void bing(object sender, EventArgs e)
        {

            string url = "https://cn.bing.com/dict/search?q=" + urleditor.Text;
            webview1.Source = url;
            //  string myuri = "https://cn.bing.com/dict/search?q=" + editor.Text;
            //  Browser.OpenAsync(myuri, BrowserLaunchMode.SystemPreferred);
        }
        void ip(object sender, EventArgs e)
        {
            string url = "https://whatismyipaddress.com/ip/" + urleditor.Text;
            webview1.Source = url;
            //  string myuri = "https://whatismyipaddress.com/ip/" + editor.Text;
            // Browser.OpenAsync(myuri, BrowserLaunchMode.SystemPreferred);
        }
        void oxford(object sender, EventArgs e)
        {
            string url = "https://www.oxfordlearnersdictionaries.com/us/definition/english/" + urleditor.Text;
            webview1.Source = url;
            //   string myuri = "https://www.oxfordlearnersdictionaries.com/us/definition/english/" + editor.Text;
            //      Browser.OpenAsync(myuri, BrowserLaunchMode.SystemPreferred);
        }
      


    }
}
