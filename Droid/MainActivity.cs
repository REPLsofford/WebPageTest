using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace WebPageTest.Droid
{
    [Activity(Label = "WebPageTest", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var webView = FindViewById<WebView>(Resource.Id.webView);
            webView.LoadUrl("https://ppe.ourtesco.com/scheduler");

            // Enabled Java Script
            var settings = webView.Settings;
            settings.JavaScriptEnabled = true;
            settings.LoadWithOverviewMode = true;
            settings.UseWideViewPort = true;
            webView.SetInitialScale(1);
        }
    }
}

