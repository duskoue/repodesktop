using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Posao")]
    public class Posao
    {
        public int ID { get; set; }

        public int TipPosla { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        public int? Sarza { get; set; }

        [StringLength(4)]
        public string JM { get; set; }

        public decimal? Kolicina { get; set; }

        [StringLength(10)]
        public string SaLokacije { get; set; }

        [StringLength(18)]
        public string SaPJ { get; set; }

        [StringLength(10)]
        public string NaLokaciju { get; set; }

        [StringLength(18)]
        public string NaPJ { get; set; }

        public int? Radnik { get; set; }

        public int StatusPosla { get; set; }

        public int Prioritet { get; set; }

        [StringLength(20)]
        public string Izvor { get; set; }

        public int? IzvorID { get; set; }

        public int? Odabir { get; set; }

        public int? Otpremnica { get; set; }

        public int? OtpremnicaStavka { get; set; }

        public DateTime? VremePocetka { get; set; }

        public DateTime? VremeZavrsetka { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public int? Grupa { get; set; }

        public virtual Artikal Artikal { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Sarza Sarza1 { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }

        public virtual Sifarnik Sifarnik1 { get; set; }
    }
}