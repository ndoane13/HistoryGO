using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms.Maps;
using Xamarin.Essentials;
using Xamarin.Forms;
using HistoryGO_.ViewModels;
using HistoryGO_.Models;

namespace HistoryGO_.ViewModels
{
    public class MapViewModel : BaseViewModel
    {
        readonly ObservableCollection<Location> _locations;

        public IEnumerable Locations => _locations;

        public MapViewModel()
        {
            Title = "History!";
            _locations = new ObservableCollection<Location>
            {
                new Location("Portland, ME", "It's a city", new Position(43.6613889, -70.2558333)),
                new Location("Wadsworth-Longfellow House", "Established in 1786", new Position(43.6568127336905, -70.2602901309729)),
                new Location("Portland Museum of Art", "Established in 1882", new Position(43.6540144022661, -70.2626682445407)),
                new Location("Monument Square", "Major Town square", new Position(43.6572609979657, -70.258971825242)),
            };
        }


    }
}