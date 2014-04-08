using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Fligern.UsefulReminder.Helpers
{
    class RelayCommand : ICommand
    {
        Action<object> _execute;
        Predicate<object> _canExecute;
        public RelayCommand(Predicate<object> canExecute, Action<object> execute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }
        public RelayCommand(Action<object> execute)
            : this((object o) => { return true; }, execute)
        {
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            if (_execute != null)
            {
                _execute(parameter);
            }
        }
    }
}
