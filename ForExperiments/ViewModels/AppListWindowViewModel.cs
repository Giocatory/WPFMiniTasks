﻿using ForExperiments.Infrastructure.Commands;
using ForExperiments.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace ForExperiments.ViewModels
{
    internal class AppListWindowViewModel : ViewModel
    {
        #region Заголовок Окна

        private string _Title = "List of applications";

        /// <summary> Заголовок Окна </summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        #endregion Заголовок Окна

        #region Команды

        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        #endregion Команды

        public AppListWindowViewModel()
        {
            #region Commands

            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion Commands
        }
    }
}