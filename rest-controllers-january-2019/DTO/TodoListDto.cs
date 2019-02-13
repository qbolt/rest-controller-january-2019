using System.Collections.Generic;

namespace rest_controllers_january_2019.DTO
{
    public class TodoListDto
    {
        public string ListName { get; set; }
        
        public List<TodoDto> Todos { get; set; }
    }
}