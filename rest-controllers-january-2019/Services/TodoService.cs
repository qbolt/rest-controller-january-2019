using System.Collections.Generic;
using System.Linq;
using rest_controllers_january_2019.Data;
using rest_controllers_january_2019.Data.Entities;

namespace rest_controllers_january_2019.Services
{
    public class TodoService : ITodoService
    {
        private TodoContext _context;

        public TodoService(TodoContext context)
        {
            this._context = context;
        }

        public IEnumerable<TodoList> GetAllTodos()
        {
            return _context.TodoList.ToList();
        }
    }
}