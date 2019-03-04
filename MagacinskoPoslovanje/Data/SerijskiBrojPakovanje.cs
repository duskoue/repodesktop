using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("SerijskiBrojPakovanje")]
    public class SerijskiBrojPakovanje
    {
        public int? SastavnicaID { get; set; }

        [StringLength(18)]
        public string LPN { get; set; }

        [StringLength(50)]
        public string Paket { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Promenio { get; set; }

        public int? BrojKartica { get; set; }

        [StringLength(30)]
        public string SifraArtikla { get; set; }

        [StringLength(256)]
        public string NazivArtikla { get; set; }

        public int? Godina { get; set; }

        public int? Mesec { get; set; }
    }
}
