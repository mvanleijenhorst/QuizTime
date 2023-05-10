using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuizTime.UI.Views
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

        private void VragenOverzicht_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.ContentControl.Content = new VraagOverzichtUserControl(_mainWindow, null);   
        }
    }
}
