using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Tarifa")]
    public class Tarifa
    {
        public Tarifa()
        {
            Artikals = new HashSet<Artikal>();
            TarifaStavkes = new HashSet<TarifaStavke>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(1)]
        public string TipPerioda { get; set; }

        public int? PeriodPS { get; set; }

        public int? PeriodLZ { get; set; }

        public int? DanMesecnogPreseka { get; set; }

        public decimal? ProcenatPrePreseka { get; set; }

        public decimal? ProcenatPoslePreseka { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        [StringLength(3)]
        public string Valuta { get; set; }

        [StringLength(8)]
        public string Skladiste { get; set; }

       
        public virtual ICollection<Artikal> Artikals { get; set; }

        
        public virtual ICollection<TarifaStavke> TarifaStavkes { get; set; }
    }
}