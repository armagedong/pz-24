namespace sr;

public class User
{
    public string Name { get; set; }
    public string Age { get; set; }

    public User(string name, string age)
    {
        Name = name;
        Age = age;
    }
}