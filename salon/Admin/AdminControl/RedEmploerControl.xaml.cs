using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace salon.Admin.AdminControl;

public partial class RedEmploerControl : UserControl
{
    public event EventHandler<List<Employers>> ItemAdded;
    
    public RedEmploerControl()
    {
        InitializeComponent();
        var employers = Serialize.ShowEmployers();
        EmployerDataGrid.ItemsSource = employers;
    }

    private void AddEmploer(object sender, RoutedEventArgs e)
    {
        var addEmploer = new AddEmployerWindow();
        addEmploer.ItemAdded += OnItemAdded;
        addEmploer.Show();
    }
    private void OnItemAdded(object sender, List<Employers> newItem)
    {
        var employers = newItem;
        EmployerDataGrid.ItemsSource = employers;
    }

    private void Remove_OnClick(object sender, RoutedEventArgs e)
    {
        var a = EmployerDataGrid.SelectedIndex;
        if (a >= 0)
        {
            Serialize.RemoveEmployers(a);
        }

        EmployerDataGrid.ItemsSource = Serialize.ShowEmployers();


    }
}