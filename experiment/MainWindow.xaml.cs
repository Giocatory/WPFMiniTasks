using System.Windows;

namespace experiment
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

        private void button_Click(object sender, RoutedEventArgs e)
        {
            dateText.Text = calendar.SelectedDate.ToString().Split(" ")[0];
        }
    }
}
