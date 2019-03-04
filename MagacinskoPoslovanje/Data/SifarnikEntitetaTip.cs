using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace MagacinskoPoslovanje.Data
{
    [Table("SifarnikEntitetaTip")]
    public class SifarnikEntitetaTip
    {

        public SifarnikEntitetaTip()
        {
            Sifarniks = new HashSet<Sifarnik>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        #region PROPERTY CLASS

        public int ID { get; set; }

        public int SifarnikEntiteta { get; set; }
        [Required]
        [StringLength(32)]

        public string Naziv { get; set; }

        #endregion

        #region PROPERTY NAVIGACIJA

        public virtual ICollection<Sifarnik> Sifarniks { get; set; }

        public virtual SifarnikEntiteta SifarnikEntiteta1 { get; set; }
        #endregion
    }
}
