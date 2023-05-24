using QuizTime.Wpf.Views.QuizManagement;
using System.Windows;
using System.Windows.Controls;

namespace QuizTime.Wpf.Views
{
    /// <summary>
    /// Interaction logic for StartUserControl.xaml
    /// </summary>
    public partial class StartUserControl : UserControl
    {
        private readonly MainWindow _mainWindow;

        public StartUserControl(MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
        }

        private void ManageQuiz_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.SwitchControl(new QuizListUserControl(_mainWindow));
        }

        private void StartQuiz_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckQuiz_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
