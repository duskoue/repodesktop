using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("TranZal")]
    public class TranZal
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        public int? Sarza { get; set; }

        public decimal? Kol { get; set; }
    }
}
