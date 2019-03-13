using b4dp.api.Models;
using Microsoft.EntityFrameworkCore;

namespace b4dp.api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {  }

        public DbSet<Value> Value {get; set;}
    }
}