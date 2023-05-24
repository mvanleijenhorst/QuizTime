using QuizTime.Domain;
using QuizTime.Infra.JsonFile;
using QuizTime.Wpf;
using QuizTime.Wpf.Views.QuizManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace QuizTime.Wpf.Views.QuizManagement;

/// <summary>
/// Interaction logic for QuizListUserControl.xaml
/// </summary>
public partial class QuizListUserControl : UserControl
{
    private readonly IQuizRepository _quizRepository;
    private readonly MainWindow _mainWindow;

    public QuizListUserControl(MainWindow mainWindow)
    {
        InitializeComponent();
        _mainWindow = mainWindow;
        _quizRepository = null; // moet de implementatie zijn van de interface;

        DataGrid.ItemsSource = _quizRepository.GetAll();
    }

    private void ButtonBack_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        _mainWindow.SwitchControl(new StartUserControl(_mainWindow));
    }

    private void ButtonCreate_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }

    private void ButtonEdit_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        var button = (Button)sender;
        var id = (Guid)button.Tag;

        throw new NotImplementedException();
    }

    private void ButtonDelete_Click(object sender, System.Windows.RoutedEventArgs e)
    {
        var button = (Button)sender;
        var id = (Guid)button.Tag;

        throw new NotImplementedException();
    }


}
