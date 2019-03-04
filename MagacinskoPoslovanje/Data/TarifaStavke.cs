using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("TarifaStavke")]
    public class TarifaStavke
    {
        public int ID { get; set; }

        public int Tarifa { get; set; }

        [Required]
        [StringLength(10)]
        public string TipTroska { get; set; }

        [Required]
        [StringLength(50)]
        public string Opis { get; set; }

        [Required]
        [StringLength(10)]
        public string OsnovaTroska { get; set; }

        public decimal Cena { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public decimal? KolicinaOd { get; set; }

        public decimal? KolicinaDo { get; set; }

        [StringLength(50)]
        public string Kontejner { get; set; }

        public virtual Tarifa Tarifa1 { get; set; }
    }
}
