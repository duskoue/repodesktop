using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("PrijemReport")]
    public  class PrijemReport
    {
        public int? BrojVlasnika { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Datum { get; set; }

        [StringLength(101)]
        public string ImePrezime { get; set; }

        public decimal? Kolicina { get; set; }

        public decimal? Tezina { get; set; }

        public int? BrojStavki { get; set; }

        [Key]
        [StringLength(50)]
        public string Skladiste { get; set; }
    }
}
