using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Serializing_JSON.Model;
using System.Collections.Generic;
namespace Serializing_JSON.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
        private void SeedData(ModelBuilder builder)
        {
            builder.Entity<Model.Route>().HasData(new Model.Route[]
            {
                new Model.Route{Number = 1 ,Name ="North", RampAccessible = true, BicycleAccessible = true, Direction = Serializing_JSON.Model.Enum.Direction.North },
                new Model.Route{Number = 2 ,Name ="West", RampAccessible = false, BicycleAccessible = true, Direction = Serializing_JSON.Model.Enum.Direction.West }
            });


            builder.Entity<Stop>().HasData(new Stop[]
            {
                new Stop(){Name ="North", Direction = Serializing_JSON.Model.Enum.Direction.North,Street = Serializing_JSON.Model.Enum.Direction.North.ToString(),Number = 1 },
                new Stop(){Name ="North", Direction = Serializing_JSON.Model.Enum.Direction.West,Street = Serializing_JSON.Model.Enum.Direction.West.ToString(),Number = 2 }
            });

            //builder.Entity<ScheduledStop>().HasData(new ScheduledStop[]
            //{
            //    new ScheduledStop { Id = 1, Route = new Model.Route{Number = 1}, ScheduledArrival = DateTime.Now.AddHours(1), Stop = new Stop(){Number = 1 } },
            //    new ScheduledStop { Id = 2, Route = new Model.Route{Number = 1}, ScheduledArrival = DateTime.Now.AddHours(2), Stop = new Stop(){Number = 1 } },
            //    new ScheduledStop { Id = 3, Route = new Model.Route{Number = 1}, ScheduledArrival = DateTime.Now.AddHours(3), Stop = new Stop(){Number = 1 } },
            //    new ScheduledStop { Id = 4, Route = new Model.Route{Number = 1}, ScheduledArrival = DateTime.Now.AddHours(4), Stop = new Stop(){Number = 1 } },
            //    new ScheduledStop { Id = 5, Route = new Model.Route{Number = 1}, ScheduledArrival = DateTime.Now.AddHours(5), Stop = new Stop(){Number = 1 } },

            //    new ScheduledStop { Id = 6, Route = new Model.Route{Number = 2}, ScheduledArrival = DateTime.Now.AddHours(1), Stop = new Stop(){Number = 2 } },
            //    new ScheduledStop { Id = 7, Route = new Model.Route{Number = 2}, ScheduledArrival = DateTime.Now.AddHours(2), Stop = new Stop(){Number = 2 } },
            //    new ScheduledStop { Id = 8, Route = new Model.Route{Number = 2}, ScheduledArrival = DateTime.Now.AddHours(3), Stop = new Stop(){Number = 2 } },
            //    new ScheduledStop { Id = 9, Route = new Model.Route{Number = 2}, ScheduledArrival = DateTime.Now.AddHours(4), Stop = new Stop(){Number = 2 } },
            //    new ScheduledStop { Id = 10, Route = new Model.Route{Number = 2}, ScheduledArrival = DateTime.Now.AddHours(5), Stop = new Stop(){Number = 2 } }
            //});
        }
        public DbSet<Model.Route> Route { get; set; }
        public DbSet<Stop> Stop { get; set; }
        public DbSet<ScheduledStop> ScheduledStop { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            SeedData(builder);
        }
    }
}
