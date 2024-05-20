namespace salon;

public class UserReg
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string FIO { get; set; }
    public List<ServicesEnt> ServicesEnt { get; set; }

    public UserReg(string login, string password)
    {
        Login = login;
        Password = password;
    }
}