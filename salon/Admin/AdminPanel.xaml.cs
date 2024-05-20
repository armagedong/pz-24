using System.Windows;
using salon.Admin.AdminControl;

namespace salon;

public partial class AdminPanel : Window
{
    public AdminPanel()
    {
        InitializeComponent();
    }

    private void AddEmployer_OnClick(object sender, RoutedEventArgs e)
    {
        AddEmployer addEmployer = new AddEmployer();
        addEmployer.Show();
    }
}