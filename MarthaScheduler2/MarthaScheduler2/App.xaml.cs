using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MarthaScheduler2
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NDk5ODEzQDMxMzkyZTMyMmUzMGZyUm9tU0kzeWpKVzZJT3BDcW4xRjA3UDR3dzREV2E4cW1OTEFwS25kVDg9 ");
            InitializeComponent();

            MainPage = new MainPage();
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
