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
    public static string FIO;
    public static int Count = 0;
    static  string path = GetFilePath();
    
    public static string GetFilePath()
    {
        string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
        
        string relativePath = Path.Combine("FileSystem", "Ser.json");
        
        return Path.Combine(projectRoot, relativePath);
    }
    public static int Save(TextBox login, PasswordBox password)
    {
        int check = 0;
        Entity UserLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(path));
        foreach (UserReg user in UserLog.Users)
        {
            if (login.Text.Trim() == user.Login && password.Password.Trim() == user.Password)
            {
                if(login.Text == "admin" && password.Password == "admin")
                {
                    check = 2;
                    break;
                }
                else
                {
                    check = 1;
                    FIO = user.FIO;
                    break;
                }

                
            }
            Count++;
        }

        return check;

    }

    public static void Registration(TextBox login, PasswordBox password , TextBox fio)
    { 

        
        Entity UserLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(path));
        
        if (login.Text != "admin" && password.Password != "admin")
        {
            UserLog.Users.Add(new UserReg(login.Text, password.Password, fio.Text));
            string reg =  JsonConvert.SerializeObject(UserLog , Formatting.Indented);
            File.WriteAllText(path, reg);
        }
    }

    public static void RegEmployers(TextBox name, TextBox age, TextBox possition, byte[] img)
    {
        Entity EmployerLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(path));
        EmployerLog.Employers.Add( new Employers(name.Text, age.Text, possition.Text, img));
        
        string reg =  JsonConvert.SerializeObject(EmployerLog , Formatting.Indented); 
        File.WriteAllText(path, reg);
    }
    public static List<Employers> ShowEmployers()
    {
        var EmployerLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(path));

        var employersList = new List<Employers>();

        foreach (var i in EmployerLog.Employers)
        {
            employersList.Add(i);
        }
        return employersList;
    }
    public static List<ServicesEnt> ShowService()
    {
        var serviceLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(path));

        var serviceList = new List<ServicesEnt>();

        foreach (var i in serviceLog._Services)
        {
            serviceList.Add(i);
        }
        return serviceList;
    }
    public static List<UserReg> ShowUser()
    {
        var showLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(path));
        return showLog.Users;
    }
    
    public static List<ServicesEnt> ShowUserRecords()
    {
        var serviceLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(path));

        var serviceList = new List<ServicesEnt>();

        foreach (var i in serviceLog.Users[Count].RecordServices)
        {
            serviceList.Add(i);
        }
        return serviceList;
    }
    public static void RemoveEmployers(int i)
    {
        Entity EmployerLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(path));
        EmployerLog.Employers.Remove(EmployerLog.Employers[i]);
        
        string reg =  JsonConvert.SerializeObject(EmployerLog , Formatting.Indented); 
        File.WriteAllText(path, reg);
    }
    public static void RemoveService(int i)
    {
        Entity ServiceLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(path));
        ServiceLog._Services.Remove(ServiceLog._Services[i]);

        
        
        string reg =  JsonConvert.SerializeObject(ServiceLog , Formatting.Indented);
        File.WriteAllText(path, reg);
    }
    public static void completeServiceUser(int i, int j)
    {
        Entity ServiceLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(path));
        ServiceLog.Users[i].RecordServices[j].complete = true;

        
        
        string reg =  JsonConvert.SerializeObject(ServiceLog , Formatting.Indented);
        File.WriteAllText(path, reg);
    }

    public static void AddService(byte[] img, string name, string cost, string duration, string description)
    {
        Entity ServiceLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(path));
        ServiceLog._Services.Add(new ServicesEnt(img, name, cost, duration,description));
        
        string reg =  JsonConvert.SerializeObject(ServiceLog , Formatting.Indented); 
        File.WriteAllText(path, reg);
    }

    public static void UserAddService(byte[] img, string name, string cost, string duration, string description, string time)
    {
        Entity ServiceLog = JsonConvert.DeserializeObject<Entity>(File.ReadAllText(path));
        ServicesEnt servicesEnt = new ServicesEnt( img,  name,  cost,  duration,  description);
        servicesEnt.Time = time;
        ServiceLog.Users[Count].RecordServices.Add(servicesEnt);
        
        string reg =  JsonConvert.SerializeObject(ServiceLog , Formatting.Indented);
        File.WriteAllText(path, reg);
    }
    
}