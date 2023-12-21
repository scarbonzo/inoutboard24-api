using Microsoft.EntityFrameworkCore;

namespace inoutboard24_api.Models
{
    public class MsSqlContext : DbContext
    {
        public MsSqlContext(DbContextOptions<MsSqlContext> options)
        : base(options)
        {
        }

        public DbSet<Status> Statuses { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<Week> Weeks { get; set; } = null!;
    }
}
