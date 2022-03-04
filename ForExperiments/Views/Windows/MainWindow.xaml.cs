using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace ForExperiments
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), @$"{Environment.CurrentDirectory}\welcome.jpg")));
        }

        private void signIn_Click(object sender, RoutedEventArgs e)
        {
            AppsList taskWindow = new();
            if (GuestLogin.IsChecked == true)
            {
                taskWindow.ViewModel = $"Добро пожаловать, Guest!\nВыберите что-нибудь из списка приложений!";
                taskWindow.Show();
                taskWindow.Owner = this;
                taskWindow.ShowViewModel();
                return;
            }
            if (login.Text == "" || password.Password == "")
            {
                MessageBox.Show("Не корректный ввод логина/пароля");
                return;
            }
            if (login.Text.ToLower() == "admin" && password.Password.ToLower() == "admin")
            {
                taskWindow.ViewModel = $"Добро пожаловать, {login.Text}!\nВыберите что-нибудь из списка приложений!";
                taskWindow.Show();
                taskWindow.Owner = this;
                taskWindow.ShowViewModel();
            }
            else
            {
                MessageBox.Show("База данных еще не подключена!");
            }
        }

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new();
            regWindow.Show();
            regWindow.Owner = this;
        }

        // button hover animation
        private void signIn_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            signIn.Background = Brushes.Yellow;
            signIn.Foreground = Brushes.Blue;
        }

        private void signIn_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            signIn.Background = Brushes.Blue;
            signIn.Foreground = Brushes.Yellow;
        }

        private void reg_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            registration.Background = Brushes.Yellow;
            registration.Foreground = Brushes.Blue;
        }

        private void reg_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            registration.Background = Brushes.Blue;
            registration.Foreground = Brushes.Yellow;
        }
    }
}