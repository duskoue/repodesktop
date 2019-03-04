using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("ZaduzenjaMB")]
    public class ZaduzenjaMB
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string MagacinskiBroj { get; set; }

        public decimal? SumKoleta { get; set; }

        public decimal? SumTezina { get; set; }

        public decimal? SumVrednost { get; set; }

        public decimal? SumZapremina { get; set; }
    }
}
