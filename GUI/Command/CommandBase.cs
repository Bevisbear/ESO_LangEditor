﻿using System;
using System.Windows.Input;

namespace GUI.Command
{
    public abstract class CommandBase : ICommand
    {
        private bool _isExecuting;
        public event EventHandler CanExecuteChanged;

        public bool IsExecuting
        {
            get { return _isExecuting; }
            set { _isExecuting = value; CanExecuteChanged?.Invoke(this, new EventArgs()); }
        }


        public bool CanExecute(object parameter)
        {
            return !IsExecuting;
        }

        public void Execute(object parameter)
        {
            IsExecuting = true;

            ExecuteCommand(parameter);

            IsExecuting = false;
        }

        public abstract void ExecuteCommand(object parameter);
    }
}
