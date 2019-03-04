using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("ArtikliLokacije")]
    public class ArtikliLokacije
    {

        public int ID { get; set; }

        //[Required]
        //[StringLength(30)]
        public string ArtikalSifra { get; set; }

        //[Required]
        //[StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        //[Required]
        //[StringLength(10)]
        public string Lokacija { get; set; }

        public decimal? MinimalnaKolicina { get; set; }

        public decimal? MaksimalnaKolicina { get; set; }

        [StringLength(4)]
        public string NajmanjaJMDopune { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public virtual Artikal Artikal { get; set; }

        public virtual Lokacija Lokacija1 { get; set; }
    }
}