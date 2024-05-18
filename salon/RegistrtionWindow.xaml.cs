using System.Windows;

namespace salon;

public partial class RegistrtionWindow : Window
{
    

    public RegistrtionWindow()
    {
        InitializeComponent();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        if (Check.IsChecked == true)
        {
            MessageBox.Show("Вы зарегистрировались");
            Close();
        }
        else
        {
            MessageBox.Show("Поддетвердите условия пользваониея");
        }
    }
}