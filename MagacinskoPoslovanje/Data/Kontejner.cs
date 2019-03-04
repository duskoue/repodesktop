using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Kontejner")]
    public class Kontejner
    {
        [Key]
        [StringLength(50)]
        public string Sifra { get; set; }

        public decimal Cena { get; set; }
    }
}
