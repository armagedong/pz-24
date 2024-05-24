using System.IO;
using System.Windows;
using Microsoft.Win32;

namespace salon.Admin.AdminControl;

public partial class AddEmployerWindow : Window
{
    private byte[] newLocation;
    public event EventHandler<List<Employers>> ItemAdded;
    public AddEmployerWindow()
    {
        InitializeComponent();
    }

    private void Add_OnClick(object sender, RoutedEventArgs e)
    {
        Serialize.RegEmployers(name, age, possition, newLocation);
        ItemAdded?.Invoke(this,  Serialize.ShowEmployers());
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
}