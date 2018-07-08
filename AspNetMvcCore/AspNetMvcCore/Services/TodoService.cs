using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using DataStructuresAndLINQ;

namespace AspNetMvcCore.Services
{
    public class TodoService
    {
        public List<Models.Todo> GetTodo(string name)
            => Mapper.Map<List<Todo>, List<Models.Todo>>
            (Startup.Users.SelectMany(user => user.Todos, (user, todo) => new {user, todo})
                .Where(@t => @t.todo.Name == name).Select(@t => (@t.todo)).ToList());
    }
}
