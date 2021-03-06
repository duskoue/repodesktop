﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("CarinskaIspostava")]
    public class CarinskaIspostava
    {
        public CarinskaIspostava()
        {
            CarinskaPrijemnicas = new HashSet<CarinskaPrijemnica>();
        }

        [Key]
        [StringLength(5)]
        public string Sifra { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

       
        public virtual ICollection<CarinskaPrijemnica> CarinskaPrijemnicas { get; set; }
    }

}
