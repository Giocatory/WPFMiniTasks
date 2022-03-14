using MaterialDesignThemes.Wpf;
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
        public AppsList()
        {
            InitializeComponent();
            this.Background = new ImageBrush(new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), @$"{Environment.CurrentDirectory}\img\cofee.jpg")));

            ShadowAssist.SetShadowDepth(this, ShadowDepth.Depth0); // для подключения Material Design

            #region не прерывный показ текущего времени (внизу окна)

            // не прерывный показ текущего времени (внизу окна)
            var timer = new System.Windows.Threading.DispatcherTimer
            {
                Interval = new TimeSpan(0, 0, 1),
                IsEnabled = true
            };
            timer.Tick += (o, t) => { TimeShow.Text = DateTime.Now.ToString(); };
            timer.Start();

            #endregion не прерывный показ текущего времени (внизу окна)
        }
    }
}