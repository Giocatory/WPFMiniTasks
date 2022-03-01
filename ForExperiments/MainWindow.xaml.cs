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
            if (login.Text == "" || password.Password == "")
            {
                MessageBox.Show("Не корректный ввод логина/пароля");
                return;
            }
            if (login.Text.ToLower() == "admin" && password.Password.ToLower() == "admin")
            {
                AppsList taskWindow = new AppsList();
                taskWindow.ViewModel = $"User: {login.Text}\nPass: {password.Password}\nДобро пожаловать! Выберите что-нибудь из списка приложений!";
                taskWindow.Show();
                taskWindow.ShowViewModel();
            }
            else
            {
                MessageBox.Show("База данных еще не подключена!");
            }
        }

        private void registration_Click(object sender, RoutedEventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.Show();
        }
    }
}