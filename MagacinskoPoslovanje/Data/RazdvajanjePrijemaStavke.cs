using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("RazdvajanjePrijemaStavke")]
    public  class RazdvajanjePrijemaStavke
    {
        public int ID { get; set; }

        public int RazdvajanjePrijema { get; set; }

        public int RB { get; set; }

        [Required]
        [StringLength(256)]
        public string Kupac { get; set; }

        [Required]
        [StringLength(50)]
        public string Grad { get; set; }

        [Required]
        [StringLength(50)]
        public string Roba { get; set; }

        public decimal Koleta { get; set; }

        public decimal Tezina { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public int BrojNalepnica { get; set; }

        public int? BorderoStavkaID { get; set; }

        [StringLength(18)]
        public string LPN { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual RazdvajanjePrijema RazdvajanjePrijema1 { get; set; }
    }
}
