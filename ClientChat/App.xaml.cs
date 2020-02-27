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
            InitializeComponent();

            MainPage = new NavigationPage(new SplashPage());
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
