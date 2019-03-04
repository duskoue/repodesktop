using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("SastavnicaStavke")]
    public class SastavnicaStavke
    {
        public int ID { get; set; }

        public int RB { get; set; }

        public int Sastavnica { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Required]
        [StringLength(4)]
        public string JM { get; set; }

        public decimal Kolicina { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public int? OtpremnicaID { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }
    }
}
