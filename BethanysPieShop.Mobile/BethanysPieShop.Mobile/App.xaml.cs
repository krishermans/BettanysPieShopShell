using BethanysPieShop.Mobile.Core.Bootstrap;
using BethanysPieShop.Mobile.Core.Contracts.Services.General;
using BethanysPieShop.Mobile.Core.Views;
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
            navigationService.InitializeAsync().Wait();
        }

        private void InitializeApp()
        {
            AppContainer.RegisterDependencies();

            MainPage = new AppShell();
        }
    }
}
