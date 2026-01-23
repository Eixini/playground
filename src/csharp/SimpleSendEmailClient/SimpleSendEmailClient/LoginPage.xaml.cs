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

namespace SimpleSendEmailClient;


public partial class LoginPage : Page
{
    public LoginPage()
    {
        InitializeComponent();
    }

    private void LoginButton_Click(object sender, RoutedEventArgs e) {

        string login = LoginField.Text;
        string password = PasswordField.Password;

        if (login != null && password != null) {
            MainWindow parent = SingletonObject.NavigationParent as MainWindow;
            parent.MainFrame.Content = new SendEmailPage(login, password);
        }

    }
}
