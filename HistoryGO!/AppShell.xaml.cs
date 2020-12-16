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

            //Routing seems to be able to be done either through the shell cs code itself or through the xaml definition. I am currently going the xaml route
            //Routing.RegisterRoute(nameof(PinDetailPage), typeof(PinDetailPage));
        }

    }
}
