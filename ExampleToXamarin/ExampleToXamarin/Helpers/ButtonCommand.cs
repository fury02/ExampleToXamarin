using System;
using System.Collections.Generic;
using System.Text;

using System.Windows.Input;

namespace ExampleToXamarin.Helpers
{
    class ButtonCommand : ICommand
    {
        private Action<object> execute;

        public event EventHandler CanExecuteChanged;

        public ButtonCommand(Action<object> execute) { this.execute = execute; }

        public void RaiseCanExecuteChanged() => CanExecuteChanged?.Invoke(this, EventArgs.Empty);

        public bool CanExecute(object parameter) => true;

        public void Execute(object parameter) => execute(parameter);
    }
}
