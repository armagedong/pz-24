namespace salon;

public class Employers
{
    public string Name { get; set; }
    public string Age { get; set; }
    public string Possition { get; set; }

    public Employers(string name, string age, string possition)
    {
        Name = name;
        Age = age;
        Possition = possition;
    }
}