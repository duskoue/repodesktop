using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("ZaliheZaPremestajTemp")]
    public  class ZaliheZaPremestajTemp
    {
        [Required]
        [StringLength(50)]
        public string Lokacija { get; set; }

        [Required]
        [StringLength(50)]
        public string LPN { get; set; }

        [Required]
        [StringLength(50)]
        public string SifraArtikla { get; set; }

        [Required]
        [StringLength(50)]
        public string Kolicina { get; set; }

        [StringLength(50)]
        public string Sarza { get; set; }

        public int ID { get; set; }
    }
}
