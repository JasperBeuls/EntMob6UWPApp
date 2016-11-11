using System.ComponentModel;
using EntMob6UWP.Domain;
using EntMob6UWPApp.Services;
using EntMob6UWPApp.Utility;

namespace EntMob6UWPApp.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string username;
        private string password;
        private DialogService dialogService;
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

        public LoginViewModel()
        {
            dialogService = new DialogService();
        }
        private void Login()
        {
            User user = new User();
            user.Username = this.username;
            user.Password = this.password;
            Messenger.Default.Send<User>(user);
            dialogService.ShowDialog();
        }
    }
}