using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("NalogZaPakovanje")]
    public class NalogZaPakovanje
    {
        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string Broj { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Required]
        [StringLength(4)]
        public string JM { get; set; }

        public decimal UkupnaKolicina { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        [StringLength(50)]
        public string EksterniKorisnik { get; set; }

        public int? SastavnicaID { get; set; }

        [StringLength(128)]
        public string NNEksternaSifra { get; set; }

        [StringLength(128)]
        public string NNEksternaSifraStavke { get; set; }
    }
}
