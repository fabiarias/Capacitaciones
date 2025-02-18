using CrudNetCore.Models;
using Microsoft.EntityFrameworkCore;


namespace CrudNetCore.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options): base(options)
        {
            
        }
        public DbSet<Libro> Libro { get; set; }
    }
}
