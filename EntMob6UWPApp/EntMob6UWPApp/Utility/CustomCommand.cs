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

        public CustomCommand(Action<Object> execute, Predicate<Object> canExecute  )
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }
        public bool CanExecute(object parameter)
        {
            bool b = canExecute == null ? true : canExecute(parameter); //TODO kan zijn dat dit RAiseCanExecuteChanged moet zijn http://stackoverflow.com/questions/12030697/what-replaces-commandmanager-in-winrt. Kijk nog na morgen
            return b;
        }

        public void Execute(object parameter)
        {
            execute(parameter);
        }

        public event EventHandler CanExecuteChanged;
        public void RaiseCanExecuteChanged()
        {
            if (CanExecuteChanged != null)
                CanExecuteChanged(this, EventArgs.Empty);
        }
    }
}
