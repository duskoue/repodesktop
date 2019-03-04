using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Zaliha")]
    public class Zaliha
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Sarza { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string Lokacija { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(18)]
        public string LPN { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        public decimal Kolicina { get; set; }

        public decimal RezervisanaKolicina { get; set; }

        public decimal IzabranaKolicina { get; set; }

        public decimal BlokiranaKolicina { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        //[Column(TypeName = "timestamp")]
        //[MaxLength(8)]
        //[Timestamp]
        public byte[] RowVersion { get; set; }

        public int StatusZalihe { get; set; }

        [StringLength(50)]
        public string EksternoSkladiste { get; set; }

        public decimal? BrojKoleta { get; set; }

        public virtual Artikal Artikal { get; set; }

        public virtual LokacijaKlijenta LokacijaKlijenta { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }
    }
}
