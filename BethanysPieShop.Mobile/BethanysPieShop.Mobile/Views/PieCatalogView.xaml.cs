using BethanysPieShop.Mobile.Core.Bootstrap;
using BethanysPieShop.Mobile.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BethanysPieShop.Mobile.Core.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PieCatalogView : ContentPage
    {
        private PieCatalogViewModel _viewModel = null;

        public PieCatalogView()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            _viewModel = AppContainer.Resolve<PieCatalogViewModel>();
            await _viewModel.InitializeAsync(null);
            this.BindingContext = _viewModel;
        }
    }
}