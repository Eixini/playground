using System.Windows;

namespace WorkingWithText;


public partial class MainWindow : Window {
    public MainWindow() {
        InitializeComponent();

        WorkingWithTextFrame.Content = new TextAnalysisPage();
    }
}