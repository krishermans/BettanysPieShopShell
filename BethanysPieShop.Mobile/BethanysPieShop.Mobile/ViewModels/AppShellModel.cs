using BethanysPieShop.Mobile.Core.Contracts.Services.General;
using BethanysPieShop.Mobile.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BethanysPieShop.Mobile.Core.ViewModels
{
    public class AppShellModel : ViewModelBase
    {
        private string _welcomeText;

        public AppShellModel(INavigationService navigationService)
            : base(navigationService)
        {
            _welcomeText = "Welcome!";
        }

        public string WelcomeText
        {
            get
            { 
                return _welcomeText;
            }
            set
            { 
                _welcomeText = value;
                OnPropertyChanged(nameof(WelcomeText));
            }
        }

    }
}
