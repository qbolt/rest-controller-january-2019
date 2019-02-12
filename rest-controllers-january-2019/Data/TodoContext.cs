using Microsoft.EntityFrameworkCore;
using rest_controllers_january_2019.Data.Entities;

namespace rest_controllers_january_2019.Data
{
    public class TodoContext : DbContext
    {
        public DbSet<TodoList> TodoList { get; set; }
        public DbSet<Todo> Todos { get; set; }
        
        public TodoContext(DbContextOptions<TodoContext> options)
            : base(options) 
        { }
    }
}