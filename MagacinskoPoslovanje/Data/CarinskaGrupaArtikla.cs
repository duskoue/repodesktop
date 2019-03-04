using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("CarinskaGrupaArtikla")]
    public class CarinskaGrupaArtikla
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        [Required]
        [StringLength(15)]
        public string Vlasnik { get; set; }

        public int PoslednjaSifra { get; set; }

        [StringLength(10)]
        public string PodrazumevanaLokacija { get; set; }
    }
}
