using ForExperiments.Infrastructure.Commands;
using ForExperiments.ViewModels.Base;
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

        #region Descriptions for app list

        private string InterviewЙuestions = "Постарался собрать вопросы, которые могут попадаться на собеседованиях C# программистов, а так же подробные ответы\nЕсли будут предложения и пожелания, напишите мне\ngiocatory@yandex.ru";

        #endregion Descriptions for app list

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