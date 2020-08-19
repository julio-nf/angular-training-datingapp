using AngularTraining.API.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularTraining.API.Data
{
    public class DataContext : DbContext {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        public DbSet<Value> Values { get; set; }
    }
}