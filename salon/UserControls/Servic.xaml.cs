using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace salon;

public partial class Servic : UserControl
{
    public Servic()
    {
        InitializeComponent();
    }

    private void Record_service(object sender, RoutedEventArgs e)
    {
        foreach (var i in Serialize.ShowService())
        {
            if (ServiceNameText.Text == i.Name)
            {
                Serialize.UserAddService(i.Img, i.Name, i.Cost, "10 часов", i.Description, ServiceTime.Text);
            }
        }
    }
}