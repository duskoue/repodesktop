using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("PodesavanjeZalihaStavke")]
    public   class PodesavanjeZalihaStavke
    {
        public int ID { get; set; }

        public int PodesavanjeZaliha { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        public int Sarza { get; set; }

        [Required]
        [StringLength(10)]
        public string Lokacija { get; set; }

        [Required]
        [StringLength(18)]
        public string LPN { get; set; }

        public int Razlog { get; set; }

        public decimal TrenutnaKolicina { get; set; }

        public decimal KolicinaPodesavanja { get; set; }

        public decimal CiljnaKolicina { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }

        public virtual Artikal Artikal { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual PodesavanjeZaliha PodesavanjeZaliha1 { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }

        public virtual Skladiste Skladiste1 { get; set; }
    }
}
