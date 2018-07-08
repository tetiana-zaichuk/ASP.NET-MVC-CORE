using System.Collections.Generic;
using System.Linq;
using DataStructuresAndLINQ;

namespace AspNetMvcCore.Services
{
    public class UserService
    {
        public List<User> GetAll() => Startup.Users;
        
        public List<User> GetUser(string name) => Startup.Users.Where(n=>n.Name==name).ToList();
    }
}
