using Microsoft.EntityFrameworkCore;
using WebApiEmployee.Models;

namespace WebApiEmployee.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
