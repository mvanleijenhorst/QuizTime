using QuizTime.Domain;
using System.Windows;
using System.Windows.Controls;

namespace QuizTime.UI.Views
{
    /// <summary>
    /// Interaction logic for VraagOverzichtUserControl.xaml
    /// </summary>
    public partial class VraagOverzichtUserControl : UserControl
    {
        private readonly MainWindow _mainWindow;
        private readonly Quiz _quiz;

        public VraagOverzichtUserControl(MainWindow mainWindow, Quiz? quiz)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _quiz = quiz ?? new Quiz();

            QuizNaam.Text = _quiz.Name;
            Datagrid.ItemsSource = _quiz.Vragen;
        }

        private void NieuweVraag_Click(object sender, RoutedEventArgs e)
        {
            _quiz.Name = QuizNaam.Text;
            _mainWindow.ContentControl.Content = new VraagEditUserControl(_mainWindow, _quiz);
        }

        private void QuizOpslaan_Click(object sender, RoutedEventArgs e)
        {
            _quiz.Name = QuizNaam.Text;
            _mainWindow.ContentControl.Content = new StartUserControl(_mainWindow);
        }

        private bool ValideerQuiz()
        {
            return _quiz.HeeftVoldoendeVragen();
        }
    }
}
