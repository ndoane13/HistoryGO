using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace HistoryGO_.ViewModels
{
    public class MapViewModel : BaseViewModel
    {
        public MapViewModel()
        {
            Title = "History!";
            //OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamain-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}