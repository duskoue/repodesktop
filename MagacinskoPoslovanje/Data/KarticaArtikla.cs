using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("KarticaArtikla")]
    public class KarticaArtikla
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime Datum { get; set; }

        [StringLength(20)]
        public string BrojDokumenta { get; set; }

        [StringLength(8000)]
        public string Stavka { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(5)]
        public string Tip { get; set; }

        [Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Sort { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(30)]
        public string Sifra { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(15)]
        public string SifraVlasnika { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(256)]
        public string Naziv { get; set; }

        public decimal? Kolicina { get; set; }

        [Key]
        [Column(Order = 7)]
        [StringLength(8)]
        public string Skladiste { get; set; }

        [StringLength(128)]
        public string EksternaSifra { get; set; }

        [StringLength(256)]
        public string NazivKupca { get; set; }

        [StringLength(50)]
        public string Serija { get; set; }

        [StringLength(50)]
        public string EksternoSkladiste { get; set; }

        [StringLength(50)]
        public string SifraProVarijanta { get; set; }
    }
}
