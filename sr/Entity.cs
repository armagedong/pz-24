namespace sr;

public class Entity
{
    public List<Admin> Admin { get; set; }
    public List<User> User { get; set; }

   public Entity(List<Admin> admin, List<User> user)
   {
       Admin = admin;
       User = user;
   }
}