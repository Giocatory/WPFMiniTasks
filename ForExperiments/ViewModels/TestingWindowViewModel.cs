using ForExperiments.Infrastructure.Commands;
using ForExperiments.ViewModels.Base;
using System.Windows;
using System.Windows.Input;

namespace ForExperiments.ViewModels
{
    internal class TestingWindowViewModel : ViewModel
    {
        #region Заголовок Окна

        private string _Title = "Проверка знаний";
        private string _Description = "Выберите уровень знаний и попробуйте пройти тест";

        /// <summary> Заголовок Окна </summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        public string Description { get => _Description; set => Set(ref _Description, value); }

        #endregion Заголовок Окна

        #region Команды

        // 1 CloseApplicationCommand
        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        #endregion Команды

        public TestingWindowViewModel()
        {
            #region Commands

            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion Commands
        }
    }
}