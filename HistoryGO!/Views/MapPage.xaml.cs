using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;
using HistoryGO_.ViewModels;
using HistoryGO_.Models;

namespace HistoryGO_.Views
{
    public partial class MapPage : ContentPage
    {
        MapViewModel _viewModel;

        public MapPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new MapViewModel();

            //starting region because the geolocator on emulators is weird. Helps me to at least set up stuff around portland
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(43.6613889, -70.2558333), Distance.FromMiles(0.5)));
        }

        void OnMapClicked(object sender, MapClickedEventArgs e)
        {
            //this is just to help me locate lat/lon because otherwise I'd have to use geocoder to try to swap between degrees/mins/seconds and doubles
            System.Diagnostics.Debug.WriteLine($"MapClick: {e.Position.Latitude}, {e.Position.Longitude}");
        }
    }
}