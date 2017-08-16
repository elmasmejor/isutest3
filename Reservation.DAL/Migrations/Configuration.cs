using System;
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

            var userAdmin = context.UserTypes.Add(new UserType { Name = "Admin" });
            context.UserTypes.Add(new UserType { Name = "Subscriber" });
            var userGuest = context.UserTypes.Add(new UserType { Name = "Guest" });

            context.Users.Add(new User { Name = "Leo", Phone = "Phone", Dob = Convert.ToDateTime("21/09/1987"), Description = "some description", UserType = userAdmin });
            context.Users.Add(new User { Name = "User 02", Phone = "Phone", Dob = Convert.ToDateTime("4/09/2001"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 03", Phone = "Phone", Dob = Convert.ToDateTime("15/05/1999"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 04", Phone = "Phone", Dob = Convert.ToDateTime("23/04/2001"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 05", Phone = "Phone", Dob = Convert.ToDateTime("26/01/1988"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 06", Phone = "Phone", Dob = Convert.ToDateTime("1/12/2000"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 07", Phone = "Phone", Dob = Convert.ToDateTime("2/05/2017"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 08", Phone = "Phone", Dob = Convert.ToDateTime("2/04/2014"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 09", Phone = "Phone", Dob = Convert.ToDateTime("5/01/2001"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 10", Phone = "Phone", Dob = Convert.ToDateTime("16/04/2001"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 11", Phone = "Phone", Dob = Convert.ToDateTime("24/02/1989"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 12", Phone = "Phone", Dob = Convert.ToDateTime("7/12/2001"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 13", Phone = "Phone", Dob = Convert.ToDateTime("19/01/2014"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 14", Phone = "Phone", Dob = Convert.ToDateTime("31/01/2017"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 15", Phone = "Phone", Dob = Convert.ToDateTime("30/04/2001"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 16", Phone = "Phone", Dob = Convert.ToDateTime("19/09/1987"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 17", Phone = "Phone", Dob = Convert.ToDateTime("22/04/1983"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 18", Phone = "Phone", Dob = Convert.ToDateTime("18/09/2001"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 19", Phone = "Phone", Dob = Convert.ToDateTime("14/12/2017"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 20", Phone = "Phone", Dob = Convert.ToDateTime("22/09/2001"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 21", Phone = "Phone", Dob = Convert.ToDateTime("2/01/2013"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 22", Phone = "Phone", Dob = Convert.ToDateTime("6/05/1984"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 23", Phone = "Phone", Dob = Convert.ToDateTime("9/04/2014"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 24", Phone = "Phone", Dob = Convert.ToDateTime("9/01/1987"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 25", Phone = "Phone", Dob = Convert.ToDateTime("17/09/2014"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 26", Phone = "Phone", Dob = Convert.ToDateTime("7/12/1981"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 27", Phone = "Phone", Dob = Convert.ToDateTime("9/09/2001"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 28", Phone = "Phone", Dob = Convert.ToDateTime("10/09/1987"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 29", Phone = "Phone", Dob = Convert.ToDateTime("10/10/2014"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 30", Phone = "Phone", Dob = Convert.ToDateTime("12/01/2001"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 31", Phone = "Phone", Dob = Convert.ToDateTime("19/12/2013"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 32", Phone = "Phone", Dob = Convert.ToDateTime("25/05/2001"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 33", Phone = "Phone", Dob = Convert.ToDateTime("14/01/2013"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 34", Phone = "Phone", Dob = Convert.ToDateTime("22/04/2001"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 35", Phone = "Phone", Dob = Convert.ToDateTime("15/01/1987"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 36", Phone = "Phone", Dob = Convert.ToDateTime("23/04/1973"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 37", Phone = "Phone", Dob = Convert.ToDateTime("20/09/1974"), Description = "some description", UserType = userGuest });
            context.Users.Add(new User { Name = "User 38", Phone = "Phone", Dob = Convert.ToDateTime("5/09/2014"), Description = "some description", UserType = userGuest });
        }
    }
}