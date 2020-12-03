using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using HistoryGO_.Services;
using HistoryGO_.Views;

namespace HistoryGO_
{
    public partial class App : Application
    {

        public App()
        {
            Device.SetFlags(new string[] { "Shapes_Experimental" });
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
