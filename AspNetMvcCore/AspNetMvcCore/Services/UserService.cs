using System.Linq;
using AutoMapper;
using DataStructuresAndLINQ;

namespace AspNetMvcCore.Services
{
    public class UserService
    {
        public Models.User GetUser(string name) 
            => Mapper.Map<User, Models.User>(Startup.Users.Where(n=>n.Name==name)
                .ToList().FirstOrDefault());
    }
}
