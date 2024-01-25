using System.ComponentModel.DataAnnotations;

namespace bzbackend.Models
{
    public class Jemaat
    {
        [Key]
        public int Jemaatid { get; set; }

        public int Kkelid { get; set; }
    }
}
