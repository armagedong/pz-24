using System.Windows;

namespace salon.Admin.AdminControl;

public partial class AddEmployer : Window
{
    public AddEmployer()
    {
        InitializeComponent();
        
    }

    private void CreateEmployer_OnClick(object sender, RoutedEventArgs e)
    {
        Serialize.RegEmployers(name, age, possition);
    }
}