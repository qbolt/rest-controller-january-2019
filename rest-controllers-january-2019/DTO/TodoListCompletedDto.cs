using System.Collections.Generic;

namespace rest_controllers_january_2019.DTO
{
    public class TodoListCompletedDto
    {
        public string ListName { get; set; }
        
        public List<string> Todos { get; set; }
    }
}