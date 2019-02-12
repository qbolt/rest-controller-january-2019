using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using rest_controllers_january_2019.Data.Entities;
using rest_controllers_january_2019.Services;

namespace rest_controllers_january_2019.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private ITodoService _todoService;
        
        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }
        
        // GET api/values
        [HttpGet]
        public IEnumerable<TodoList> Get()
        {
            return _todoService.GetAllTodoLists();
        }

        [HttpGet("todolist/{id}")]
        public TodoList GetTodoList(int id)
        {
            return _todoService.GetTodoList(id);
        }

        [HttpPost("todolist")]
        public TodoList CreateList([FromBody] TodoList todoList)
        {
            return _todoService.CreateTodoList(todoList);
        }

        [HttpPost("todolist/{id}")]
        public TodoList CreateTodoInList(int id, [FromBody] Todo todo)
        {
            return _todoService.CreateTodoInTodoList(id, todo);
        }
        
        [HttpGet("todolist/{id}/completed")]
        public TodoList GetCompletedTodos(int id)
        {
            return _todoService.GetCompletedTodos(id);
        }
        
        [HttpPatch("todolist/{listId}/complete/{todoId}")]
        public TodoList CompleteTodo(int listId, int todoId)
        {
            return _todoService.CompleteTodo(listId, todoId);
        }
        
    }
}