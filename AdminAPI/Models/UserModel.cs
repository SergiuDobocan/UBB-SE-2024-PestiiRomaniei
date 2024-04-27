using System.ComponentModel.DataAnnotations;

namespace AdminAPI.Models
{
    public class UserModel
    {
        public int UserId { get; set; }

        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(100)] ///Hashing needed???
        public string Password { get; set; }

        [Required]
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        Normal,
        Admin,
        Artist
    }
}
