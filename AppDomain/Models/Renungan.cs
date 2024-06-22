using System.ComponentModel.DataAnnotations;

namespace AppDomain.Models
{
    public class Renungan
    {
        [Key]
        public int Renunganid { get; set; }
        [Required]
        public string judulrenungan { get; set; }
        public string nats { get; set; }
        public string pembacaan { get; set; }
        public string isirenungan { get; set; }
        public string doa { get; set; }

        public int Usersid { get; set; }
        //public Users Users { get; set; } = null!;

    }
}
