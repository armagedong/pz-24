using System.Collections.ObjectModel;
using System.DirectoryServices.ActiveDirectory;
using System.Windows;
using System.Windows.Input;

namespace salon.view;

public class MainViewModel
{
    public ObservableCollection<ServicesEnt> Persons { get; set; } = new ObservableCollection<ServicesEnt>();
    public ServicesEnt SelectedPerson { get; set; }

    public ICommand AddRowCommand { get; set; }
    public ICommand GetRowInfoCommand { get; set; }

    public MainViewModel()
    {
        AddRowCommand = new VIewModel(AddRow);
        GetRowInfoCommand = new VIewModel(GetRowInfo);
    }

    private void AddRow()
    {
        foreach (var i in Serialize.ShowUserRecords())
        {
            Persons.Add(i);
        }
    }

    private void GetRowInfo()
    {
        if (SelectedPerson != null)
            MessageBox.Show($"Имя: {SelectedPerson.Cost}\nФамилия: {SelectedPerson.complete}\nВозраст: {SelectedPerson.Name}");
    }
}