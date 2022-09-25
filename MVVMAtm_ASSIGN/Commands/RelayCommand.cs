using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MVVMAtm_ASSIGN.Commands
{
    public class RelayCommand : ICommand
    {

        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;


        // execute

        public RelayCommand(Action<object> execute) : this(execute, null)
        {
        }

        public RelayCommand(Action<object> execute, Predicate<object> canExecute)
        {

            // constructor 
            if (execute == null)
            {
                throw new ArgumentNullException("execute method is missing");
            }
            _execute = execute;
            _canExecute = canExecute;

        }

        public RelayCommand()
        {
        }

        public bool CanExecute(object parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);

        }

        public void Execute(object parameter)
        {
            _execute(parameter); //delegate invoke - method invoke
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}
