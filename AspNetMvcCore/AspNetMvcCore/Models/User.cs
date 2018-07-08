using System;
using System.Collections.Generic;

namespace AspNetMvcCore.Models
{
    public class User
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }
        public string Email { get; set; }
        public List<Post> Posts = new List<Post>();
        public List<Todo> Todos = new List<Todo>();
    }
}
