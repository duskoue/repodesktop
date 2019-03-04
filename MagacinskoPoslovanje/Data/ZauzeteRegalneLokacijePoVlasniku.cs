using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("ZauzeteRegalneLokacijePoVlasniku")]
    public class ZauzeteRegalneLokacijePoVlasniku
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string Lokacija { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Key]
        [Column(Order = 2)]
        public decimal PaletniKapacitet { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(8)]
        public string Skladiste { get; set; }
    }
}
