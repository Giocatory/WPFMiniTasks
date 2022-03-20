using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace ForExperiments.Views.Questions
{
    /// <summary>
    /// Логика взаимодействия для Testing.xaml
    /// </summary>
    public partial class Testing : Window
    {
        public Testing()
        {
            InitializeComponent();
            this.DataContext = new ForExperiments.ViewModels.TestingWindowViewModel();
            this.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), @$"{Environment.CurrentDirectory}\img\gray.png")));
        }

        private void JuniorButton_Click(object sender, RoutedEventArgs e)
        {
            JuniorPage.Focus();
            this.Title = "Тест для Junior .NET";
        }

        private void MiddleButton_Click(object sender, RoutedEventArgs e)
        {
            MiddlePage.Focus();
            this.Title = "Тест для Middle .NET";
        }

        private void SeniorButton_Click(object sender, RoutedEventArgs e)
        {
            SeniorPage.Focus();
            this.Title = "Тест для Senior .NET";
        }
    }
}