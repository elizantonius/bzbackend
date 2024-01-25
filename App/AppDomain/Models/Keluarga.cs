using bzbackend.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDomain.Models
{
    public class Keluarga
    {
        public int Id { get; set; }
        public string NomorKK { get; set; }

        public Jemaat KepalaKeluarag{get;set;}

        public Sektor Sektor { get; set; }

        public ICollection<Jemaat> AnggotaKeluarga { get; set; }
    }
}
