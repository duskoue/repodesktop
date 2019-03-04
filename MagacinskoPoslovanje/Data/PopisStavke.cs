using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("PopisStavke")]
    public  class PopisStavke
    {
        public int ID { get; set; }

        public int? Popis { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        public int Sarza { get; set; }

        [Required]
        [StringLength(10)]
        public string Lokacija { get; set; }

        [Required]
        [StringLength(18)]
        public string LPN { get; set; }

        [StringLength(50)]
        public string EksternoSkladiste { get; set; }

        public decimal Kolicina { get; set; }

        public decimal SistemskaKolicina { get; set; }

        public decimal KolicinaPodesavanja { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        [StringLength(50)]
        public string Napomena { get; set; }

        public virtual Popi Popi { get; set; }
    }
}
