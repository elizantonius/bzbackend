using System.ComponentModel.DataAnnotations;

namespace AppDomain.Models
{
    public class Users
    {
        [Key]
        public int Usersid { get; set; }
        [Required]
        public string nama { get; set; }
        public string email { get; set; }
        public string username { get; set; }
        public string passwd { get; set; }

        //public ICollection<Renungan> Renungans { get; set; }
        //public ICollection<Berita> Beritas { get; set; }
        //public ICollection<JIbadah> JIbadahs { get; set; }

        public int Roleid { get; set; }
        //public Role Role { get; set; }
    }
}
