using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Usluga")]
    public class Usluga
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public int Status { get; set; }

        [Required]
        [StringLength(15)]
        public string Vlasnik { get; set; }

        public DateTime Datum { get; set; }

        public int VrstaUsluge { get; set; }

        public decimal Cena { get; set; }

        public decimal Kolicina { get; set; }

        [StringLength(4)]
        public string JedinicaMere { get; set; }

        public decimal Iznos { get; set; }

        [StringLength(250)]
        public string Napomena { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public virtual Kontakt Kontakt { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }
    }
}
