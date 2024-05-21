using System.Windows;

namespace salon;

public partial class RegistrationWindow : Window
{
    public RegistrationWindow()
    {   
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        if (Check.IsChecked == true && Log_in.Text != "" && Password.Password != "" && PasswordCheck.Password != "")
        {
            
            Serialize.Registration(Log_in, Password, FIO);
            Close();
        }
        else
        {
            MessageBox.Show("Заполните все необходимые данный и подтвердите условия пользования");
        }
    }

    private void ButtonClose_OnClick(object sender, RoutedEventArgs e)
    {
        Close();
    }
}