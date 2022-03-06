using ForExperiments.ViewModels.Base;
using System;

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

        // Date time now
        private string _TimeNow = $"Последний запуск программы - {DateTime.Now}";

        public string TimeNow { get => _TimeNow; set => Set(ref _TimeNow, value); }

        #endregion Заголовок Окна
    }
}