using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using HistoryGO_.Models;
using HistoryGO_.Views;
using HistoryGO_.ViewModels;

namespace HistoryGO_.Views
{
    public partial class UserPage : ContentPage
    {
        UserViewModel _viewModel;

        public UserPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new UserViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}