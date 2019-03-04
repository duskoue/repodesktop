using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("ArtikliIzlaz")]
    public class ArtikliIzlaz
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        public decimal? Izlaz { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string Skladiste { get; set; }
    }
}
