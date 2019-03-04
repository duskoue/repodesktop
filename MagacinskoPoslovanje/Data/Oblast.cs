using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Oblast")]
    public  class Oblast
    {
        public Oblast()
        {
            Zonas = new HashSet<Zona>();
        }

        [Key]
        [StringLength(10)]
        public string Sifra { get; set; }

        [Required]
        [StringLength(50)]
        public string Opis { get; set; }

     
        public virtual ICollection<Zona> Zonas { get; set; }
    }
}
