﻿using System.Windows.Input;

namespace ToDoList.Core
{
    public class RelayCommand : ICommand
    {
        public event EventHandler? CanExecuteChanged;

        private Action mAction;

        public RelayCommand(Action action)
        {
          mAction = action;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            mAction();
        }
    }
}
