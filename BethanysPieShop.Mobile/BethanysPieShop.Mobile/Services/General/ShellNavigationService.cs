using BethanysPieShop.Mobile.Core.Constants;
using BethanysPieShop.Mobile.Core.Contracts.Services.General;
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
            var mainPage =  Application.Current.MainPage;
            if (mainPage is Shell)
            {
                _currentShell = (Shell)mainPage;
            }
            else
            {
                throw new Exception("MainPage of app should be a Shell instance but is: " + mainPage.GetType());
            }

            BuildShellLayout();
            CreatePageViewModelMappings();
        }

        private void CreatePageViewModelMappings()
        {
            //throw new NotImplementedException();
        }

        private void BuildShellLayout()
        {
            var homeSection = new ShellSection()
            {
                Title = "Home",
                Route = NavigationRouteConstants.HomeRoute,
                FlyoutIcon = "ic_home.png"
            };
            homeSection.Items.Add(new ShellContent()
            {
                Content = new HomeView()
            });
            _currentShell.Items.Add(homeSection);

            var pieSection = new ShellSection()
            {
                Title = "Pies",
                Route = NavigationRouteConstants.PieCatalogRoute,
                FlyoutIcon = "ic_pies.png"
            };
            pieSection.Items.Add(new ShellContent()
            {
                Content = new PieCatalogView()
            });
            _currentShell.Items.Add(pieSection);

            var cartSection = new ShellSection()
            {
                Title = "Cart",
                Route = NavigationRouteConstants.ShoppingCartRoute,
                FlyoutIcon = "ic_cart.png"
            };
            cartSection.Items.Add(new ShellContent()
            {
                Content = new MainPage()
            });
            _currentShell.Items.Add(cartSection);

            var contactSection = new ShellSection()
            {
                Title = "Contact us",
                Route = NavigationRouteConstants.ContactRoute,
                FlyoutIcon = "ic_contact.png"
            };
            contactSection.Items.Add(new ShellContent()
            {
                Content = new MainPage()
            });
            _currentShell.Items.Add(contactSection);

            var logoutSection = new ShellSection()
            {
                Title = "Logout",
                Route = NavigationRouteConstants.LoginRoute,
                FlyoutIcon = "ic_logout.png"
            };
            logoutSection.Items.Add(new ShellContent()
            {
                Content = new MainPage()
            });
            _currentShell.Items.Add(logoutSection);
        }

        public Task ClearBackStack()
        {
            throw new NotImplementedException();
        }

        public Task InitializeAsync()
        {
            throw new NotImplementedException();
        }

        public Task NavigateBackAsync()
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync<TViewModel>() where TViewModel : ViewModelBase
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync<TViewModel>(object parameter) where TViewModel : ViewModelBase
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync(Type viewModelType)
        {
            throw new NotImplementedException();
        }

        public Task NavigateToAsync(Type viewModelType, object parameter)
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync()
        {
            throw new NotImplementedException();
        }

        public Task RemoveLastFromBackStackAsync()
        {
            throw new NotImplementedException();
        }
    }
}
