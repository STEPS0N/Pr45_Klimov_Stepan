using Microsoft.EntityFrameworkCore;

namespace API_Klimov.Context
{
    public class TaskContext : DbContext
    {
        public DbSet<Model.Task> Tasks { get; set; }

        public TaskContext()
        {
            Database.EnsureCreated();
            Tasks.Load();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;" +
                "uid=root;" +
                "port=3307;" +
                "pwd=;" +
                "database=TaskManager",
                new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }
}
