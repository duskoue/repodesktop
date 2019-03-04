using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("StornoDokumenta")]
    public  class StornoDokumenta
    {
        public int ID { get; set; }

        [StringLength(128)]
        public string BrojDokumenta { get; set; }

        public int? Godina { get; set; }

        public DateTime? DatumKnjizenja { get; set; }

        [StringLength(128)]
        public string StavkaDokumenta { get; set; }

        [StringLength(25)]
        public string VrstaKretanja { get; set; }

        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        public decimal? Kolicina { get; set; }

        [StringLength(4)]
        public string JM { get; set; }

        [StringLength(10)]
        public string Postrojenje { get; set; }

        [StringLength(10)]
        public string EksternoSkladiste { get; set; }

        [StringLength(50)]
        public string Serija { get; set; }

        [StringLength(10)]
        public string PostrojenjePrijema { get; set; }

        [StringLength(10)]
        public string EksternoSkladistePrijema { get; set; }

        [StringLength(50)]
        public string SerijaPrijem { get; set; }

        [StringLength(50)]
        public string TekstStavke { get; set; }

        public bool IndikatorPrenosaZaliha { get; set; }

        public bool Storniran { get; set; }

        [StringLength(20)]
        public string Entitet { get; set; }

        public int? EntitetStavkaID { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public bool Poslato { get; set; }

        public int? EntitetID { get; set; }
    }
}
