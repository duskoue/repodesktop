using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("SerijskiBroj")]
    public  class SerijskiBroj
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string SerijskiBrojKartice { get; set; }

        [StringLength(50)]
        public string BrojTelefona { get; set; }

        [StringLength(18)]
        public string LPN { get; set; }

        public bool Spakovano { get; set; }

        [StringLength(30)]
        public string SifraArtikla { get; set; }

        [StringLength(50)]
        public string Paket { get; set; }

        public int? SastavnicaID { get; set; }

        [StringLength(50)]
        public string OdabranPaket { get; set; }

        public bool Rezervisan { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        [StringLength(256)]
        public string NazivArtikla { get; set; }

        [StringLength(18)]
        public string GenerisanLPN { get; set; }

        [StringLength(50)]
        public string SerijskiBrojKartice2 { get; set; }

        [StringLength(50)]
        public string BrojTelefona2 { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }
    }
}
