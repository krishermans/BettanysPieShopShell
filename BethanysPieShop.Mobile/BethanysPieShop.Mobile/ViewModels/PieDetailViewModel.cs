using System;
using System.Threading.Tasks;
using System.Windows.Input;
using BethanysPieShop.Mobile.Core.Constants;
using BethanysPieShop.Mobile.Core.Contracts.Services.General;
using BethanysPieShop.Mobile.Core.Models;
using BethanysPieShop.Mobile.Core.ViewModels.Base;
using Xamarin.Forms;

namespace BethanysPieShop.Mobile.Core.ViewModels
{
    public class PieDetailViewModel : ViewModelBase
    {
        private Pie _selectedPie;

        public PieDetailViewModel(/*IConnectionService connectionService,*/
            INavigationService navigationService/*, IDialogService dialogService*/)
            : base(/*connectionService, */navigationService/*, dialogService*/)
        {
            MessagingCenter.Subscribe<PieCatalogViewModel, Pie>(this, NavigationRouteConstants.PieDetailRoute, OnPieReceived);
        }

        private void OnPieReceived(PieCatalogViewModel viewModel, Pie pie)
        {
            SelectedPie = pie;
        }

        public ICommand AddToCartCommand => new Command(OnAddToCart);
        public ICommand ReadDescriptionCommand => new Command(OnReadDescription);

        public Pie SelectedPie
        {
            get => _selectedPie;
            set
            {
                _selectedPie = value;
                OnPropertyChanged();
            }
        }

        public override async Task InitializeAsync()
        {
            //SelectedPie = (Pie)data;
            //gaat zo niet: met een Messenger doen vooraleer je navigeert...
        }

        private async void OnAddToCart()
        {
            //MessagingCenter.Send(this, MessagingConstants.AddPieToBasket, SelectedPie);
            //await _dialogService.ShowDialog("Pie added to your cart", "Success", "OK");
        }

        private void OnReadDescription()
        {
            DependencyService.Get<ITextToSpeech>().ReadText(SelectedPie.LongDescription);
        }
    }
}
