using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("MagacinskaKnjiga")]
    public  class MagacinskaKnjiga
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string MagacinskiBroj { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime Datum { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(15)]
        public string Vlasnik { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(256)]
        public string Naziv { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(8)]
        public string Skladiste { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(5)]
        public string TIP { get; set; }

        [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RB { get; set; }

        [Key]
        [Column(Order = 8)]
        public string Dokument { get; set; }

        [Key]
        [Column(Order = 9)]
        public decimal BrojKoleta { get; set; }

        [Key]
        [Column(Order = 10)]
        public decimal Tezina { get; set; }

        [Key]
        [Column(Order = 11)]
        public decimal Vrednost { get; set; }

        [Key]
        [Column(Order = 12)]
        [StringLength(3)]
        public string Valuta { get; set; }

        [Key]
        [Column(Order = 13)]
        [StringLength(1)]
        public string Sort { get; set; }

        [Key]
        [Column(Order = 14)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrojJ7 { get; set; }

        [StringLength(250)]
        public string Posiljalac { get; set; }

        [StringLength(250)]
        public string Primalac { get; set; }

        [StringLength(10)]
        public string BorderoBroj { get; set; }

        [StringLength(15)]
        public string Spediter { get; set; }

        [StringLength(50)]
        public string EksternaSifra { get; set; }

        [StringLength(20)]
        public string BrojCO { get; set; }
    }
}
