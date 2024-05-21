using System.Windows;
using salon.Admin.AdminControl;

namespace salon;

public partial class AdminPanel : Window
{

    public AdminPanel()
    {
        InitializeComponent();
    }

    private void RedactEmployer(object sender, RoutedEventArgs e)
    {
        Content.Children.Clear();
        var employer = new RedEmploerControl();
        Content.Children.Add(employer);
    }

    public void Actions(object sender, EventArgs e)
    {
        Content.Children.Clear();
        var employer = new RedEmploerControl();
        Content.Children.Add(employer);
    }
    private void RemoveEmployer_OnClick(object sender, RoutedEventArgs e)
    {
        
    }
    
}