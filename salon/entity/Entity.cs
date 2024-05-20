using System.Windows.Documents;
using salon.UserControls;

namespace salon;

public class Entity
{
    public List<UserReg> Users { get; set; }
    public List<Employers> Employers { get; set; }
    public List<Appointment> Appointment { get; set; }
    public List<Services> Services { get; set; }
    
    

    public Entity(List<UserReg> users, List<Employers> employers, List<Appointment> appointment,List<Services> services)
    {
        Users = users;
        Employers = employers;
        Appointment = appointment;
        Services = services;
    }
    
}