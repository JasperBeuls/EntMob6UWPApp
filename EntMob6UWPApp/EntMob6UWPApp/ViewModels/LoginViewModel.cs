using System;
using System.ComponentModel;
using System.Windows.Input;
using EntMob6UWP.Domain;
using EntMob6UWPApp.Services;
using EntMob6UWPApp.Utility;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EntMob6UWPApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string username = "test";
        private string password = "test";
        private User user;
        private IFrameNavigation frameNavigation;
        public ICommand LoginCommand { get; set; }
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
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
            get { return username; }
            set
            {
                username = value;
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
            user = new User();
            user.Username = this.username;
            user.Password = this.password;
            Messenger.Default.Send<User>(user);
            frameNavigation.NavigateToFrame(typeof(MainPage));
        }

        private bool CanLoginUser(object obj)
        {
            return true;
            
        }
    }
}