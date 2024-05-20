namespace salon;

public class AppointmenEnt
{
    public string Img { get; set; }
    public string Name { get; set; }
    public string Cost { get; set; }
    public string Duration { get; set; }
    public string Description { get; set; }

    public AppointmenEnt(string img, string name, string cost, string duration, string description)
    {
        Img = img;
        Name = name;
        Cost = cost;
        Duration = duration;
        Description = description;
    }
}