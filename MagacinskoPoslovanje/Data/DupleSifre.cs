using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("DupleSifre")]
    public  class DupleSifre
    {
        [Key]
        [StringLength(30)]
        public string Sifra { get; set; }
    }
}
