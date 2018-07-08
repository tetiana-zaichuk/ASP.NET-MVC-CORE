using System.Collections.Generic;
using System.Linq;
using DataStructuresAndLINQ;

namespace AspNetMvcCore.Services
{
    public class TodoService
    {
        public List<Todo> GetTodo(string name)
            => Startup.Users.SelectMany(user => user.Todos, (user, todo) => new {user, todo})
                .Where(@t => @t.todo.Name == name).Select(@t => (@t.todo)).ToList();
    }
}
