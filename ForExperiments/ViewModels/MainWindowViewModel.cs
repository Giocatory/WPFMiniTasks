using ForExperiments.ViewModels.Base;

namespace ForExperiments.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        #region Заголовок Окна

        private string _Title = "Mini Apps";

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

        #endregion Заголовок Окна
    }
}