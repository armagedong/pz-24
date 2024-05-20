using System.Net.Mime;
using System.Text.Json;
using System.Text.Json;
using Newtonsoft.Json;
using System.Windows.Controls;
using Newtonsoft.Json;
using System.IO;
using System.Security.Policy;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Media.Animation;
using System.Xml;
using Formatting = Newtonsoft.Json.Formatting;

namespace salon;
public static class Serialize
{
    public static bool Save(TextBox login, PasswordBox password)
    {
        bool check = false;
        Entity UserLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json"));
        foreach (UserReg user in UserLog.Users)
        {
            if (login.Text == user.Login && password.Password == user.Password)
            {
                check = true;
            }
            else if(login.Text == "admin" && password.Password == "admin")
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                break;
            }
        }

        return check;
    }

    public static void Registration(TextBox login, PasswordBox password)
    { 

        
        Entity UserLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json"));
        
        if (login.Text != "admin" && password.Password != "admin")
        {
            UserLog.Users.Add(new UserReg(login.Text, password.Password));
            string reg =  JsonConvert.SerializeObject(UserLog , Formatting.Indented);
            File.WriteAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json", reg);
        }
    }

    public static void RegEmployers(TextBox name, TextBox age, TextBox possition)
    {
        Entity EmployerLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json"));
        EmployerLog.Employers.Add( new Employers(name.Text, age.Text, possition.Text));
        
        string reg =  JsonConvert.SerializeObject(EmployerLog , Formatting.Indented); 
        File.WriteAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json", reg);
        
    }
    public static List<Employers> ShowEmployers()
    {
        Entity EmployerLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json"));

        List<Employers> employersList = new List<Employers>();

        foreach (Employers i in EmployerLog.Employers)
        {
            employersList.Add(i);
        }

        return employersList;
    }
}