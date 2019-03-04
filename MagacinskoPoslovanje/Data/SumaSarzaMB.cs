using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("SumaSarzaMB")]
    public  class SumaSarzaMB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [StringLength(50)]
        public string MagacinskiBroj { get; set; }

        public decimal? KolicinaSUM { get; set; }

        public DateTime? DatumKreiranja { get; set; }

        [StringLength(4)]
        public string JM { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Zapremina { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string Skladiste { get; set; }
    }
}
