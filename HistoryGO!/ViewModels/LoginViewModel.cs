using HistoryGO_.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace HistoryGO_.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public Action DisplayInvalidLoginPrompt;
        public event PropertyChangingEventHandler PropertyChanged = delegate { };
        private string username;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                PropertyChanged(this, new PropertyChangingEventArgs("Username"));
            }
        }
        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangingEventArgs("Password"));
            }
        }
        public ICommand SubmitCommand { protected set; get; }

        public LoginViewModel()
        {
            Title = "Account";
            SubmitCommand = new Command(OnSubmit);
        }

        public void OnSubmit()
        {
            if (username != "testUser" || password != "password")
            {
                DisplayInvalidLoginPrompt();
            }
        }
    }
}
