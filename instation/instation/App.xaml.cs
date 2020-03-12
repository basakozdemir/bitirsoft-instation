using System;
using instation.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace instation
{
    public partial class App : Application
    {

        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjE5MzAxQDMxMzcyZTM0MmUzMEsrNCtIak5FbitlK0VKemNONVF1a0dSZEJpYi9sNytwTFRXS0RoVmNiZ2s9");

            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
