using System.ComponentModel.DataAnnotations;

namespace bzbackend.Models
{
    public class Sektor
    {
        [Key]
        public int Sektorid { get; set; }
        [Required]
        public string nama { get; set; }

        public ICollection<Jemaat> Jemaats { get; set; }
        public Jemaat jemaat { get; set; }
       
    }
}
