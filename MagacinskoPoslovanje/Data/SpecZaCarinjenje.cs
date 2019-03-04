using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("SpecZaCarinjenje")]
    public  class SpecZaCarinjenje
    {
        public SpecZaCarinjenje()
        {
            SpecZaCarinjenjeStavkes = new HashSet<SpecZaCarinjenjeStavke>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Broj { get; set; }

        public int Mesec { get; set; }

        public int Godina { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

       
        public virtual ICollection<SpecZaCarinjenjeStavke> SpecZaCarinjenjeStavkes { get; set; }
    }
}
