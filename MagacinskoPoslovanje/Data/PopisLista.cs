using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("PopisLista")]
    public class PopisLista
    {
        public int ID { get; set; }

        public int Popis { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Required]
        [StringLength(10)]
        public string Lokacija { get; set; }

        [StringLength(18)]
        public string LPN { get; set; }

        [StringLength(50)]
        public string EksternoSkladiste { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public int? SarzaID { get; set; }

        public virtual Artikal Artikal { get; set; }

        public virtual Lokacija Lokacija1 { get; set; }

        public virtual Popi Popi { get; set; }
    }
}