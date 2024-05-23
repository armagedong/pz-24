using System.Net;
using System.Windows;
using System.IO;
using Microsoft.Win32;

namespace salon.Admin.AdminControl;

public partial class AddServiceWindow : Window
{
    static OpenFileDialog openFileDialog = new OpenFileDialog();
    private string onlyFileName;
    public string newLocation;
    public event EventHandler<List<ServicesEnt>> ItemAdded;
    public AddServiceWindow()
    {
        InitializeComponent();
    }

    private void AddImg_OnClick(object sender, RoutedEventArgs e)
    {
        openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
        if (openFileDialog.ShowDialog() == true)
        {
            onlyFileName = System.IO.Path.GetFileName(openFileDialog.FileName);
            newLocation = @"C:\Users\arman\source\repos\salon\salon\image" + "\\" + onlyFileName; 
            
        }
    }

    public void  Add()
    {
        File.Copy( openFileDialog.FileName, newLocation, true);
    }

    private void AddService(object sender, RoutedEventArgs e)
    {
        Serialize.AddService(newLocation, name.Text, сost.Text, duration.Text, description.Text);
        if (newLocation != null)
        {
            Add();
        }
        ItemAdded?.Invoke(this,  Serialize.ShowService());
    }
}