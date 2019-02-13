using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using rest_controllers_january_2019.Data.Entities;
using rest_controllers_january_2019.DTO;
using rest_controllers_january_2019.Services;

namespace rest_controllers_january_2019.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private IMapper _mapper;
        
        private ITodoService _todoService;
        
        public TodoController(ITodoService todoService, IMapper mapper)
        {
            _mapper = mapper;
            _todoService = todoService;
        }
        
        // GET api/values
        [HttpGet]
        public IEnumerable<TodoListDto> Get()
        {
            return _mapper
                .Map<IEnumerable<TodoList>, IEnumerable<TodoListDto>>(_todoService.GetAllTodoLists());
        }

        [HttpGet("todolist/{id}")]
        public TodoListDto GetTodoList(int id)
        {
            var listEntity = _todoService.GetTodoList(id);
            var listDto = _mapper.Map<TodoListDto>(listEntity);
            return listDto;
        }

        [HttpPost("todolist")]
        public TodoListDto CreateList([FromBody] TodoList todoList)
        {
            return _mapper.Map<TodoListDto>(_todoService.CreateTodoList(todoList));
        }

        [HttpPost("todolist/{id}")]
        public TodoListDto CreateTodoInList(int id, [FromBody] Todo todo)
        {
            return _mapper.Map<TodoListDto>(_todoService.CreateTodoInTodoList(id, todo));
        }
        
        [HttpGet("todolist/{id}/completed")]
        public TodoListCompletedDto GetCompletedTodos(int id)
        {
            return _mapper.Map<TodoListCompletedDto>(_todoService.GetCompletedTodos(id));
        }
        
        [HttpPatch("todolist/{listId}/complete/{todoId}")]
        public TodoListDto CompleteTodo(int listId, int todoId)
        {
            return _mapper.Map<TodoListDto>(_todoService.CompleteTodo(listId, todoId));
        }
        
    }
}