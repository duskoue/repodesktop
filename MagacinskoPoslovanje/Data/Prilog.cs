using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Prilog")]
    public class Prilog
    {
        public int ID { get; set; }

        public int Izvor { get; set; }

        public int IzvorID { get; set; }

        [Required]
        [StringLength(15)]
        public string Klijent { get; set; }

        [StringLength(20)]
        public string Broj { get; set; }

        [Required]
        [StringLength(1000)]
        public string Dokument { get; set; }

        [Required]
        [StringLength(250)]
        public string Opis { get; set; }

        public virtual Prilog Prilog1 { get; set; }

      //  public virtual Prilog Prilog2 { get; set; }
    }
}
