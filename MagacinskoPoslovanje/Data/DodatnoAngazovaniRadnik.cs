using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("DodatnoAngazovaniRadnik")]
    public  class DodatnoAngazovaniRadnik
    {
        public int ID { get; set; }

        public int Radnik { get; set; }

        public int? RadnoMesto { get; set; }

        [Required]
        [StringLength(20)]
        public string Tabela { get; set; }

        public int TabelaID { get; set; }

        public DateTime? VremePocetka { get; set; }

        public DateTime? VremeZavrsetka { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }
    }
}
