using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ForExperiments.Models.DBSource
{
    internal class User : INotifyPropertyChanged
    {
        private int id;
        private string login;
        private string pass;
        private string mail;
        private string telegramm;
        private string mobile;

        public int Id
        {
            get => id;
            set
            {
                id = value;
            }
        }

        public string Login
        {
            get => login;
            set
            {
                login = value;
                OnPropertyChanged("Login");
            }
        }

        public string Pass
        {
            get => pass;
            set
            {
                pass = value;
                OnPropertyChanged("Pass");
            }
        }

        public string Mail
        {
            get => mail;
            set
            {
                mail = value;
                OnPropertyChanged("Mail");
            }
        }

        public string Telegramm
        {
            get => telegramm;
            set
            {
                telegramm = value;
                OnPropertyChanged("Telegramm");
            }
        }

        public string Mobile
        {
            get => mobile;
            set
            {
                mobile = value;
                OnPropertyChanged("Mobile");
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}