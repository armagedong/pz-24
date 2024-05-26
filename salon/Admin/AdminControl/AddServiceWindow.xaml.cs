using System.Net;
using System.Windows;
using System.IO;
using Microsoft.Win32;

namespace salon.Admin.AdminControl;

public partial class AddServiceWindow : Window
{
    static OpenFileDialog openFileDialog = new OpenFileDialog();
    private string onlyFileName;
    public byte[] newLocation;
    public event EventHandler<List<ServicesEnt>> ItemAdded;
    public AddServiceWindow()
    {
        InitializeComponent();
    }

    private void AddImg_OnClick(object sender, RoutedEventArgs e)
    {
       
        OpenFileDialog openFileDialog = new OpenFileDialog();
        openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png|All files (*.*)|*.*";
        
        
        if (openFileDialog.ShowDialog() == true)
        {
            string selectedImagePath = openFileDialog.FileName;
            newLocation = File.ReadAllBytes(selectedImagePath);
        }
    }

   

    private void AddService(object sender, RoutedEventArgs e)
    {
        Serialize.AddService(newLocation, name.Text, сost.Text, duration.Text, description.Text);
        ItemAdded?.Invoke(this,  Serialize.ShowService());
        
    }
}