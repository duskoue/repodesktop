using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("CPReport")]
    public  class CPReport
    {
        [StringLength(101)]
        public string ImePrezime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Datum { get; set; }

        public int? BrojStavkiBorderoa { get; set; }

        public int? BrojSedmica { get; set; }

        public decimal? BrojKoleta { get; set; }

        public decimal? Tezina { get; set; }

        [Key]
        [StringLength(50)]
        public string Skladiste { get; set; }
    }
}
