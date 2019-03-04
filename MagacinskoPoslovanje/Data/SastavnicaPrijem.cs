using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("SastavnicaPrijem")]
    public  class SastavnicaPrijem
    {
        public int ID { get; set; }

        public int SastavnicaID { get; set; }

        public int PrijemnicaID { get; set; }
    }
}
