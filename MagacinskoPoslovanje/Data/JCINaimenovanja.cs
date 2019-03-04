using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("JCINaimenovanja")]
    public  class JCINaimenovanja
    {
        public int ID { get; set; }

        public int? CP { get; set; }

        public int? CO { get; set; }

        public int? Prijemnica { get; set; }

        public int? Otpremnica { get; set; }

        public int? RB { get; set; }

        public decimal? BrojKoleta { get; set; }

        [StringLength(400)]
        public string TrgovackiNaziv { get; set; }

        public decimal? BrutoTezina { get; set; }

        [StringLength(50)]
        public string VrstaKoleta { get; set; }

        [StringLength(5)]
        public string Carinarnica { get; set; }
    }
}
