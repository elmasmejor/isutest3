using System.ComponentModel.DataAnnotations;

namespace Reservation.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public string Dob { get; set; }

        [Required]
        [StringLength(12)]
        public string Phone { get; set; }

        public int UserTypeId { get; set; }
        public virtual UserType UserType { get; set; }

        //[ForeignKey("UserTypeRefId")]
        //public virtual UserType UserType { get; set; }

        public User()
        {
        }
    }
}