using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Zona")]
    public class Zona
    {
        public Zona()
        {
            Lokacijas = new HashSet<Lokacija>();
        }

        [Key]
        [StringLength(10)]
        public string Sifra { get; set; }

        [Required]
        [StringLength(50)]
        public string Opis { get; set; }

        [StringLength(10)]
        public string Oblast { get; set; }

        [StringLength(30)]
        public string EksternaSifra { get; set; }

        
        public virtual ICollection<Lokacija> Lokacijas { get; set; }

        public virtual Oblast Oblast1 { get; set; }
    }
}