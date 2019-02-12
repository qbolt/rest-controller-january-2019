using System.Collections.Generic;
using rest_controllers_january_2019.Data.Entities;

namespace rest_controllers_january_2019.Services
{
    public interface ITodoService
    {
        IEnumerable<TodoList> GetAllTodoLists();
        TodoList GetTodoList(int id);
        TodoList CreateTodoList(TodoList todoList);
        TodoList CreateTodoInTodoList(int id, Todo todo);
        TodoList CompleteTodo(int listId, int todoId);
        TodoList GetCompletedTodos(int id);
    }
}