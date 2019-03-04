using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("TransakcijaZaliha")]
    public class TransakcijaZaliha
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string TipTransakcije { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        public int? Sarza { get; set; }

        [StringLength(10)]
        public string SaLokacije { get; set; }

        [StringLength(18)]
        public string SaPJ { get; set; }

        [Required]
        [StringLength(10)]
        public string NaLokaciju { get; set; }

        [Required]
        [StringLength(18)]
        public string NaPJ { get; set; }

        [Required]
        [StringLength(20)]
        public string Izvor { get; set; }

        public int IzvorID { get; set; }

        [Required]
        [StringLength(50)]
        public string OpisTransakcije { get; set; }

        public DateTime VremeTransakcije { get; set; }

        [Required]
        [StringLength(10)]
        public string Status { get; set; }

        public decimal Kolicina { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        [StringLength(15)]
        public string MB { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }
    }
}
