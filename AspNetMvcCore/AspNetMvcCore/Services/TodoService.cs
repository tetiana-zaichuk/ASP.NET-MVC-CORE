using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataStructuresAndLINQ;

namespace AspNetMvcCore.Services
{
    public class TodoService
    {
        private static List<Todo> todos;

        public TodoService()
        {
            todos = Queries.GetTodo();
        }

        public List<Todo> GetTodo(string name)
        {
            return todos.Where(n => n.Name == name).ToList();
        }
    }
}
