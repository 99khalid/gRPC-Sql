using GrpcService3.model;
using Microsoft.EntityFrameworkCore;

namespace GrpcService3.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        
        }

        public DbSet<ToDoItem> ToDoItems => Set<ToDoItem>();

    }
}
