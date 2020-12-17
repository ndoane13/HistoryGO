using System;
using System.ComponentModel;
using Xamarin.Forms.Maps;

namespace HistoryGO_.ViewModels
{
    public class Location : INotifyPropertyChanged
    {
        Position _position;

        public string Address { get; }
        public string Description { get; }
        public int ID { get; }

        public Position Position
        {
            get => _position;
            set
            {
                if (!_position.Equals(value))
                {
                    _position = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Position)));
                }
            }
        }

        //constructor for Location. generates the data for the pins and stores it, including ID for info window clicks
        public Location(string description, string address, Position position)
        {
            Address = address;
            Description = description;
            Position = position;
            Random gen = new Random();
            ID = gen.Next();
        }

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion
    }
}

