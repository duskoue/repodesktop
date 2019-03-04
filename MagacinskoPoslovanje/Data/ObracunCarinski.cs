using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("ObracunCarinski")]
    public  class ObracunCarinski
    {
        public int ID { get; set; }

        [Required]
        [StringLength(15)]
        public string SifraVlasnika { get; set; }

        [Required]
        [StringLength(15)]
        public string MB { get; set; }

        public int Tarifa { get; set; }

        public int TarifaStavka { get; set; }

        [Required]
        [StringLength(10)]
        public string TipTroska { get; set; }

        [Required]
        [StringLength(10)]
        public string OsnovaTroska { get; set; }

        [Required]
        [StringLength(4)]
        public string JM { get; set; }

        public decimal Cena { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime Datum { get; set; }

        public int Nedelja { get; set; }

        [StringLength(100)]
        public string Opis { get; set; }

        public decimal KolicinaPrijem { get; set; }

        public DateTime SledeciObracun { get; set; }

        public decimal KolicinaTrenutno { get; set; }

        public decimal PaletaPrijem { get; set; }

        public decimal PaletaTrenutno { get; set; }

        [StringLength(50)]
        public string KontejnerTip { get; set; }

        public decimal? KontejnerKolicina { get; set; }

        public decimal? KontejnerCena { get; set; }

        public decimal BrutoTezina { get; set; }

        public bool Izaslo { get; set; }

        public bool Fakturisano { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public decimal? Zapremina { get; set; }
    }
}
