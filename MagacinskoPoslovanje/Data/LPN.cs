using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("LPN")]
    public class LPN
    {
        public int ID { get; set; }

        [Required]
        [StringLength(5)]
        public string Prefiks { get; set; }

        [StringLength(50)]
        public string Sifra { get; set; }

        public bool Zatorena { get; set; }
    }
}
