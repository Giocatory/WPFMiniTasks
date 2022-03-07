using ForExperiments.Infrastructure.Commands;
using ForExperiments.ViewModels.Base;
using System;
using System.Windows;
using System.Windows.Input;

namespace ForExperiments.ViewModels
{
    internal class RegWindowViewModel : ViewModel
    {
        #region Заголовок Окна

        private string _Title = "Registration form";
        private string _Description = "1) Вводите пожалуйста латинские символы\n2) Пароль должен содержать:\n\t- Большие и маленькие буквы\n\t- Цифры";
        private string _DescriptionFinall = "- Для завршения нажмите \"Завершить\"\n- Если сомневаетесь, вернитесь назад\n\n\tСпасибо за регистрацию!";

        /// <summary> Заголовок Окна </summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        public string Description { get => _Description; set => Set(ref _Description, value); }

        public string DescriptionFinall { get => _DescriptionFinall; set => Set(ref _DescriptionFinall, value); }

        // Date time now
        private string _TimeNow = $"Последний запуск программы - {DateTime.Now}";

        public string TimeNow { get => _TimeNow; set => Set(ref _TimeNow, value); }

        #endregion Заголовок Окна

        #region Команды

        public ICommand CloseApplicationCommand { get; }

        private void OnCloseApplicationCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }

        private bool CanCloseApplicationCommandExecute(object p) => true;

        #endregion Команды

        public RegWindowViewModel()
        {
            #region Commands

            CloseApplicationCommand = new LamdaCommand(OnCloseApplicationCommandExecuted, CanCloseApplicationCommandExecute);

            #endregion Commands
        }
    }
}