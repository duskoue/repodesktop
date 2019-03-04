using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("ZauzeteRegalneLokacijePoVlasnikuSUM")]
    public class ZauzeteRegalneLokacijePoVlasnikuSUM
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        public decimal? Paleta { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string Skladiste { get; set; }
    }
}
