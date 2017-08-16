using System.Collections.Generic;
using Reservation.DAL;
using Reservation.Entities;

namespace Reservation.BL
{
    public class UserLogic
    {
        private UserManager _umanager;

        private UserManager UManager
        {
            get
            {
                return _umanager ?? (_umanager = new UserManager());
            }
        }
        public IEnumerable<User> GetUsers()
        {
            return UManager.GetUsers();
        }

        public List<UserType> GetUseTypes()
        {
            return UManager.GetUserTypes();
        }

        public bool AddUser(User user)
        {
            return UManager.AddUser(user);
        }

        public User GetUser(int id)
        {
            var user = UManager.GetUser(id);
            return user;
        }

        public User DeleteUser(int id)
        {
            var user = UManager.DeleteUser(id);
            return user;
        }

        public void AddUserType(UserType userType)
        {
            UManager.AddUserType(userType);
        }

        public void InitializeDb()
        {
            UManager.InitDb();
        }

        public bool Edit(User user)
        {
            return UManager.UpdateUser(user);
        }
    }
}