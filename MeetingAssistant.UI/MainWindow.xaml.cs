using System.Windows;
using MeetingAssistant.UI.ViewModels;

namespace MeetingAssistant.UI;

public partial class MainWindow : Window
{
    public MainWindow(MainWindowViewModel vm)
    {
        InitializeComponent();

        DataContext = vm;
    }
}