using System.Net.Mime;
using System.Text.Json;
using System.Text.Json;
using Newtonsoft.Json;
using System.Windows.Controls;
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
    public static void Save(TextBox login, PasswordBox password)
    {
        
        Entity UserLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json"));
        foreach (UserReg user in UserLog.Users)
        {
            if (login.Text == user.Login && password.Password == user.Password)
            {
                Window1 window1 = new Window1();
                window1.Show();
                window1.YouAcc.Content = user.FIO;
                break;
            }
            else if(login.Text == "admin" && password.Password == "admin")
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                break;
            }
        }

    }

    public static void Registration(TextBox login, PasswordBox password , TextBox fio)
    { 

        
        Entity UserLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json"));
        
        if (login.Text != "admin" && password.Password != "admin")
        {
            UserLog.Users.Add(new UserReg(login.Text, password.Password, fio.Text));
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
        var EmployerLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json"));

        var employersList = new List<Employers>();

        foreach (var i in EmployerLog.Employers)
        {
            employersList.Add(i);
        }
        return employersList;
    }
    public static List<ServicesEnt> ShowService()
    {
        var serviceLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json"));

        var serviceList = new List<ServicesEnt>();

        foreach (var i in serviceLog._Services)
        {
            serviceList.Add(i);
        }
        return serviceList;
    }
    public static void RemoveEmployers(int i)
    {
        Entity EmployerLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json"));
        EmployerLog.Employers.Remove(EmployerLog.Employers[i]);
        
        string reg =  JsonConvert.SerializeObject(EmployerLog , Formatting.Indented); 
        File.WriteAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json", reg);
    }
    public static void RemoveService(int i)
    {
        Entity ServiceLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json"));
        File.Delete(ServiceLog._Services[i].Img);
        ServiceLog._Services.Remove(ServiceLog._Services[i]);

        
        
        string reg =  JsonConvert.SerializeObject(ServiceLog , Formatting.Indented); 
        File.WriteAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json", reg);
    }

    public static void AddService(string img, string name, string cost, string duration, string description)
    {
        Entity ServiceLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json"));
        ServiceLog._Services.Add(new ServicesEnt(img, name, cost, duration,description));
        
        string reg =  JsonConvert.SerializeObject(ServiceLog , Formatting.Indented); 
        File.WriteAllText(@"C:\Users\arman\source\repos\salon\salon\FileSystem\Ser.json", reg);
    }
}