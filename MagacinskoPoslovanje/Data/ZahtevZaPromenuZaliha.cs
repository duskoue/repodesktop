using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("ZahtevZaPromenuZaliha")]
    public class ZahtevZaPromenuZaliha
    {
        public int ID { get; set; }

        public int Status { get; set; }

        public int? Godina { get; set; }

        [StringLength(20)]
        public string BrojDokumenta { get; set; }

        public DateTime? Datum { get; set; }

        public DateTime? DatumKnjizenja { get; set; }

        [StringLength(100)]
        public string Opis { get; set; }

        [StringLength(50)]
        public string EksternaSifraStavke { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        public decimal Kolicina { get; set; }

        [Required]
        [StringLength(4)]
        public string JM { get; set; }

        [StringLength(3)]
        public string TipKretanja { get; set; }

        [StringLength(50)]
        public string EksternoSkladiste { get; set; }

        [StringLength(50)]
        public string SerijskiBroj { get; set; }

        [StringLength(50)]
        public string Serija { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        //[Column(TypeName = "timestamp")]
        //[MaxLength(8)]
        //[Timestamp]
        public byte[] RowVersion { get; set; }

        [StringLength(10)]
        public string PurchaseOrderId { get; set; }

        [StringLength(5)]
        public string PurchaseOrderItemNumber { get; set; }

        [StringLength(10)]
        public string DeliveryId { get; set; }

        [StringLength(6)]
        public string DeliveryItemNumber { get; set; }

        [StringLength(15)]
        public string VlasnikPrijema { get; set; }

        [StringLength(50)]
        public string EksternoSkladistePrijema { get; set; }

        [StringLength(50)]
        public string SerijaPrijema { get; set; }

        [StringLength(50)]
        public string SerijskiBrojUIID { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }
    }
}
