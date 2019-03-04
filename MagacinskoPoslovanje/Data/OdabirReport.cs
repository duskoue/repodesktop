using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("OdabirReport")]
    public  class OdabirReport
    {
        [StringLength(101)]
        public string ImePrezime { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Datum { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string Vlasnik { get; set; }

        public int? BrojNaloga { get; set; }

        public int? BrojStavki { get; set; }

        public int? BrojOdabira { get; set; }

        public decimal? Tezina { get; set; }

        public decimal? Kolicina { get; set; }

        public int? BrojNaloga3N { get; set; }

        public int? BrojStavki3N { get; set; }

        public decimal? Tezina3N { get; set; }

        public decimal? Kolicina3N { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public int? BrojOdabira3N { get; set; }

        public int? BrojLokacija { get; set; }

        public int? Viljuskarista { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int KorisnikID { get; set; }
    }
}
