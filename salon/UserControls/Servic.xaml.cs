using System.Windows;
using System.Windows.Controls;

namespace salon;

public partial class Servic : UserControl
{
    public Servic()
    {
        InitializeComponent();
    }

    private void Record_service(object sender, RoutedEventArgs e)
    {
        Serialize.UserAddService(ServiceImage.Source.ToString(), ServiceNameText.Text, ServicePriceText.Text, "10 часов", ServiceDescriptionText.Text, ServiceTime.Text);
        Console.WriteLine(ServiceImage.Source);
    }
}