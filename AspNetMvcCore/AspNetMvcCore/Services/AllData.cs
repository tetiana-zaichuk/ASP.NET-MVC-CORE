using System.Collections.Generic;
using DataStructuresAndLINQ;

namespace AspNetMvcCore.Services
{
    public class AllData
    {
        public List<User> GetAll() => Startup.Users;
    }
}
