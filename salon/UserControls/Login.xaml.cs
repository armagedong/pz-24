using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml;

namespace salon;

public partial class Login : UserControl
{
    public Login()
    {
        InitializeComponent();
    }

    private void Reg_OnClick(object sender, RoutedEventArgs e)
    {
        var registrtionWindow = new RegistrationWindow();
        registrtionWindow.Show();
    }

    private void Enter_OnClick(object sender, RoutedEventArgs e)
    {
        if (LogIn.Text != "" && Password.Password != "")
        {
            if (Serialize.Save(LogIn, Password))
            {
                Window1 window1 = new Window1();
                window1.Show();
                var myWindow = Window.GetWindow(this);
                myWindow?.Close();
            }
            else
            {
                MessageBox.Show("Такого пользователя не существует");
            }
        }
        else
        {
            MessageBox.Show("Введите пароль и логин");
        }
        
    }
}