using System;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace ForExperiments
{
    /// <summary>
    /// Логика взаимодействия для AppsList.xaml
    /// </summary>
    public partial class AppsList : Window
    {
        public string? ViewModel { get; set; }

        public AppsList()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), @$"{Environment.CurrentDirectory}\cofee.jpg")));
        }

        public void ShowViewModel() => MessageBox.Show(ViewModel);
    }
}