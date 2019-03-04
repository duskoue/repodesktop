using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("UlaziIzlazi")]
    public class UlaziIzlazi
    {
        [Key]
        [Column(Order = 0)]
        public DateTime Datum { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(256)]
        public string Firma { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(8)]
        public string Skladiste { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(13)]
        public string UsklIskl { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int BrIskl { get; set; }

        [StringLength(250)]
        public string Prevoznik { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(11)]
        public string PojedinacnoZbirno { get; set; }

        [Key]
        [Column(Order = 6)]
        public string OpisRobe { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal Kilaza { get; set; }

        [Key]
        [Column(Order = 8)]
        [StringLength(6)]
        public string VrstaRobe { get; set; }

        public decimal? Koleta { get; set; }
    }
}
