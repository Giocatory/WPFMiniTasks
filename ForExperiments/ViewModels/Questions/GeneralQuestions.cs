using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace ForExperiments.Views.Questions
{
    /// <summary>
    /// Логика взаимодействия для GeneralQuestions.xaml
    /// </summary>
    public partial class GeneralQuestions : Window
    {
        public GeneralQuestions()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), @$"{Environment.CurrentDirectory}\img\cofee.jpg")));
            backTab.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), @$"{Environment.CurrentDirectory}\img\back.png")));
            backTabtwo.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), @$"{Environment.CurrentDirectory}\img\back.png")));
        }

        #region Tabs items

        private void BackTwoClick(object sender, RoutedEventArgs e)
        {
            MainTab.Focus();
        }

        private void FocusListTab(object sender, RoutedEventArgs e)
        {
            ListTab.Focus();
        }

        private void FocusAddTab(object sender, RoutedEventArgs e)
        {
            AddTab.Focus();
        }

        #endregion Tabs items
    }
}