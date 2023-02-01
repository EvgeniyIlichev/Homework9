using Homework9.Infrastructure.Commands;
using Homework9.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;

namespace Homework9.ViewModels
{
    class MainWindowViewModels : ViewModel
    {
        private string _Title = "Домашнее задание 9";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #region Команды

        #region CloseApplicationCommand
        public ICommand SendText
        {
            get;
        }

        private bool CanSendTextExecute(object p) => true;
        private void OnSendTextExecuted(object p)
        {
            
        }

        #endregion
        #endregion
        public MainWindowViewModels()
        {
            SendText = new LambdaCommand(OnSendTextExecuted, CanSendTextExecute);
        }
    }
}
