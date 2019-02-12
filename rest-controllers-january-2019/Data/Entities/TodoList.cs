using System.Collections.Generic;

namespace rest_controllers_january_2019.Data.Entities
{
    public class TodoList
    {
        public string ListName { get; set; }
        
        public List<Todo> Todos { get; set; }
        
        public bool Deleted { get; set; }
    }
}