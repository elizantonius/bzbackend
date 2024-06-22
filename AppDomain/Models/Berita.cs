using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppDomain.Models
{
    public class Berita
    {
        [Key]
        public int Beritaid { get; set; }

        [Required]
        public String judul { get; set; }
        public String gambar { get; set; }
        public String isi { get; set; }
        public DateTime tanggal { get; set; }

        public int Usersid { get; set; }
        //public Users Users { get; set; }

        [NotMapped]
        public byte[] FileData { get; set; }

    }
}
