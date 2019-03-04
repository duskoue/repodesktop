using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("KontejnerPrijem")]
    public class KontejnerPrijem
    {
        public int ID { get; set; }

        public int IzvorID { get; set; }

        [Required]
        [StringLength(20)]
        public string Izvor { get; set; }

        public decimal Paleta { get; set; }

        [Required]
        [StringLength(50)]
        public string Kontejner { get; set; }

        public decimal Cena { get; set; }

        [Required]
        [StringLength(15)]
        public string MB { get; set; }
    }
}
