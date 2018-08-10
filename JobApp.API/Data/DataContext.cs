using Microsoft.EntityFrameworkCore;
using JobApp.API.Models;
namespace JobApp.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
        
            public DbSet<Value> Values {get; set;}
        
    }
}