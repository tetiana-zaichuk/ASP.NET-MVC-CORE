using System.Linq;
using DataStructuresAndLINQ;

namespace AspNetMvcCore.Services
{
    public class UserService
    {
        public User GetUser(string name) => Startup.Users.Where(n=>n.Name==name).ToList().FirstOrDefault();
    }
}
