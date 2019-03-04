using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Popis")]
    public class Popi
    {
        public Popi()
        {
            PopisListas = new HashSet<PopisLista>();
            PopisStavkes = new HashSet<PopisStavke>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Broj { get; set; }

        [Required]
        [StringLength(15)]
        public string Vlasnik { get; set; }

        public DateTime Datum { get; set; }

        public bool SviArtikli { get; set; }

        public bool GenerisiPodesavanja { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public bool GenerisanaPodesavanja { get; set; }

        public virtual Kontakt Kontakt { get; set; }


        public virtual ICollection<PopisLista> PopisListas { get; set; }


        public virtual ICollection<PopisStavke> PopisStavkes { get; set; }
    }
}

    
