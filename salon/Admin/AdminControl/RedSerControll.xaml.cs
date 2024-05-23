using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;

namespace salon.Admin.AdminControl;

public partial class RedSerControll : UserControl
{
    public event EventHandler<List<ServicesEnt>> ItemAdded;
    public RedSerControll()
    {
        InitializeComponent();
        var service = Serialize.ShowService();
        ServiceDataGrid.ItemsSource = service;
    }

    private void Add_OnClick(object sender, RoutedEventArgs e)
    {
        
        AddServiceWindow addServiceWindow = new AddServiceWindow();
        addServiceWindow.ItemAdded += OnItemAdded;
        addServiceWindow.Show();
    }
    private void OnItemAdded(object sender, List<ServicesEnt> newItem)
    {
        var employers = newItem;
        ServiceDataGrid.ItemsSource = employers;
    }

    private void Redact_OnClick(object sender, RoutedEventArgs e)
    {
        var a = ServiceDataGrid.SelectedIndex;
        if (a >= 0)
        {
            Serialize.RemoveService(a);
            
        }

        ServiceDataGrid.ItemsSource = Serialize.ShowService();
    }
}