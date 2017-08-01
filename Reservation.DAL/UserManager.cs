using Reservation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reservation.DAL
{
    public class UserManager
    {
        public bool AddUser(User user)
        {
            try
            {
                using (var db = new ReservationDataContext())
                {
                    db.Users.Add(user);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error Message: " + exception.Message);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + exception.InnerException.Message);
                }
                return false;
                
            }
        }

        public void AddUserType(UserType userType)
        {
            try
            {
                using (var db = new ReservationDataContext())
                {
                    db.UserTypes.Add(userType);
                    db.SaveChanges();
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine("Error Message: " + exception.Message);
                if (exception.InnerException != null)
                {
                    Console.WriteLine("Inner Exception: " + exception.InnerException.Message);
                }
            }
        }

        public List<User> GetUsers()
        {
            var users = new List<User>();

            using (var db = new ReservationDataContext())
            {
                try
                {
                    users = db.Users.ToList();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
            return users;
        }

        public List<UserType> GetUserTypes()
        {
            var uTypes = new List<UserType>();

            using (var db = new ReservationDataContext())
            {
                try
                {
                    uTypes = db.UserTypes.ToList();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception);
                }
            }
            return uTypes;
        }

        public void InitDb()
        {
            using (var context = new ReservationDataContext())
            {
                context.Database.Initialize(force: true);
            }
        }
    }
}