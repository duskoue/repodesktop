using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("NerazduzeniMB")]
    public class NerazduzeniMB
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string MagacinskiBroj { get; set; }

        [Key]
        [Column(Order = 1)]
        public DateTime Datum { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string Vlasnik { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(256)]
        public string VlasnikNaziv { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(8)]
        public string Skladiste { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(4)]
        public string TIP { get; set; }

        public decimal? BrojKoleta { get; set; }

        public decimal? Tezina { get; set; }

        public decimal? Vrednost { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(1)]
        public string Sort { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrojJ7 { get; set; }

        [StringLength(15)]
        public string Posiljalac { get; set; }

        [StringLength(250)]
        public string PosiljalacNaziv { get; set; }

        public decimal? RazduzenoKG { get; set; }

        public decimal? RazduzenoKoleta { get; set; }

        [StringLength(20)]
        public string RegistracijaVozila { get; set; }

        [StringLength(50)]
        public string BrojTranzitnogDok { get; set; }

        [StringLength(50)]
        public string PodnosilacIsprave { get; set; }

        public decimal? OstajeKG { get; set; }

        public decimal? OstajeKoleta { get; set; }

        public decimal? OstajePaleta { get; set; }

        public decimal? OstajeVrednost { get; set; }

        public decimal? OstajeZapremina { get; set; }
    }
}
