using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Sastavnica")]
    public class Sastavnica
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Broj { get; set; }

        public int Status { get; set; }

        public DateTime Datum { get; set; }

        [StringLength(15)]
        public string Vlasnik { get; set; }

        [StringLength(4)]
        public string JM { get; set; }

        public decimal UkupnaKolicina { get; set; }

        [StringLength(30)]
        public string ArtikalZaglavlja { get; set; }

        public int? PrijemnicaID { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        [StringLength(128)]
        public string EksternaSifra { get; set; }

        public int? OtpremnicaID { get; set; }

        public decimal OcekivanaKolicina { get; set; }

        public virtual Artikal Artikal { get; set; }
    }
}