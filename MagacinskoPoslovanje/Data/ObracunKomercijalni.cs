using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("ObracunKomercijalni")]
    public class ObracunKomercijalni
    {
        public int ID { get; set; }

        [Required]
        [StringLength(15)]
        public string SifraVlasnika { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public decimal Cena { get; set; }

        public DateTime Datum { get; set; }

        public bool Fakturisano { get; set; }

        public int Tarifa { get; set; }

        public int TarifaStavka { get; set; }

        [Required]
        [StringLength(10)]
        public string TipTroska { get; set; }

        [Required]
        [StringLength(10)]
        public string OsnovaTroska { get; set; }

        [StringLength(10)]
        public string Lokacija { get; set; }

        public decimal PaletnaMesta { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public decimal? Tezina { get; set; }

        public int? PrijemnicaStavka { get; set; }

        public int? Sarza { get; set; }

        public DateTime? SledeciObracun { get; set; }

        [StringLength(15)]
        public string MB { get; set; }

        public decimal? PaletaTrenutno { get; set; }

        public int? StaraSarza { get; set; }

        [StringLength(15)]
        public string TrenutniMB { get; set; }

        [StringLength(3)]
        public string Valuta { get; set; }
    }
}
