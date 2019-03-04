using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("EksterniKorisnik")]
    public  class EksterniKorisnik
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Sifra { get; set; }

        [StringLength(100)]
        public string ImePrezime { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        public bool SAPKorisnik { get; set; }
    }
}
