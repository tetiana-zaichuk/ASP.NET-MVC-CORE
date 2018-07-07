using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvcCore.Models;
using DataStructuresAndLINQ;
using User = DataStructuresAndLINQ.User;

namespace AspNetMvcCore.Services
{
    public class UserService
    {
        public List<User> GetAll() => Startup.Users;
        
        public List<User> GetUser(string name)
        { 
            return Startup.Users.Where(n=>n.Name==name).ToList();
        }
    }
}
