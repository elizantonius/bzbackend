using System.ComponentModel.DataAnnotations;

namespace bzbackend.Models
{
    public class KepalaKeluarga
    {
        [Key]

        public int Kkelid { get; set; }

        [Required]
        public string namalengkap { get; set; }
        public int nik { get; set; }
        public string jeniskelamin { get; set; }
        public string tempatlahir { get; set; }
        public DateTime tangallahir { get; set; }
        public string alamat { get; set; }
        public string pendidikan { get; set; }
        public string jenispekerjaan { get; set; }
        public string golongandarah { get; set; }
        public string statusperkawinan { get; set; }
        public string statusdalamkeluarga { get; set; }
        public string baptis { get; set; }
        public string sidi { get; set; }
        public string nokontak { get; set; }

        public int Sektorid { get; set; }
        

    }
}
