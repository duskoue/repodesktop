using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Obracun")]
    public class Obracun
    {
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Opis { get; set; }

        public int Status { get; set; }

        [Required]
        [StringLength(15)]
        public string SifraVlasnika { get; set; }

        [StringLength(30)]
        public string SifraArtikla { get; set; }

        public int? Sarza { get; set; }

        [StringLength(18)]
        public string LPN { get; set; }

        public int? Tarifa { get; set; }

        public int? TarifaStavka { get; set; }

        public DateTime ObracunOd { get; set; }

        public DateTime ObracunDo { get; set; }

        [StringLength(20)]
        public string Izvor { get; set; }

        public int? IzvorID { get; set; }

        public decimal Iznos { get; set; }

        public decimal Cena { get; set; }

        public decimal Kolicina { get; set; }

        [StringLength(10)]
        public string Osnova { get; set; }

        public decimal GenerisanIznos { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        [Required]
        [StringLength(4)]
        public string PodrazumevanaJM { get; set; }

        public decimal KolicinaPodrazumevanaJM { get; set; }
    }
}
