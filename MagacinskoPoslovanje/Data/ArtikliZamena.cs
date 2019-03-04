using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("ArtikliZamena")]
    public class ArtikliZamena
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Barcode { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public virtual Artikal Artikal { get; set; }
    }
}