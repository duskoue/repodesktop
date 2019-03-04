using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("RazdvajanjePrijema")]
    public class RazdvajanjePrijema
    {
        public RazdvajanjePrijema()
        {
            RazdvajanjePrijemaStavkes = new HashSet<RazdvajanjePrijemaStavke>();
        }

        public int ID { get; set; }

        public DateTime Datum { get; set; }

        [Required]
        [StringLength(15)]
        public string MagacinskiBroj { get; set; }

        public int CarinskaPrijemnica { get; set; }

        [Required]
        [StringLength(15)]
        public string Vlasnik { get; set; }

        [Required]
        [StringLength(50)]
        public string Roba { get; set; }

        public decimal UkupnoKoleta { get; set; }

        public decimal UkupnaTezina { get; set; }

        public bool Povezano { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        [StringLength(15)]
        public string BorderoBroj { get; set; }

        public int? BrojJ7 { get; set; }

        [StringLength(50)]
        public string BrojDokumenta { get; set; }

        public int? PrijemnicaID { get; set; }

        public int? BorderoID { get; set; }

        public virtual CarinskaPrijemnica CarinskaPrijemnica1 { get; set; }

        public virtual Kontakt Kontakt { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

       
        public virtual ICollection<RazdvajanjePrijemaStavke> RazdvajanjePrijemaStavkes { get; set; }
    }
}
