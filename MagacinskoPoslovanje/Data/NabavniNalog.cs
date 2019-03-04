using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("NabavniNalog")]
    public class NabavniNalog
    {
        public NabavniNalog()
        {
            NabavniNalogStavkes = new HashSet<NabavniNalogStavke>();
        }

        public int ID { get; set; }

        [StringLength(128)]
        public string EksternaSifra { get; set; }

        public DateTime Datum { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        [StringLength(4)]
        public string ProcessingTypeCode { get; set; }

        [StringLength(32)]
        public string SellerPartyID { get; set; }

        [StringLength(32)]
        public string ResponsiblePurchasingGroupPartyID { get; set; }

        public string ContentText { get; set; }

        [StringLength(128)]
        public string EksternaSifra2 { get; set; }

        public bool NalogZaPakovanje { get; set; }

       
        public virtual ICollection<NabavniNalogStavke> NabavniNalogStavkes { get; set; }
    }
}
