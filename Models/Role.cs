using System.ComponentModel.DataAnnotations;

namespace bzbackend.Models
{
    public class Role
    {
        [Key]
        public int Roleid { get; set; }

        [Required]
        public string nama { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}
