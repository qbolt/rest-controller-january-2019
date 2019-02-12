using System.Collections.Generic;
using rest_controllers_january_2019.Data.Entities;

namespace rest_controllers_january_2019.Services
{
    public interface ITodoService
    {
        IEnumerable<TodoList> GetAllTodos();
    }
}