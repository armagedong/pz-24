using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace salon;

public class ServicesEnt
{
    public byte[] Img { get; set; }
    public string Name { get; set; }
    public string Cost { get; set; }
    public string Duration { get; set; }
    public string Description { get; set; }
    
    public string Time { get; set; }
    public bool complete { get; set; } = false;

    public ServicesEnt(byte[] img, string name, string cost, string duration, string description)
    {
        Img = img;
        Name = name;
        Cost = cost;
        Duration = duration;
        Description = description;
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    protected bool SetField<T>(ref T field, T value, [CallerMemberName] string? propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value)) return false;
        field = value;
        OnPropertyChanged(propertyName);
        return true;
    }
}