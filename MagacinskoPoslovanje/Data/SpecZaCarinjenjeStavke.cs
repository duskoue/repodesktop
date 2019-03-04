using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("SpecZaCarinjenjeStavke")]
    public class SpecZaCarinjenjeStavke
    {

        public int ID { get; set; }

        public int SpecZaCarinjenje { get; set; }

        public int? Otpremnica { get; set; }

        [StringLength(50)]
        public string Faktura { get; set; }

        public int? RB { get; set; }

        [StringLength(30)]
        public string SifraArtikla { get; set; }

        [StringLength(256)]
        public string NazivArtikla { get; set; }

        [StringLength(50)]
        public string Poreklo { get; set; }

        public decimal? Kolicina { get; set; }

        public decimal? JedinicnaCena { get; set; }

        public decimal? Ukupno { get; set; }

        [StringLength(50)]
        public string TarifniBroj { get; set; }

        public decimal? Neto { get; set; }

        [StringLength(4)]
        public string JM { get; set; }

        [StringLength(50)]
        public string Sanitarna { get; set; }

        public decimal? Stopa { get; set; }

        public int? BrojJ7 { get; set; }

        public int? GodinaJ7 { get; set; }

        public decimal? BrutoMasa { get; set; }

        [StringLength(5)]
        public string Carinarnica { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public virtual SpecZaCarinjenje SpecZaCarinjenje1 { get; set; }
    }
}