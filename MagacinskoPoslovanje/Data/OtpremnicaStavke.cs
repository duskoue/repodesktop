using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("OtpremnicaStavke")]
    public class OtpremnicaStavke
    {
        public int ID { get; set; }

        public int RB { get; set; }

        public int Otpremnica { get; set; }

        [StringLength(128)]
        public string EksternaSifraStavke { get; set; }

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

        public decimal RezervisanaKolicina { get; set; }

        public decimal OdabranaKolicina { get; set; }

        public decimal IsporucenaKolicina { get; set; }

        public int Status { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        [StringLength(50)]
        public string SerijskiBroj { get; set; }

        [StringLength(50)]
        public string MagacinskiBroj { get; set; }

        public DateTime? DatumIsteka { get; set; }

        public DateTime? DatumProizvodnje { get; set; }

        public decimal? SerijaOd { get; set; }

        public decimal? SerijaDo { get; set; }

        [StringLength(250)]
        public string Atribut1 { get; set; }

        [StringLength(250)]
        public string Atribut2 { get; set; }

        [StringLength(128)]
        public string EksternaSifraStavke2 { get; set; }

        [StringLength(128)]
        public string EksternaSifra { get; set; }

        [StringLength(128)]
        public string EksternaSifra2 { get; set; }

        public bool? Garancija { get; set; }

        [StringLength(50)]
        public string Pomocno1 { get; set; }

        [StringLength(50)]
        public string Pomocno2 { get; set; }

        [StringLength(50)]
        public string Pomocno3 { get; set; }

        [StringLength(50)]
        public string Pomocno4 { get; set; }

        [StringLength(50)]
        public string Serija { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }

        public decimal? BrojKoleta { get; set; }

        public decimal? Cena { get; set; }

        [StringLength(50)]
        public string BrojFakture { get; set; }

        public decimal KolicinaPovrata { get; set; }

        public decimal KoletaPovrat { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        public int? SarzaRezervacije { get; set; }

        [StringLength(18)]
        public string LpnRezervacije { get; set; }

        [StringLength(18)]
        public string LokacijaRezervacije { get; set; }

        [StringLength(50)]
        public string EksternoSkladiste { get; set; }

        public decimal? Tezina { get; set; }

        public decimal? Zapremina { get; set; }

        public bool RezervacijaSaLokacijeDopune { get; set; }

        public decimal UtovarenaKolicina { get; set; }

        public int? B2BID { get; set; }

        public virtual Artikal Artikal { get; set; }

        public virtual JM JM1 { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Otpremnica Otpremnica1 { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }

        public virtual Skladiste Skladiste1 { get; set; }
    }
}