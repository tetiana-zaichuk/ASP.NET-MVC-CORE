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
        private static List<User> users;

        public UserService()
        {
            users = Queries.BindEntities();
        }

        public List<User> GetAll()
        {
            return users;
        }

        public List<User> GetUser(string name)
        {
            return users.Where(n=>n.Name==name).ToList();
        }
    }
}
