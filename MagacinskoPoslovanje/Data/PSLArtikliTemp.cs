using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("PSLArtikliTemp")]
    public  class PSLArtikliTemp
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string SifraArtikla { get; set; }

        [StringLength(400)]
        public string NazvHR { get; set; }

        [StringLength(50)]
        public string JM { get; set; }

        [StringLength(50)]
        public string EDMMaterial { get; set; }

        [StringLength(400)]
        public string NazivENG { get; set; }

        [StringLength(50)]
        public string Tip { get; set; }

        [StringLength(50)]
        public string PracenjePoSerijskomBroju { get; set; }
    }
}
