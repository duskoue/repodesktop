using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("RazduzenjaMB")]
    public  class RazduzenjaMB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string MagacinskiBroj { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CarinskaPrijemnica { get; set; }

        public decimal? RazduzenoKG { get; set; }

        public decimal? RazduzenoKoleta { get; set; }

        public decimal? RazduzenoPaleta { get; set; }

        public decimal? RazduzenaVrednost { get; set; }

        public decimal? RazduzenaZapremina { get; set; }
    }
}
