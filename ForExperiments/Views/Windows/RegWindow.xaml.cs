using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace ForExperiments
{
    /// <summary>
    /// Логика взаимодействия для RegWindow.xaml
    /// </summary>
    public partial class RegWindow : Window
    {
        public RegWindow()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), @$"{Environment.CurrentDirectory}\mainBg.jpg")));
        }

        private void aboutProgram(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Программа предназначена для группировки мини приложений, созданных в процессе обучения WPF. Регистрироваться не обязательно, можно просто зайти, как гость!");
        }

        private void CloseWindow(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void NextTabIndex(object sender, RoutedEventArgs e)
        {
            if (Login.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Не корректный ввод"); return;
            }
            About.Focus();
            RegProgress.Value = 100;
        }

        private void PrewTabIndex(object sender, RoutedEventArgs e)
        {
            LogPass.Focus();
            RegProgress.Value = 50;
        }

        // hover in button
        private void HoverInButton(object sender, MouseEventArgs e)
        {
            ButtonNext.Foreground = Brushes.Blue;
            ButtonNext.Background = Brushes.Yellow;
        }

        private void HoverOutButton(object sender, MouseEventArgs e)
        {
            ButtonNext.Foreground = Brushes.Yellow;
            ButtonNext.Background = Brushes.Blue;
        }

        private void HoverInPrewButton(object sender, MouseEventArgs e)
        {
            ButtonPrew.Foreground = Brushes.Blue;
            ButtonPrew.Background = Brushes.Yellow;
        }

        private void HoverOutPrewButton(object sender, MouseEventArgs e)
        {
            ButtonPrew.Foreground = Brushes.Yellow;
            ButtonPrew.Background = Brushes.Blue;
        }

        private void HoverInFinButton(object sender, MouseEventArgs e)
        {
            ButtonFinall.Foreground = Brushes.Blue;
            ButtonFinall.Background = Brushes.Yellow;
        }

        private void HoverOutFinButton(object sender, MouseEventArgs e)
        {
            ButtonFinall.Foreground = Brushes.Yellow;
            ButtonFinall.Background = Brushes.Blue;
        }
    }
}