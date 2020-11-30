using System;
using System.Collections.Generic;
using HistoryGO_.ViewModels;
using HistoryGO_.Views;
using Xamarin.Forms;

namespace HistoryGO_
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
