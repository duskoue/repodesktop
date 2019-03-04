using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("EksterniPrenos")]
    public class EksterniPreno
    {
        public int ID { get; set; }

        [Required]
        [StringLength(25)]
        public string BrojRezervacije { get; set; }

        public DateTime Datum { get; set; }

        [Required]
        [StringLength(256)]
        public string NazivKupca { get; set; }

        [Required]
        [StringLength(50)]
        public string Grad { get; set; }

        [Required]
        [StringLength(256)]
        public string Adresa { get; set; }

        [StringLength(10)]
        public string PostanskiBroj { get; set; }

        [StringLength(128)]
        public string KontaktOsoba { get; set; }

        [StringLength(20)]
        public string Telefon { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        [StringLength(50)]
        public string EksterniKorisnik { get; set; }
    }
}
