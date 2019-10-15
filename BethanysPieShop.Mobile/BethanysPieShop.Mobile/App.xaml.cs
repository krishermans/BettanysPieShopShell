using BethanysPieShop.Mobile.Core.Bootstrap;
using BethanysPieShop.Mobile.Core.Contracts.Services.General;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShop.Mobile.Core
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            InitializeApp();

            InitializeNavigation();
        }

        private void InitializeNavigation()
        {
            var navigationService = AppContainer.Resolve<INavigationService>();
        }

        private void InitializeApp()
        {
            AppContainer.RegisterDependencies();

            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
