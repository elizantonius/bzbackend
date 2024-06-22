using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDomain.Models
{
    public class Berita
    {
        [Key]
        public int Beritaid { get; set; }

        [Required]
        public string judul { get; set; }
        public string? gambar { get; set; }
        public string isi { get; set; }
        public DateTime tanggal { get; set; }

        //public int Usersid { get; set; }
        //public Users Users { get; set; }

        [NotMapped]
        public byte[] FileData { get; set; }

    }
}
