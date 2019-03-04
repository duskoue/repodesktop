using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Mesto")]
    public class Mesto
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Naziv { get; set; }

        [StringLength(10)]
        public string PostanskiBroj { get; set; }
    }
}
