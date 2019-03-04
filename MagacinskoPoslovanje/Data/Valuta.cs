using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Valuta")]
    public class Valuta
    {
        public Valuta()
        {
            CarinskaOtpremnicaStavkes = new HashSet<CarinskaOtpremnicaStavke>();
            CarinskaPrijemnicaStavkes = new HashSet<CarinskaPrijemnicaStavke>();
        }

        [Key]
        [StringLength(3)]
        public string Sifra { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(5)]
        public string Drzava { get; set; }

       
        public virtual ICollection<CarinskaOtpremnicaStavke> CarinskaOtpremnicaStavkes { get; set; }

        
        public virtual ICollection<CarinskaPrijemnicaStavke> CarinskaPrijemnicaStavkes { get; set; }
    }
}