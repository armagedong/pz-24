namespace salon;

public class UserReg
{
    public string Login { get; set; }
    public string Password { get; set; }
    public string FIO { get; set; }

    public List<ServicesEnt> RecordServices { get; set; } = [];

    public UserReg(string login, string password, string fio)
    {
        Login = login;
        Password = password;
        FIO = fio;
    }
}