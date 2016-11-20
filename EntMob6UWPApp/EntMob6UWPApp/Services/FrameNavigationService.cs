using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace EntMob6UWPApp.Services
{
    public class FrameNavigationService : IFrameNavigation
    {
        Frame currentFrame;
        public void NavigateToFrame(Type frame)
        {
            currentFrame = (Frame)Window.Current.Content;
            currentFrame.Navigate(frame);

        }
    }
}