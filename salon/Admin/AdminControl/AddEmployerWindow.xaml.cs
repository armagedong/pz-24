using System.Windows;

namespace salon.Admin.AdminControl;

public partial class AddEmployerWindow : Window
{
    public event EventHandler<List<Employers>> ItemAdded;
    public AddEmployerWindow()
    {
        InitializeComponent();
    }

    private void Add_OnClick(object sender, RoutedEventArgs e)
    {
        Serialize.RegEmployers(name, age, possition);
        ItemAdded?.Invoke(this,  Serialize.ShowEmployers());
    }
}