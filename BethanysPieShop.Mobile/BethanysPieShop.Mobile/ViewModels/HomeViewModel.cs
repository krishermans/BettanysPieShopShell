using BethanysPieShop.Mobile.Core.Contracts.Services.Data;
using BethanysPieShop.Mobile.Core.Contracts.Services.General;
using BethanysPieShop.Mobile.Core.Extensions;
using BethanysPieShop.Mobile.Core.Models;
using BethanysPieShop.Mobile.Core.Repository;
using BethanysPieShop.Mobile.Core.Services.Data;
using BethanysPieShop.Mobile.Core.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace BethanysPieShop.Mobile.Core.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly ICatalogDataService _catalogDataService;
        private ObservableCollection<Pie> _piesOfTheWeek;

        public HomeViewModel(/*INavigationService navigationService,
            IDialogService dialogService,*/
            ICatalogDataService catalogDataService)
            : base(/*navigationService, dialogService*/)
        {
            _catalogDataService = catalogDataService;

            PiesOfTheWeek = new ObservableCollection<Pie>();
        }

        public ObservableCollection<Pie> PiesOfTheWeek
        {
            get => _piesOfTheWeek;
            set
            {
                _piesOfTheWeek = value;
                OnPropertyChanged();
            }
        }

        public override async Task InitializeAsync(object data)
        {
            PiesOfTheWeek = (await _catalogDataService.GetPiesOfTheWeekAsync()).ToObservableCollection();
        }
    }
}
