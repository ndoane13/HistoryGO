using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using HistoryGO_.ViewModels;
using HistoryGO_.Models;
using System.Collections.Generic;

namespace HistoryGO_.Views
{
    public partial class MapPage : ContentPage
    {
        MapViewModel _viewModel;

        public MapPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new MapViewModel();
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(43.6613889, -70.2558333), Distance.FromMiles(0.5)));
        }

        void OnMapClicked(object sender, MapClickedEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine($"MapClick: {e.Position.Latitude}, {e.Position.Longitude}");
        }
    }
}