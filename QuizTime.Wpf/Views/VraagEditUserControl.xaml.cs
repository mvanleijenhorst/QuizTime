using QuizTime.Domain;
using System.Windows;
using System.Windows.Controls;

namespace QuizTime.UI.Views
{
    /// <summary>
    /// Interaction logic for VraagEditUserControl.xaml
    /// </summary>
    public partial class VraagEditUserControl : UserControl
    {
        private readonly MainWindow _mainWindow;
        private readonly Quiz _quiz;

        public VraagEditUserControl(MainWindow mainWindow, Quiz quiz)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            _quiz = quiz;
        }

        private void OpslaanVraag_Click(object sender, RoutedEventArgs e)
        {
            if (ValideerVraag())
            {
                Vraag vraag = new Vraag()
                {
                    Text = VraagText.Text
                };
                _quiz.Vragen.Add(vraag);

                _mainWindow.ContentControl.Content = new VraagOverzichtUserControl(_mainWindow, _quiz);
            }
        }

        private void AnnuleerVraag_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.ContentControl.Content = new VraagOverzichtUserControl(_mainWindow, _quiz);
        }

        private bool ValideerVraag()
        {
            return true;
        }

    }
}
