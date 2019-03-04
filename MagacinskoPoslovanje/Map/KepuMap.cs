using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class KepuMap : EntityTypeConfiguration<KEPU>
    {
        public KepuMap()
        {
            this.ToTable("KEPU");
            this.HasKey(e => e.ID);

        }
    }
}
