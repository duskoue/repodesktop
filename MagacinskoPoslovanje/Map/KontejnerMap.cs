using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class KontejnerMap : EntityTypeConfiguration<Kontejner>
    {
        public KontejnerMap()
        {
            this.ToTable("Kontejner");
            this.HasKey(e => e.Sifra);
        }
    }
}
