using System;
using System.ComponentModel;
using System.Windows.Input;
using Windows.UI.Popups;
using EntMob6UWP.Domain;
using EntMob6UWPApp.Services;
using EntMob6UWPApp.Utility;
using EntMob6UWPApp.View;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EntMob6UWPApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string username;
        private string password;
        private Account user;
        private IFrameNavigation frameNavigation;
        private AccountDataService accountDataService = new AccountDataService();
        public ICommand LoginCommand { get; set; }
        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                RaisePropertyChanged("Username");
            }
        }
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                RaisePropertyChanged("Password");
            }
        }

        public LoginViewModel(IFrameNavigation frameNavigation)
        {

            this.frameNavigation = frameNavigation;
            LoadCommands();

        }

        private void LoadCommands()
        {
            LoginCommand = new CustomCommand(LoginUser, CanLoginUser);
        }

        private void LoginUser(object obj)
        {
            
            Account returnedAccount = accountDataService.GetAccount(this.username, this.password);
            if (returnedAccount != null)
            {
                Messenger.Default.Send<Account>(user);
                frameNavigation.NavigateToFrame(typeof (OverviewView));
            }
            else
            {
                showMessage();
            }
            
        }

        private async void showMessage()
        {
            var dialog = new MessageDialog("Login info incorrect!");
            await dialog.ShowAsync();
        }
        private bool CanLoginUser(object obj)
        {
            return true;
            
        }
    }
}