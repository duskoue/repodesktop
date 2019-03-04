using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Blokada")]
    public  class Blokada
    {
        public int ID { get; set; }

        public int Sarza { get; set; }

        [Required]
        [StringLength(10)]
        public string Lokacija { get; set; }

        [Required]
        [StringLength(18)]
        public string LPN { get; set; }

        public bool Blokiranje { get; set; }

        public int Razlog { get; set; }

        [Required]
        [StringLength(512)]
        public string RazlogOpis { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }
    }
}
