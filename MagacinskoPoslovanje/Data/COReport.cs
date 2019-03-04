using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{

    [Table("COReport")]
    public class COReport
    {
        [Column(TypeName = "date")]
        public DateTime? Datum { get; set; }

        [StringLength(101)]
        public string ImePrezime { get; set; }

        public int? BrojCetvorki { get; set; }

        public int? BrojStavki { get; set; }

        public decimal? Tezina { get; set; }

        public decimal? BrojKoleta { get; set; }

        [Key]
        [StringLength(50)]
        public string Skladiste { get; set; }

    }
}
