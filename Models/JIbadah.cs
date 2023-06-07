using System.ComponentModel.DataAnnotations;

namespace bzbackend.Models
{
    public class JIbadah
    {
        [Key]
        public int JIbadahId { get; set; }

        [Required]
        public DateTime tanggal { get; set; }
        public string  namakel { get; set; }
        public string  pelayan { get; set; }
        public string liturgos { get; set; }

        public int Usersid { get; set; }
        public Users Users { get; set; } = null!;
    }
}
