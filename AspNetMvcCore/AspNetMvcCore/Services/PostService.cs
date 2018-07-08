using System.Collections.Generic;
using System.Linq;
using DataStructuresAndLINQ;

namespace AspNetMvcCore.Services
{
    public class PostService
    {
        public List<Post> PostResult(string title)
            => Startup.Users.SelectMany(user => user.Posts, (user, post) => new { user, post })
                .Where(@t => @t.post.Title == title).Select(@t => (@t.post)).ToList();

        public List<Post> PostResultId(int id)
            => Startup.Users.SelectMany(user => user.Posts, (user, post) => new { user, post })
                .Where(@t => @t.post.Id == id).Select(@t => (@t.post)).ToList();
    }
}
