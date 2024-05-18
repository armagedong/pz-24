using System.Net.Mime;
using System.Text.Json;
using System.Text.Json;
using Newtonsoft.Json;
using System.Windows.Controls;
using Newtonsoft.Json;
using System.IO;
using System.Windows;
using System.Windows.Media.Animation;
using System.Xml;

namespace salon;
public static class Serialize
{
    public static void Save(TextBox login, PasswordBox password)
    {
        List<UserReg> UserLog = JsonConvert.DeserializeObject<List<UserReg>>(File.ReadAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json"));
        foreach (UserReg user in UserLog)
        {
            if (login.Text == user.Login && password.Password == user.Password)
            {
                Window1 window1 = new Window1();
                window1.YouAcc.Content = user.FIO;
                window1.Show();
                break;
            }

        }
    }
        
}