using ForExperiments.Infrastructure.Commands;
using ForExperiments.ViewModels.Base;
using System;
using System.Windows;
using System.Windows.Input;

namespace ForExperiments.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок Окна

        private string _Title = "Mini Apps";
        private string _Description = "Mini Apps for your desktops";

        /*
         set {
            if (Equals(_Title, value)) return;
            _Title = value;
            OnPropertyChanged();
        // OR
            Set(ref _Title, value);
        }
        */

        /// <summary> Заголовок Окна </summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        public string Description { get => _Description; set => Set(ref _Description, value); }

        #endregion Заголовок Окна

        #region Показ даты входа

        // Date time now
        private string _TimeNow = $"Последний запуск программы - {DateTime.Now}";

        public string TimeNow { get => _TimeNow; set => Set(ref _TimeNow, value); }

        #endregion Показ даты входа

        #region Команды

        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        #endregion Команды

        public MainWindowViewModel()
        {
            #region Commands

            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion Commands
        }
    }
}