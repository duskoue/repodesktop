using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("CrossDock")]
    public class CrossDock
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string EksternaSifra { get; set; }

        public int? EksterniID { get; set; }

        [StringLength(50)]
        public string VrstaRobe { get; set; }

        [StringLength(50)]
        public string PosiljalacNaziv { get; set; }

        [StringLength(50)]
        public string PrimalacNaziv { get; set; }

        [StringLength(20)]
        public string RegistracijaVozila { get; set; }

        [StringLength(50)]
        public string Vozac { get; set; }

        public decimal? Tezina { get; set; }

        public decimal? BrojPaleta { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        public bool PrijemZavrsen { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public decimal? BrojKoleta { get; set; }
    }
}
