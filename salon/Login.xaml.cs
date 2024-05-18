using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace salon;

public partial class Login : UserControl
{
    public Login()
    {
        InitializeComponent();
    }

    private void Reg_OnClick(object sender, RoutedEventArgs e)
    {
        RegistrtionWindow registrtionWindow = new RegistrtionWindow();
        registrtionWindow.Show();
    }

    private void Enter_OnClick(object sender, RoutedEventArgs e)
    {
        Serialize.Save(LogIn, Password);
    }
}