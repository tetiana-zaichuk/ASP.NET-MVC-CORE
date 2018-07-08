using System.Collections.Generic;
using AutoMapper;
using DataStructuresAndLINQ;

namespace AspNetMvcCore.Services
{
    public class AllData
    {
        public List<Models.User> GetAll() 
            => Mapper.Map<List<User>, List<Models.User>>(Startup.Users);
    }
}
