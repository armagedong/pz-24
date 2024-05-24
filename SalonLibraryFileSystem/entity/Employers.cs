namespace salon;

public class Employers
{
    public byte[] Img { get; set; }
    public string Name { get; set; }
    public string Age { get; set; }
    public string Possition { get; set; }

    public Employers(string name, string age, string possition, byte[] img)
    {
        Img = img;
        Name = name;
        Age = age;
        Possition = possition;
    }
}