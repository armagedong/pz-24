using System.Formats.Tar;
using System.Runtime.InteropServices.JavaScript;

namespace Serial;

public class User
{
    public DateTime Cret { get; private set; }
    public string? Login { get; set; }

    public User()
    {
        Cret = DateTime.Now;
    }

    public User(string login)
    {
        Cret = DateTime.Now;
        Login = login;
    }
}