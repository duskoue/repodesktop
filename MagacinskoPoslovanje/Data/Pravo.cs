using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Pravo")]
    public class Pravo
    {
        public Pravo()
        {
            Rolas = new HashSet<Rola>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(32)]
        public string Naziv { get; set; }

        [StringLength(250)]
        public string Opis { get; set; }

       
        public virtual ICollection<Rola> Rolas { get; set; }
    }
}
