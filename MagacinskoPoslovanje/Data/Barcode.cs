using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Barcode")]
    public class Barcode
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string Sifra { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string SifraVlasnika { get; set; }

        [Required]
        [StringLength(30)]
        public string SifraArtikla { get; set; }

        public int Pakovanje { get; set; }

        [Required]
        [StringLength(4)]
        public string JM { get; set; }

        public virtual Artikal Artikal { get; set; }

        public virtual JM JM1 { get; set; }

        public virtual Pakovanje Pakovanje1 { get; set; }
    }
}