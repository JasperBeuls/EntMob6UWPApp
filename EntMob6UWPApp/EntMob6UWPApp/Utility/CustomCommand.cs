using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EntMob6UWPApp.Utility
{
    class CustomCommand : ICommand
    {
        private Action<Object> execute;
        private Predicate<Object> canExecute;
        public CustomCommand(Action<Object> execute )
        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }

        public event EventHandler CanExecuteChanged;
    }
}
