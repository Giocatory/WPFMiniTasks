/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;*/
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
            if (login.Text == "" || login.Text.ToLower() == "login")
            {
                MessageBox.Show("Не корректный ввод логина/пароля");
            }
            else if (password.Text == "" || password.Text.ToLower() == "password")
            {
                MessageBox.Show("Не корректный ввод логина/пароля");
            }
        }
    }
}
