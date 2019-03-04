using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("PodesavanjeZaliha")]
    public  class PodesavanjeZaliha
    {
        public PodesavanjeZaliha()
        {
            PodesavanjeZalihaStavkes = new HashSet<PodesavanjeZalihaStavke>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(15)]
        public string Kontakt { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

       
        public virtual ICollection<PodesavanjeZalihaStavke> PodesavanjeZalihaStavkes { get; set; }

        public virtual Skladiste Skladiste1 { get; set; }
    }
}
