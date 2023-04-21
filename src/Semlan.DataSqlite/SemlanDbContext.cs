
using Microsoft.EntityFrameworkCore;
using Semlan.Domain.Models;

namespace Semlan.DataSqlite
{
    public class SemlanDbContext : DbContext
    {
        public SemlanDbContext(DbContextOptions<SemlanDbContext> options)
            : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Team> Teams { get; set; }

        public DbSet<UserVacation> UserVacations { get; set; }
    }
}
