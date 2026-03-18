using API_Klimov.Model;
using Microsoft.EntityFrameworkCore;

namespace API_Klimov.Context
{
    public class UsersContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public UsersContext()
        {
            Database.EnsureCreated();
            Users.Load();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;" +
                "uid=root;" +
                "pwd=;" +
                "port=3307;" +
                "database=TaskManager",
                new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }
}
