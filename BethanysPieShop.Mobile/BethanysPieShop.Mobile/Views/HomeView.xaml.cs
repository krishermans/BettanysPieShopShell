﻿using BethanysPieShop.Mobile.Core.Bootstrap;
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
    public partial class HomeView : ContentPage
    {
        //private HomeViewModel _viewModel = null;
        
        public HomeView()
        {
            InitializeComponent();
        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();

        //    _viewModel = AppContainer.Resolve<HomeViewModel>();
        //    await _viewModel.InitializeAsync();
        //    this.BindingContext = _viewModel;
        //}
    }
}