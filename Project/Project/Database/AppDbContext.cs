using Microsoft.EntityFrameworkCore;

namespace Project.Database
{
    public class AppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Area> Areas { get; set; }
        public DbSet<Profile> Profiles { get; set; }
        public DbSet<ProfilePoint> ProfilePoints { get; set; }
        public DbSet<Picket> Pickets { get; set; }
        public DbSet<PicketValue> PicketValues { get; set; }
        public DbSet<Operator> Operators { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
        }

        private static void SeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerID = 1, CustomerName = "Customer 1", Email = "customer1@example.com" },
                new Customer { CustomerID = 2, CustomerName = "Customer 2", Email = "customer2@example.com" },
                new Customer { CustomerID = 3, CustomerName = "Customer 3", Email = "customer3@example.com" }
            );

            modelBuilder.Entity<Project>().HasData(
                new Project { ProjectID = 1, ProjectName = "Project 1", Location = "Location 1", CustomerID = 1 },
                new Project { ProjectID = 2, ProjectName = "Project 2", Location = "Location 2", CustomerID = 2 },
                new Project { ProjectID = 3, ProjectName = "Project 3", Location = "Location 3", CustomerID = 3 }
            );

            modelBuilder.Entity<Area>().HasData(
                new Area { AreaID = 1, AreaName = "Area 1", ProjectID = 1 },
                new Area { AreaID = 2, AreaName = "Area 2", ProjectID = 2 },
                new Area { AreaID = 3, AreaName = "Area 3", ProjectID = 3 }
            );

            modelBuilder.Entity<Profile>().HasData(
                new Profile { ProfileID = 1, AreaID = 1 },
                new Profile { ProfileID = 2, AreaID = 2 },
                new Profile { ProfileID = 3, AreaID = 3 }
            );

            modelBuilder.Entity<ProfilePoint>().HasData(
                new ProfilePoint { PointID = 1, XCoordinate = 1.0, YCoordinate = 1.0, ProfileID = 1 },
                new ProfilePoint { PointID = 2, XCoordinate = 5.0, YCoordinate = 5.0, ProfileID = 2 },
                new ProfilePoint { PointID = 3, XCoordinate = 9.0, YCoordinate = 9.0, ProfileID = 3 }
            );

            modelBuilder.Entity<Picket>().HasData(
                new Picket { PicketID = 1, XCoordinate = 1, YCoordinate = 1, ProfilePointID = 1 },
                new Picket { PicketID = 2, XCoordinate = 4, YCoordinate = 4, ProfilePointID = 2 },
                new Picket { PicketID = 3, XCoordinate = 6, YCoordinate = 6, ProfilePointID = 2 },
                new Picket { PicketID = 4, XCoordinate = 8, YCoordinate = 8, ProfilePointID = 3 },
                new Picket { PicketID = 5, XCoordinate = 10, YCoordinate = 10, ProfilePointID = 3 }
            );

            modelBuilder.Entity<PicketValue>().HasData(
                new PicketValue { PicketValueID = 1, Amplitude = 1.0, HValue = 1.0, PicketID = 1 },
                new PicketValue { PicketValueID = 2, Amplitude = 2.0, HValue = 2.0, PicketID = 2 },
                new PicketValue { PicketValueID = 3, Amplitude = 3.0, HValue = 3.0, PicketID = 3 },
                new PicketValue { PicketValueID = 4, Amplitude = 4.0, HValue = 4.0, PicketID = 4 },
                new PicketValue { PicketValueID = 5, Amplitude = 5.0, HValue = 5.0, PicketID = 5 }
            );

            modelBuilder.Entity<Operator>().HasData(
                new Operator { OperatorID = 1, OperatorName = "Operator 1", OperatorLogin = "1", OperatorPassword = "1", PicketID = 1, Role = Role.Administrator },
                new Operator { OperatorID = 2, OperatorName = "Operator 2", OperatorLogin = "2", OperatorPassword = "2", PicketID = 2 },
                new Operator { OperatorID = 3, OperatorName = "Operator 3", OperatorLogin = "3", OperatorPassword = "3", PicketID = 3 }
            );
        }
    }
}
