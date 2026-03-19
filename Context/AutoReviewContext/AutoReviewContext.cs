using Microsoft.EntityFrameworkCore;

namespace API_Klimov.Context.AutoReviewContext
{
    public class AutoReviewContext : DbContext
    {
        public DbSet<Model.AutoReview.BodyTypes> BodyTypes { get; set; }
        public DbSet<Model.AutoReview.Brands> Brands { get; set; }
        public DbSet<Model.AutoReview.Cars> Cars { get; set; }
        public DbSet<Model.AutoReview.Engines> Engines { get; set; }
        public DbSet<Model.AutoReview.Models> Models { get; set; }
        public DbSet<Model.AutoReview.Owners> Owners { get; set; }
        public DbSet<Model.AutoReview.Transmissions> Transmissions { get; set; }
        public DbSet<Model.AutoReview.Trims> Trims { get; set; }


        public AutoReviewContext()
        {
            Database.EnsureCreated();
            BodyTypes.Load();
            Brands.Load();
            Cars.Load();
            Engines.Load();
            Models.Load();
            Owners.Load();
            Transmissions.Load();
            Trims.Load();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;" +
                "uid=root;" +
                "port=3307;" +
                "pwd=;" +
                "database=AutoReview",
                new MySqlServerVersion(new Version(8, 0, 11)));
        }
    }
}
