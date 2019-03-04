using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Grupa")]
    public class Grupa
    {
        public Grupa()
        {
            GrupaStavkes = new HashSet<GrupaStavke>();
        }

        public int ID { get; set; }

        [StringLength(250)]
        public string Opis { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public int Status { get; set; }

        public int? ZapoceoRadnik { get; set; }

        public DateTime? VremePocetka { get; set; }

        public DateTime? VremeZavrsetka { get; set; }

        public int TipGrupe { get; set; }

        //[Column(TypeName = "timestamp")]
        //[MaxLength(8)]
        //[Timestamp]
        public byte[] RowVersion { get; set; }

        [StringLength(128)]
        public string EksternaSifra { get; set; }

        [StringLength(20)]
        public string RegistracijaVozila { get; set; }

        [StringLength(250)]
        public string Vozac { get; set; }

       
        public virtual ICollection<GrupaStavke> GrupaStavkes { get; set; }
    }
}
