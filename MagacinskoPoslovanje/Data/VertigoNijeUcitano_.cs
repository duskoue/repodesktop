using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("VertigoNijeUcitano$")]
    public  class VertigoNijeUcitano_
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [StringLength(255)]
        public string Ident { get; set; }

        [StringLength(255)]
        public string Barkod { get; set; }

        [StringLength(255)]
        public string naziv { get; set; }

        [StringLength(255)]
        public string SifraVlasnika { get; set; }

        [Column(TypeName = "numeric")]
        public decimal? Kolicina { get; set; }

    }
}
