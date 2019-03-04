using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("PodesavanjaFormi")]
    public class PodesavanjaFormi
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Forma { get; set; }

        [Required]
        [StringLength(50)]
        public string Tag { get; set; }

        [Required]
        [StringLength(50)]
        public string Osobina { get; set; }

        [Required]
        [StringLength(50)]
        public string Vrednost { get; set; }
    }
}
