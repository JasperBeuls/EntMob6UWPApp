using System;
using Windows.UI.Xaml.Data;

namespace EntMob6UWPApp.Converters
{
    public class DoubleConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            double percentage = (double)value;
            return Math.Round(percentage,2) + "%";
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new System.NotImplementedException();
        }
    }
}