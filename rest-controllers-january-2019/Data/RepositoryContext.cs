using Microsoft.EntityFrameworkCore;
using rest_controllers_january_2019.Data.Entities;

namespace rest_controllers_january_2019.Data
{
    public class RepositoryContext : DbContext
    {
        public DbSet<TodoList> TodoList { get; set; }
        public DbSet<Todo> Todos { get; set; }
        
        public RepositoryContext(DbContextOptions<RepositoryContext> options)
            : base(options) 
        { }
    }
}