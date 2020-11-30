using System.ComponentModel;
using Xamarin.Forms;
using HistoryGO_.ViewModels;

namespace HistoryGO_.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}