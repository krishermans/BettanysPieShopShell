using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using BethanysPieShop.Mobile.Core.Constants;
using BethanysPieShop.Mobile.Core.Contracts.Services.Data;
using BethanysPieShop.Mobile.Core.Contracts.Services.General;
using BethanysPieShop.Mobile.Core.Extensions;
using BethanysPieShop.Mobile.Core.Models;
using BethanysPieShop.Mobile.Core.ViewModels.Base;
using Xamarin.Forms;

namespace BethanysPieShop.Mobile.Core.ViewModels
{
    public class PieCatalogViewModel : ViewModelBase
    {
        private readonly ICatalogDataService _catalogDataService;

        private ObservableCollection<Pie> _pies;

        public PieCatalogViewModel(/*IConnectionService connectionService,*/
            INavigationService navigationService, /*IDialogService dialogService,*/
            ICatalogDataService catalogDataService)
            : base(/*connectionService,*/ navigationService/*, dialogService*/)
        {
            _catalogDataService = catalogDataService;
        }

        public ICommand PieTappedCommand => new Command<Pie>(OnPieTapped);

        public ObservableCollection<Pie> Pies
        {
            get => _pies;
            set
            {
                _pies = value;
                OnPropertyChanged();
            }
        }

        private void OnPieTapped(Pie selectedPie)
        {
            // Order is important!
            // First navigate, this makes sure the viewmodel exists and is subscribed to the messenger
            _navigationService.NavigateToAsync(NavigationRouteConstants.PieDetailRoute);
            // now send the message to any interested viewmodel
            MessagingCenter.Instance.Send<PieCatalogViewModel, Pie>(this, NavigationRouteConstants.PieDetailRoute, selectedPie);
        }

        public override async Task InitializeAsync()
        {
            IsBusy = true;

            Pies = (await _catalogDataService.GetAllPiesAsync()).ToObservableCollection();

            IsBusy = false;
        }
    }
}
