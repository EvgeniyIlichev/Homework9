using h5;
using Homework9.Infrastructure.Commands;
using Homework9.Models;
using Homework9.ViewModels.Base;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Homework9.ViewModels
{
    class MainWindowViewModels : ViewModel
    {
        #region Titul

        private string _Title = "Домашнее задание 9";
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }
        #endregion

        public MainWindowViewModels()
        {

        }
    }
}
