using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Verzija")]
    public class Verzija
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Broj { get; set; }
    }
}
