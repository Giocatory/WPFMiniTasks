using ForExperiments.ViewModels.Base;

namespace ForExperiments.ViewModels
{
    internal class SeniorQuestionsViewModel : ViewModel
    {
        #region Заголовок Окна

        private string _Title = "Вопросы для Senior .NET";
        private string _Description = "Вопросы с собеседований на должность Senior .NET разработчика";

        /// <summary> Заголовок Окна </summary>
        public string Title { get => _Title; set => Set(ref _Title, value); }

        public string Description { get => _Description; set => Set(ref _Description, value); }

        #endregion Заголовок Окна
    }
}
