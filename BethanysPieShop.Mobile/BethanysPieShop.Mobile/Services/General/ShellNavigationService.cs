using BethanysPieShop.Mobile.Core.Constants;
using BethanysPieShop.Mobile.Core.Contracts.Services.General;
using BethanysPieShop.Mobile.Core.ViewModels;
using BethanysPieShop.Mobile.Core.ViewModels.Base;
using BethanysPieShop.Mobile.Core.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BethanysPieShop.Mobile.Core.Services.General
{
    public class ShellNavigationService : INavigationService
    {
        private Shell _currentShell;

        public ShellNavigationService()
        {
            RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute(NavigationRouteConstants.PieDetailRoute, typeof(PieDetailView));
        }

        public Task InitializeAsync()
        {
            return Task.Run(() =>
            {
                var mainPage = Application.Current.MainPage;
                if (mainPage is Shell)
                {
                    _currentShell = (Shell)mainPage;
                }
                else
                {
                    throw new Exception("MainPage of app should be a Shell instance but is: " + mainPage.GetType());
                }
            });
        }

        public Task NavigateToAsync(string route)
        {
            return _currentShell.GoToAsync(route);
        }

        public Task NavigateToAsync(string route, object parameter)
        {
            // find page type for route

            return _currentShell.GoToAsync(route);
        }

        public Task ClearBackStack()
        {
            throw new NotImplementedException();
        }

        public Task NavigateBackAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveLastFromBackStackAsync()
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync()
        {
            throw new NotImplementedException();
        }
    }
}
