using System.ComponentModel;
using EntMob6UWP.Domain;
using EntMob6UWPApp.Utility;

namespace EntMob6UWPApp.ViewModels
{
    public class MainpageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private User loggedInUser;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        public User LoggedInUser
        {
            get { return loggedInUser; }
            set
            {
                loggedInUser = value;
                RaisePropertyChanged("LoggedInUser");

            }
        }

        public MainpageViewModel()
        {
            Messenger.Default.Register<User>(this, OnUserReceived);
        }

        private void OnUserReceived(User user)
        {
            LoggedInUser = user;
        }
    }
}