using Reservation.Entities;
using System.Data.Entity;

namespace Reservation.DAL
{
    public class ReservationDataContext : DbContext
    {
        private static System.Data.Entity.SqlServer.SqlProviderServices _instance =
            System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        public ReservationDataContext()
            : base("ReservationDataContext")
        {
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<ReservationDataContext>());
            //Database.SetInitializer(new CreateDatabaseIfNotExists<ReservationDataContext>());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<UserType> UserTypes { get; set; }
    }
}