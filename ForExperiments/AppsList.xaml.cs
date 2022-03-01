using System.Windows;

namespace ForExperiments
{
    /// <summary>
    /// Логика взаимодействия для AppsList.xaml
    /// </summary>
    public partial class AppsList : Window
    {
        public string ViewModel { get; set; }

        public AppsList()
        {
            InitializeComponent();
        }

        public void ShowViewModel() => MessageBox.Show(ViewModel);
    }
}