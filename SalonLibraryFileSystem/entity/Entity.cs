using System.Windows.Documents;

namespace salon;

public class Entity
{
    public List<UserReg> Users { get; set; }
    public List<Employers> Employers { get; set; }
    public List<ServicesEnt> _Services { get; set; }
    
    

    public Entity(List<UserReg> users, List<Employers> employers, List<ServicesEnt> services)
    {
        Users = users;
        Employers = employers;
        _Services = services;
    }
    
}