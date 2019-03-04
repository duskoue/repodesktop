using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("StorageReportZenith")]
    public   class StorageReportZenith
    {
        public int ID { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        public DateTime Datum { get; set; }

        public decimal Kolicina { get; set; }

        public decimal KolicinaUlaz { get; set; }

        public decimal KolicinaIzlaz { get; set; }

        public decimal CenaPoDanuZapremina { get; set; }

        public decimal ZapreminaUlaz { get; set; }

        public decimal ZapreminaIzlaz { get; set; }

        public decimal CenaManipulacije { get; set; }
    }
}
