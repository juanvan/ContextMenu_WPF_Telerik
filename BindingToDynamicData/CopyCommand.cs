﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BindingToDynamicData
{
    public class CopyCommand : ICommand
    {
        public bool CanExecute(object parameter)
        {
            var textBox = parameter as TextBox;

            if (textBox != null && textBox.SelectedText != String.Empty)
            {
                return true;
            }

            return false;
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            var textBox = parameter as TextBox;
            var textToCopy = textBox.SelectedText;

            Clipboard.SetText(textToCopy);
            textBox.Focus();
        }
    }
}
