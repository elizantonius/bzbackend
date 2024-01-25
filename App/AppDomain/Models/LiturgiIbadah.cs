using System.ComponentModel.DataAnnotations;

namespace bzbackend.Models
{
    public class LiturgiIbadah
    {
        [Key]
        public int Libid { get; set; }

        [Required]
        public string liturgi { get; set; }     //Liturgi yang digunakan
        public string Bacaan { get; set; }      //Bacaan Alkitab
        public string PemimpinIbadah { get; set; }  //Dipimpin oleh Pdt siapa?
        public string Pendamping { get; set; }      //Pelayan Pendamping
        public string PengakuanDosa { get; set; }   //Majelis yang membaca Penakuan Dosa
        public string Pembacaan { get; set; }       //Majelis/Pelayan yang membaca Pembacaan Firman
        public string PembacaWJ { get; set; }       //Majelis yang membaca Warta Jemaat
        public string PelayanaanOS { get; set; }    // Pelayanaan orang sakit
        public string Kolektaan { get; set; }       
        public string PemainKeyboard {  get; set; } 
        public string Nyanyian { get; set; }        //Nyanyian yang digunakan pada saat Ibadah
        public string MajelisPiket { get; set; }    

    }
}
