using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("NalogLogPodaci")]
    public  class NalogLogPodaci
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Otpremnica { get; set; }

        public decimal? Tezina { get; set; }

        public decimal? Kolicina { get; set; }
    }
}
