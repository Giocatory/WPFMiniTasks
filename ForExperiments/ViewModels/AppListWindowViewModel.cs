using ForExperiments.Infrastructure.Commands;
using ForExperiments.ViewModels.Base;
using ForExperiments.Views.Questions;
using System.Windows;
using System.Windows.Input;

namespace ForExperiments.ViewModels
{
    internal class AppListWindowViewModel : ViewModel
    {
        #region Заголовок Окна

        private string _Title = "List of applications";
        private string _Description = "Добро пожаловать в коллекцию мини приложений!\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";

        /// <summary> Заголовок Окна </summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        public string Description { get => _Description; set => Set(ref _Description, value); }

        #endregion Заголовок Окна

        #region Команды

        // 1
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        // 2 OpenGeneralWindowCommand
        public ICommand OpenGeneralWindowCommand { get; }

        private void OnOpenGeneralWindowCommand(object p)
        {
            GeneralQuestions gq = new();
            gq.Show();
        }

        private bool CanOpenGeneralWindowCommandExecute(object p) => true;

        #endregion Команды

        public AppListWindowViewModel()
        {
            #region Commands

            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            OpenGeneralWindowCommand = new LamdaCommand(OnOpenGeneralWindowCommand, CanOpenGeneralWindowCommandExecute);

            #endregion Commands
        }
    }
}