using BethanysPieShop.Mobile.Core.ViewModels.Base;
using System;
using System.Threading.Tasks;

namespace BethanysPieShop.Mobile.Core.Contracts.Services.General
{
    public interface INavigationService
    {
        Task InitializeAsync();

        Task NavigateToAsync(string route);

        Task NavigateToAsync(string route, object parameter);

        Task ClearBackStack();

        Task NavigateBackAsync();

        Task RemoveLastFromBackStackAsync();

        Task PopToRootAsync();
    }
}
