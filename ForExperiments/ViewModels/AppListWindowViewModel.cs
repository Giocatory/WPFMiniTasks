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

        #region CloseApplicationCommand

        // 1 CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        #endregion CloseApplicationCommand

        #region OpenGeneralWindowCommand

        // 2 OpenGeneralWindowCommand
        public ICommand OpenGeneralWindowCommand { get; }

        private void OnOpenGeneralWindowCommand(object p)
        {
            GeneralQuestions gq = new();
            gq.Show();
        }

        private bool CanOpenGeneralWindowCommandExecute(object p) => true;

        #endregion OpenGeneralWindowCommand

        #region OpenJuniorQuestionsWindowCommand

        // 3 OpenJuniorQuestionsWindowCommand
        public ICommand OpenJuniorQuestionsWindowCommand { get; }

        private void OnOpenJuniorQuestionsWindowCommand(object p)
        {
            JuniorQuestions jq = new();
            jq.Show();
        }

        private bool CanOpenJuniorQuestionsWindowCommandExecute(object p) => true;

        #endregion OpenJuniorQuestionsWindowCommand

        #region OpenMiddleQuestionsWindowCommand

        // 4 OpenMiddleQuestionsWindowCommand
        public ICommand OpenMiddleQuestionsWindowCommand { get; }

        private void OnOpenMiddleQuestionsWindowCommand(object p)
        {
            MiddleQuestions mq = new();
            mq.Show();
        }

        private bool CanOpenMiddleQuestionsWindowCommandExecute(object parameter) => true;

        #endregion OpenMiddleQuestionsWindowCommand

        #region OpenSeniorQuestionsWindowCommand

        // 5 OpenSeniorQuestionsWindowCommand
        public ICommand OpenSeniorQuestionsWindowCommand { get; }

        private void OnOpenSeniorQuestionsWindowCommand(object p)
        {
            SeniorQuestions sq = new();
            sq.Show();
        }

        private bool CanOpenSeniorQuestionsWindowCommandExecute(object parameter) => true;

        #endregion OpenSeniorQuestionsWindowCommand

        #region OpenTestingWindowCommand

        public ICommand OpenTestingWindowCommand { get; }

        private void OnOpenTestingWindowCommand(object parameter)
        {
            Testing testing = new();
            testing.Show();
        }

        private bool CanOpenTestingWindowCommandExecute(object parameter) => true;

        #endregion OpenTestingWindowCommand

        public AppListWindowViewModel()
        {
            #region Commands

            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);
            OpenGeneralWindowCommand = new LamdaCommand(OnOpenGeneralWindowCommand, CanOpenGeneralWindowCommandExecute);
            OpenJuniorQuestionsWindowCommand = new LamdaCommand(OnOpenJuniorQuestionsWindowCommand, CanOpenJuniorQuestionsWindowCommandExecute);
            OpenMiddleQuestionsWindowCommand = new LamdaCommand(OnOpenMiddleQuestionsWindowCommand, CanOpenMiddleQuestionsWindowCommandExecute);
            OpenSeniorQuestionsWindowCommand = new LamdaCommand(OnOpenSeniorQuestionsWindowCommand, CanOpenSeniorQuestionsWindowCommandExecute);
            OpenTestingWindowCommand = new LamdaCommand(OnOpenTestingWindowCommand, CanOpenTestingWindowCommandExecute);

            #endregion Commands
        }
    }
}