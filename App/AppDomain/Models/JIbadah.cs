using System.ComponentModel.DataAnnotations;

namespace bzbackend.Models
{
    public class JIbadah
    {
        [Key]
        public int JIbadahId { get; set; }

        [Required]
        public DateTime tanggal { get; set; }
        public string  tempat { get; set; }     //Keluarga yg di kunjungi
        public string  alamat { get; set; }
        public string liturgos { get; set; }
        public string mc { get; set; }
        public string pelayanan { get; set; }

        public int Usersid { get; set; }
        //public Users Users { get; set; } = null!;
    }
}
