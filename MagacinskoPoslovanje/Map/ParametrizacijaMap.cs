using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class ParametrizacijaMap : EntityTypeConfiguration<Parametrizacija>
    {
        public ParametrizacijaMap()
        {
            this.ToTable("Parametrizacija");
            this.HasKey(e => e.ID);

        }
    }
}
