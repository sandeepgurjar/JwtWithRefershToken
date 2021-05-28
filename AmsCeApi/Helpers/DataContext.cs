using AmsCeApi.Entities;
using Microsoft.EntityFrameworkCore;


namespace AmsCeApi.Helpers
{
    public class DataContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
