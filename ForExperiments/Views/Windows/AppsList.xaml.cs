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
            this.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), @$"{Environment.CurrentDirectory}\img\cofee.jpg")));

            // не прерывный показ текущего времени
            var timer = new System.Windows.Threading.DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 1),
                IsEnabled = true
            };
            timer.Tick += (o, t) => { TimeShow.Text = DateTime.Now.ToString(); };
            timer.Start();
        }

        public void ShowViewModel()
        {
            MessageBox.Show(ViewModel);
        }
    }
}