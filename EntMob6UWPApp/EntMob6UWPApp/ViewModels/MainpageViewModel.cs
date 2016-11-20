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
        public ICommand OverviewCommand { get; set; }
        public ICommand HistoryCommand { get; set; }
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
        }

        private void LoadCommands()
        {
            OverviewCommand = new CustomCommand(ShowOverview, CanShowValues);
            HistoryCommand = new CustomCommand(ShowHistoryView, CanShowValues);
        }

        private void ShowHistoryView(object obj)
        {
            frameNavigation.NavigateToFrame(typeof(HistoryView));
        }

        private void ShowOverview(object obj)
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