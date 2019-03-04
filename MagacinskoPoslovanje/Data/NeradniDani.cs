using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{

    [Table("NeradniDani")]
    public  class NeradniDani
    {
        public int ID { get; set; }

       [Column(TypeName = "timestamp")]
        public DateTime Datum { get; set; }

     [Column(TypeName = "timestamp")]
        public DateTime SledeciRadni { get; set; }

        [Column(TypeName = "timestamp")]
        public DateTime PrethodniRadni { get; set; }

        [StringLength(50)]
        public string Praznik { get; set; }
    }
}
