using System.Collections.Generic;
using System.Linq;
using DataStructuresAndLINQ;

namespace AspNetMvcCore.Services
{
    public class PostService
    {
        public List<Post> GetPost(string name)
            => Startup.Users.SelectMany(user => user.Posts, (user, post) => new { user, post })
                .Where(@t => @t.post.Title == name).Select(@t => (@t.post)).ToList();
    }
}
