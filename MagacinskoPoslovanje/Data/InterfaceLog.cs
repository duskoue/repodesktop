using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("InterfaceLog")]
    public  class InterfaceLog
    {
        public int ID { get; set; }

        [StringLength(15)]
        public string Vlasnik { get; set; }

        [StringLength(128)]
        public string EksternaSifra2 { get; set; }

        [StringLength(128)]
        public string EksternaSifra { get; set; }

        public DateTime Datum { get; set; }

        public string Poruka { get; set; }

        [StringLength(10)]
        public string Tip { get; set; }

        [StringLength(50)]
        public string Dokument { get; set; }

        public bool Procitano { get; set; }

        public int? IzvorID { get; set; }

        public string RequestXml { get; set; }

    }
}
