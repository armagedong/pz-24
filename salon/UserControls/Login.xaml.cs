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
            if (Serialize.Save(LogIn, Password) == 1)
            {
                UserWindow userWindow = new UserWindow();
                userWindow.YouAcc.Content = Serialize.FIO;
                userWindow.Show();
                var myWindow = Window.GetWindow(this);
                myWindow?.Close();
            }
            else if (Serialize.Save(LogIn, Password) == 2)
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                var myWindow = Window.GetWindow(this);
                myWindow?.Close();
            }
            else
            {
                MessageBox.Show("Непрвавльно введен пароль или логин");
            }
            
        }
        else
        {
            MessageBox.Show("Введите пароль и логин");
        }
        
    }
}