using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HistoryGO_.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HistoryGO_.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            var lvm = new LoginViewModel();
            this.BindingContext = lvm;
            lvm.DisplayInvalidLoginPrompt += () => DisplayAlert("Error", "Invalid username/password", "Okay!");

            Username.Completed += (object sender, EventArgs args) =>
            {
                Password.Focus();
            };

            Password.Completed += (object sender, EventArgs args) =>
            {
                lvm.SubmitCommand.Execute(null);
            };
        }
    }
}