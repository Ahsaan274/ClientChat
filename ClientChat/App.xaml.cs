using ClientChat.Tabs;
using ClientChat.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClientChat
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MjA4NDM2QDMxMzcyZTM0MmUzMFprSG5sdEdvZjRQbUtONkVBK2pFZTJZaWpQZFZVMSs2Zjc2MitwdjE0REk9");
            InitializeComponent();

         MainPage = new NavigationPage(new SplashPage());
         //    MainPage = new TabbedPage1();
            //MainPage = new Testing();
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
