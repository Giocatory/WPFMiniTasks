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
            MessageBox.Show("You click to button!");
        }

        private void Window_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            this.Title = e.GetPosition(this).ToString();
        }
    }
}
