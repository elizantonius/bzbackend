using System.ComponentModel.DataAnnotations;

namespace bzbackend.Models
{
    public class Jemaat
    {
        [Key]
        public int Jemaatid { get; set; }

        [Required]
        public string nama { get; set; }
        public string alamat { get; set; }
        public string pekerjaan { get; set; }
        public DateTime tglkelahiran { get; set; }
        public string golongandarah { get; set; }
        public string nokontak { get; set; }

        public int Sektorid { get; set; }
        public Sektor Sektor { get; set; }
    }
}
