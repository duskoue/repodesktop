using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("CarinskaOtpremnicaStavke")]
    public class CarinskaOtpremnicaStavke
    {
        public int ID { get; set; }

        public int RB { get; set; }

        public int CarinskaOtpremnica { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public int TipDokumenta { get; set; }

        [Required]
        [StringLength(50)]
        public string BrojDokumenta { get; set; }

        [Required]
        [StringLength(128)]
        public string Dokument { get; set; }

        [Required]
        [StringLength(128)]
        public string TrgovackiNaziv { get; set; }

        public decimal BrojKoleta { get; set; }

        public decimal Tezina { get; set; }

        public decimal Vrednost { get; set; }

        [Required]
        [StringLength(3)]
        public string Valuta { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public int? BorderoStavka { get; set; }

        public decimal? Zapremina { get; set; }

        public virtual CarinskaOtpremnica CarinskaOtpremnica1 { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }

        public virtual Skladiste Skladiste1 { get; set; }

        public virtual Valuta Valuta1 { get; set; }
    }
}
