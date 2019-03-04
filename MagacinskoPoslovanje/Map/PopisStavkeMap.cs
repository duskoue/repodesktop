using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class PopisStavkeMap : EntityTypeConfiguration<PopisStavke>
    {
        public PopisStavkeMap()
        {
            this.ToTable("PopisStavke");
            this.HasKey(e => e.ID);
        }
    }
}
