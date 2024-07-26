using Microsoft.EntityFrameworkCore;
using MyTodoList_001.Domain.Entities;

namespace MyTodoList_001.Domain.Repoitories
{
    public class TodoDbContext : DbContext
    {
        protected readonly IConfiguration _configuration;

        public TodoDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(_configuration.GetConnectionString("TODOConnectionString"));
        }

        public DbSet<TodoItem> TodoItems { get; set; }
    }
}
