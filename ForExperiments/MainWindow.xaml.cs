using System.Windows;

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
        }

        private void signIn_Click(object sender, RoutedEventArgs e)
        {
            AppsList taskWindow = new();

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

        }
    }
}