using System;
using System.Windows.Input;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using HistoryGO_.Models;
using HistoryGO_.Views;

namespace HistoryGO_.ViewModels
{
    public class UserViewModel : BaseViewModel
    {
        private ICommand changePasswordTapped;
        public ICommand ChangePasswordTapped
        {
            get { return changePasswordTapped; }
        }

        public UserViewModel()
        {
            Title = "Account";
            changePasswordTapped = new Command(ChangePassword);
        }

        void ChangePassword(object sender)
        {
            
        }

        public void OnAppearing()
        {
            IsBusy = true;
        }
    }
}