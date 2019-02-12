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
            return _todoService.GetAllTodos();
        }

    }
}