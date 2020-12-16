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
        public ICommand NavigateCommand { private set; get; }
        public MapViewModel()
        {
            Title = "History!";

            //I don't actually think this works because for some reason the binding on infowindowclicked in the xaml doesnt recognize this. 
            //binding has given me a lot of trouble this whole time honestly. the MVVM model is just strange.
            //the way I saw many examples of how to do proper data binding using ICommand for mvvm literally just always gave me read-only errors. 
            NavigateCommand = new Command<Type>(
                async (Type pageType) =>
                {
                    await Shell.Current.GoToAsync("//PinDetailPage");
                });

            //For what its worth I found a full database of all current historical sites in the USA recognized by the National Register of Historic Places
            //But a lot of it was in gdb and other weird file formats that I honestly have no idea how to manipulate or use. 
            //not in this language and not in any other language. Maybe I should find a databases class...
            //so for now we get this...lovely...placeholder
            _locations = new ObservableCollection<Location>
            {
                new Location("Portland, ME", "It's a city...", new Position(43.6613889, -70.2558333)),
                new Location("Wadsworth-Longfellow House", "Built in 1786...", new Position(43.6568127336905, -70.2602901309729)),
                new Location("Portland Museum of Art", "Established in 1882...", new Position(43.6540144022661, -70.2626682445407)),
                new Location("Monument Square", "Major Town square...", new Position(43.6572609979657, -70.258971825242)),
                new Location("Cathedral of the Immaculate Conception", " Established in 1866...", new Position(43.661389,-70.254722)),
                new Location("Evergreen Cemetary", "Established in 1855...", new Position(43.680833,-70.301111)),
                new Location("Fort Gorges", "Established in 1858...", new Position(43.662778,-70.221667)),
                new Location("The Gothic House", "Built in 1845...", new Position(43.645833,-70.275)),
                new Location("Griffin House", "Built in 1871...", new Position(43.655833,-70.266389)),
                new Location("Hamblen Block", "Built in 1835...", new Position(43.648333,-70.263889)),
                new Location("Henry Wadsworth Longfellow Monument", "Established in 1888...", new Position(43.653056,-70.267222)),
                new Location("Victoria Mansion", "Built in 1860...", new Position(43.651667,-70.261111)),
                new Location("Nathan Clifford SChool", "Established in 1909...", new Position(43.660281,-70.280317)),
                new Location("Deering Oaks", "Established in 1875...", new Position(43.658889,-70.272222)),
                new Location("McLellan-Sweat Mansion", "Built in 1801...", new Position(43.653333,-70.2625)),
                new Location("Mechanics' Hall", "Established in 1859...", new Position(43.656389,-70.261944)),
                new Location("North School", "Established in 1867...", new Position(43.662222,-70.251944)),
                new Location("Portland City Hall", "Established in 1912...", new Position(43.659444,-70.2575)),
                new Location("Porteus, Mitchell, and Braun Company Building", "Established in 1904...", new Position(43.655833,-70.261111)),
                new Location("Thomas Bracket Reed", "Built in 1876...", new Position(43.6542,-70.2675))
        };
        }

    }
}