using System.ComponentModel;
using System.Windows.Input;
using Windows.UI.Interactivity;
using EntMob6UWP.Domain;
using EntMob6UWPApp.Services;
using EntMob6UWPApp.Utility;
using EntMob6UWPApp.View;

namespace EntMob6UWPApp.ViewModels
{
    public class MainpageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private User loggedInUser;
        private IFrameNavigation frameNavigation;
        public ICommand ValueCommand { get; set; }
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

        public MainpageViewModel(IFrameNavigation frameNavigation)
        {
            this.frameNavigation = frameNavigation;
            Messenger.Default.Register<User>(this, OnUserReceived);
            LoadCommands();
            //frameNavigation.NavigateToFrame(typeof(OverviewView));
            //HistoryPage.Navigate(typeof(HistoryView));
        }

        private void LoadCommands()
        {
            ValueCommand = new CustomCommand(ShowPivot, CanShowValues);
        }

        private void ShowPivot(object obj)
        {
            frameNavigation.NavigateToFrame(typeof(OverviewView));
        }

        private bool CanShowValues(object obj)
        {
            return true;
        }

        private void OnUserReceived(User user)
        {
            LoggedInUser = user;
        }
    }
}