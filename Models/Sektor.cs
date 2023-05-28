using System.ComponentModel.DataAnnotations;

namespace bzbackend.Models
{
    public class Sektor
    {
        [Key]
        public int Sektorid { get; set; }
        [Required]
        public int nama { get; set; }

        public ICollection<Jemaat> Jemaats { get; set; }
    }
}
