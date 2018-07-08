using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataStructuresAndLINQ;

namespace AspNetMvcCore.Services
{
    public class PostService
    {
        private readonly List<Models.User> _users = Mapper.Map<List<User>, List<Models.User>>(Startup.Users);

        public List<Models.Post> PostResult(string title)
            => _users.SelectMany(user => user.Posts, (user, post) => new { user, post })
                .Where(@t => @t.post.Title == title).Select(@t => (@t.post)).ToList();

        public List<Models.Post> PostResultId(int id)
            => _users.SelectMany(user => user.Posts, (user, post) => new { user, post })
                .Where(@t => @t.post.Id == id).Select(@t => (@t.post)).ToList();
    }
}
