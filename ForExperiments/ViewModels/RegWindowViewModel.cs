using ForExperiments.ViewModels.Base;

namespace ForExperiments.ViewModels
{
    internal class RegWindowViewModel : ViewModel
    {
        #region Заголовок Окна

        private string _Title = "Registration form";
        private string _Description = "1) Вводите пожалуйста латинские символы\n2) Пароль должен содержать:\n\t- Большие и маленькие буквы\n\t- Цифры";

        /// <summary> Заголовок Окна </summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        public string Description { get => _Description; set => Set(ref _Description, value); }

        #endregion Заголовок Окна
    }
}