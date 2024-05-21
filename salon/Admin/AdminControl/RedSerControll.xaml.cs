using System.IO;
using System.Net;
using System.Windows;
using System.Windows.Controls;

namespace salon.Admin.AdminControl;

public partial class RedSerControll : UserControl
{
    public RedSerControll()
    {
        InitializeComponent();
        var service = Serialize.ShowService();
        ServiceDataGrid.ItemsSource = service;
    }

    private void Add_OnClick(object sender, RoutedEventArgs e)
    {
        
        AddServiceWindow addServiceWindow = new AddServiceWindow();
        addServiceWindow.Show();
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