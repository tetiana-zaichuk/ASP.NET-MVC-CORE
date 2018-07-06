using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructuresAndLINQ;

namespace AspNetMvcCore.Services
{
    public class PostService
    {
        private static List<Post> posts;

        public PostService()
        {
            posts = Queries.GetPosts();
        }

        public List<Post> GetPost(string name)
        {
            return posts.Where(n => n.Title == name).ToList();
        }
    }
}
