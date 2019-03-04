using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MagacinskoPoslovanje.Data
{
  public  class SifarnikEntiteta
    {


        public SifarnikEntiteta()
        {
            Brojacs = new HashSet<Brojac>();
            SifarnikEntitetaTips = new HashSet<SifarnikEntitetaTip>();
        }

        #region PROPERTY CLASS

        public int ID { get; set; }

        [Required]
        [StringLength(32)]
        public string Naziv { get; set; }

        #endregion

        #region PROPERTY NAVIGACIJA

        public virtual ICollection<Brojac> Brojacs { get; set; }

       
        public virtual ICollection<SifarnikEntitetaTip> SifarnikEntitetaTips { get; set; }

        #endregion
    }
}
