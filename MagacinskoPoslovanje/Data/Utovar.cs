using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Utovar")]
    public class Utovar
    {
        public Utovar()
        {
            UtovarStavkes = new HashSet<UtovarStavke>();
        }

        public int ID { get; set; }

        public int Status { get; set; }

        public DateTime? VremePolaska { get; set; }

        [StringLength(200)]
        public string Relacija { get; set; }

        public DateTime? PocetakUtovara { get; set; }

        public DateTime? KrajUtovara { get; set; }

        public decimal? UkupnaZapremina { get; set; }

        public decimal? UkupnaTezina { get; set; }

        [StringLength(50)]
        public string Vozilo { get; set; }

        [StringLength(50)]
        public string PrikljucnoVozilo { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [StringLength(50)]
        public string Vozac { get; set; }

        public int PlaniranaTura { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public int? PocetnaKM { get; set; }

        [StringLength(20)]
        public string DistributivniCentar { get; set; }

        public int? ZavrsnaKMPrethodneTure { get; set; }

        
        public virtual ICollection<UtovarStavke> UtovarStavkes { get; set; }
    }
}
