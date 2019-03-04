using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Parametrizacija")]
    public class Parametrizacija
    {
        public int ID { get; set; }

        public bool TM { get; set; }

        public bool JedinstvenBrCP { get; set; }

        public bool JedinstvenBrCO { get; set; }

        public bool AutoIncrementKontakt { get; set; }

        public bool ZalihePoBrojuKoleta { get; set; }

        [StringLength(10)]
        public string PrefiksMB { get; set; }

        [StringLength(15)]
        public string PodrazumevaniVlasnik { get; set; }
    }
}
