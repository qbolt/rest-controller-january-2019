using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using rest_controllers_january_2019.Data;
using rest_controllers_january_2019.Data.Entities;

namespace rest_controllers_january_2019.Services
{
    public class TodoService : ITodoService
    {
        private RepositoryContext _context;

        public TodoService(RepositoryContext context)
        {
            _context = context;
        }

        public IEnumerable<TodoList> GetAllTodoLists()
        {
            return _context.TodoList.Include(tl => tl.Todos).ToList();
        }

        public TodoList GetTodoList(int id)
        {
            return _context.TodoList.Include(tl => tl.Todos).First(tl => tl.Id == id);
        }

        public TodoList CreateTodoList(TodoList todoList)
        {
            _context.Add(todoList);
            _context.SaveChanges();
            return todoList;
        }

        public TodoList CreateTodoInTodoList(int id, Todo todo)
        {
            
            // Query to fetch todolist and nested todos
            var todoList = _context
                .TodoList.Include(tl => tl.Todos)
                .First(tl => tl.Id == id);
            
            // Add todo to the list contained within todolist
            todoList.Todos.Add(todo);
            
            _context.Update(todoList);
            _context.SaveChanges();
            return todoList;
        }

        public TodoList CompleteTodo(int listId, int todoId)
        {
            var todoList = _context
                .TodoList.Include(tl => tl.Todos)
                .First(tl => tl.Id == listId);

            var todo = todoList.Todos.First(t => t.Id == todoId);
            todo.Completed = true;

            _context.Update(todo);
            _context.SaveChanges();

            return todoList;

        }

        public TodoList GetCompletedTodos(int id)
        {
            var todoList = _context
                .TodoList
                .Include(tl => tl.Todos)
                .First(tl => tl.Id == id);

            // Filter connected entity without saving
            todoList.Todos = todoList.Todos.Where(t => t.Completed).ToList();
            return todoList;
        }
    }
}