using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("IzvestajSkladistenja")]
    public class IzvestajSkladistenja
    {
        public int ID { get; set; }

        public DateTime Datum { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        public decimal? PaletaZona1 { get; set; }

        public decimal? PaletaZona2 { get; set; }

        public decimal? PaletaZona3 { get; set; }

        public decimal? PaletaZona4 { get; set; }

        public int? BrojStavkiPrijema { get; set; }

        public int? BrojOdabira { get; set; }

        public decimal? PaletaPrimljeno { get; set; }

        public decimal? PaletaIzdato { get; set; }

        public int? KolicinaZalepljenihDeklaracija { get; set; }

        public int? BrojOtpremljenihNaloga { get; set; }
    }
}
