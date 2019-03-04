using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("IzlazniID")]
    public class IzlazniID
    {
        public IzlazniID()
        {
            Otpremnicas = new HashSet<Otpremnica>();
        }

        [Key]
        [StringLength(50)]
        public string Sifra { get; set; }

        public int TipAmbalaze { get; set; }

        public int? OtpremnicaID { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        [StringLength(10)]
        public string LinijaEkspedicije { get; set; }

        public bool PotvrdjenaLinijaEkspedicije { get; set; }

        public bool Utovareno { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }

        
        public virtual ICollection<Otpremnica> Otpremnicas { get; set; }
    }
}
