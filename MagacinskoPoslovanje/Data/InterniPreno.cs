using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("InterniPrenos")]
    public class InterniPreno
    {
        public InterniPreno()
        {
            InterniPrenosStavkes = new HashSet<InterniPrenosStavke>();
        }

        public int ID { get; set; }

        public DateTime Datum { get; set; }

        public int Status { get; set; }

        [Required]
        [StringLength(15)]
        public string SaVlasnika { get; set; }

        //[Required]
        //[StringLength(15)]
        public string NaVlasnika { get; set; }

        //[Required]
        //[StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        //[Column(TypeName = "timestamp")]
        //[MaxLength(8)]
        //[Timestamp]
        public byte[] RowVersion { get; set; }

        //[StringLength(20)]
        public string Broj { get; set; }

        //[StringLength(128)]
        public string EksternaSifra { get; set; }

        //[StringLength(128)]
        public string EksternaSifra2 { get; set; }

        //[StringLength(400)]
        public string Napomena { get; set; }

        //[StringLength(50)]
        public string KreatorEmail { get; set; }

        public bool Poslato { get; set; }

        //[StringLength(50)]
        public string EksternoSkladisteSa { get; set; }

        //[StringLength(50)]
        public string EksternoSkladisteNa { get; set; }

        public virtual Kontakt Kontakt { get; set; }

        public virtual Kontakt Kontakt1 { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Skladiste Skladiste1 { get; set; }


        public virtual ICollection<InterniPrenosStavke> InterniPrenosStavkes { get; set; }
    }
}
