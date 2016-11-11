using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace EntMob6UWPApp.Extensions
{
    public static class ListExtensions
    {
        public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> col)
        {
            var c = new ObservableCollection<T>();
            foreach (var e in col)
            {
             c.Add(e);   
            }
            return c;
        } 
    }
}