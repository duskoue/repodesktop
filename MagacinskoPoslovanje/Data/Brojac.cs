using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Brojac")]
    public class Brojac
    {
        #region PROPERTY CLASS
        public int ID { get; set; }

        public int Entitet { get; set; }

        public int Godina { get; set; }

        public int Broj { get; set; }

        #endregion

        #region PROPERTY NAVIGACIJA
        public virtual SifarnikEntiteta SifarnikEntiteta { get; set; }
        #endregion

    }
}
