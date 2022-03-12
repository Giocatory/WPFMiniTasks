using System.Data.Entity;

namespace ForExperiments.Models.DBSource
{
    internal class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection") { }
        public DbSet<User>? Users { get; set; }
    }
}
