using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("ImportSerijskihBrojevaTemp")]
    public class ImportSerijskihBrojevaTemp
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string LPN { get; set; }

        [StringLength(50)]
        public string SerijskiBroj { get; set; }

        [StringLength(50)]
        public string Atribut1 { get; set; }

        [StringLength(30)]
        public string ArtikalSifra { get; set; }
    }
}
