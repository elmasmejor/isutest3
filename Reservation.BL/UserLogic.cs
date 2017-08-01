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
        public List<User> GetUsers()
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

        public void AddUserType(UserType userType)
        {
            UManager.AddUserType(userType);
        }

        public void InitializeDb()
        {
            UManager.InitDb();
        }
    }
}