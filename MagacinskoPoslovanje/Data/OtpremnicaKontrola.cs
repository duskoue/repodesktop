using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("OtpremnicaKontrola")]
    public  class OtpremnicaKontrola
    {
        public int ID { get; set; }

        public int Otpremnica { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        public decimal Kolicina { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumKreiranja { get; set; }
    }
}
