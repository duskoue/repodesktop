using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Odabir")]
    public class Odabir
    {
        public int ID { get; set; }

        public int Sarza { get; set; }

        [Required]
        [StringLength(10)]
        public string Lokacija { get; set; }

        [Required]
        [StringLength(18)]
        public string LPN { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        public decimal Kolicina { get; set; }

        public int Status { get; set; }

        public int Otpremnica { get; set; }

        public int OtpremnicaStavka { get; set; }

        public int OtpremnicaStavkaRB { get; set; }

        //[Column(TypeName = "timestamp")]
        //[MaxLength(8)]
        //[Timestamp]
        public byte[] RowVersion { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Promenio { get; set; }

        public DateTime DatumPromene { get; set; }

        [StringLength(50)]
        public string IzlazniLPN { get; set; }

        public decimal? BrojKoleta { get; set; }

        public decimal KolicinaPovrata { get; set; }

        public decimal KoletaPovrat { get; set; }

        public int? Odabrao { get; set; }

        public int? Kontrolisao { get; set; }

        public int? KontrolaRazlogGreske { get; set; }

        public DateTime? VremeOdabira { get; set; }

        public DateTime? VremeKontrole { get; set; }

        public decimal UtovarenaKolicina { get; set; }

        public int? Utovario { get; set; }

        public decimal OdabranaKolicina { get; set; }

        public DateTime? VremeUtovara { get; set; }

        public virtual Artikal Artikal { get; set; }

        public virtual Otpremnica Otpremnica1 { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }
    }
}