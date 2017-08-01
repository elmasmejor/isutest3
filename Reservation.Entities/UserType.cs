using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Reservation.Entities
{
    public class UserType
    {
        [Key]
        public int UserTypeId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<User> Users { get; set; }

        public UserType()
        {
            Users = new List<User>();
        }
    }
}