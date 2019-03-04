using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("PorukaKnjizenja")]
    public  class PorukaKnjizenja
    {
        public int ID { get; set; }

        [StringLength(25)]
        public string NabavniNalog { get; set; }

        [StringLength(25)]
        public string NabavniNalogStavke { get; set; }

        [StringLength(25)]
        public string ProizvodniNalog { get; set; }

        [StringLength(25)]
        public string EksterniPrenos { get; set; }

        [StringLength(25)]
        public string EksterniPrenosStavke { get; set; }

        [StringLength(25)]
        public string BrojIsporuke { get; set; }

        [StringLength(25)]
        public string BrojIsporukeStavke { get; set; }

        [StringLength(25)]
        public string StornoDokumenta { get; set; }

        [StringLength(25)]
        public string StornoDokumentaStavke { get; set; }

        [StringLength(10)]
        public string TipPoruke { get; set; }

        [StringLength(10)]
        public string BrojPoruke { get; set; }

        public string TekstPoruke { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        [StringLength(25)]
        public string StornoDokumentaGodina { get; set; }

        [StringLength(25)]
        public string BrojDokumenta { get; set; }

        [StringLength(25)]
        public string StavkaDokumenta { get; set; }

        [StringLength(25)]
        public string GodinaDokumenta { get; set; }

        [StringLength(25)]
        public string KlasaPoruke { get; set; }

        [StringLength(50)]
        public string MatDocOldId { get; set; }

        [StringLength(50)]
        public string MatDocNewId { get; set; }

        [StringLength(128)]
        public string EksternaSifra { get; set; }

        [StringLength(20)]
        public string Izvor { get; set; }

        public int? IzvorID { get; set; }
    }
}
