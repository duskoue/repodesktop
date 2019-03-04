using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("KEPU")]
    public class KEPU
    {
        public int ID { get; set; }

        public int Broj { get; set; }

        [Required]
        [StringLength(20)]
        public string Izvor { get; set; }

        public int IzvorID { get; set; }

        [Required]
        [StringLength(20)]
        public string BrojIzvora { get; set; }

        public DateTime Datum { get; set; }

        [Required]
        [StringLength(250)]
        public string Opis { get; set; }

        public int Godina { get; set; }

        public decimal Zaduzenje { get; set; }

        public decimal Razduzenje { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        [StringLength(256)]
        public string NazivKlijenta { get; set; }

        [StringLength(50)]
        public string Grad { get; set; }
    }
}
