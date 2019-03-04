using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("LogHost")]
    public class LogHost
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Naziv { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public DateTime PoslednjiLog { get; set; }
    }
}
