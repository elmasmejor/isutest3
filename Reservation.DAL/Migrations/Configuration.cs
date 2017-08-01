using Reservation.Entities;

namespace Reservation.DAL.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<ReservationDataContext>
    {
        public Configuration()
        {
            //AutomaticMigrationsEnabled = false;
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ReservationDataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );

            //context.UserTypes.AddOrUpdate(
            //    p => p.Name,
            //    new UserType { Name = "Admin" },
            //    new UserType { Name = "Guest" },
            //    new UserType { Name = "Suscriber" }
            //    );

            context.UserTypes.Add(new UserType { Name = "Admin" });
            context.UserTypes.Add(new UserType { Name = "Subscriber" });
            var userGuest = context.UserTypes.Add(new UserType { Name = "Guest" });

            context.Users.Add(new User { Name = "User 1", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 2", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 3", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 4", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 5", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 6", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 7", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 8", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 9", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 10", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 11", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 12", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 13", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 14", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 15", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 16", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 17", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 18", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 19", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 20", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 21", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 22", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 23", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 24", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 25", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 26", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 27", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 28", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 29", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 30", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 31", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 32", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 33", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 34", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 35", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 36", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 37", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 38", Phone = "Phone", Dob = "22/04/2001", Description = "some description", UserType = userGuest });
        }
    }
}