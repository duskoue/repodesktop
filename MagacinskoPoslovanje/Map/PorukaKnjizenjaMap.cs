using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class PorukaKnjizenjaMap :EntityTypeConfiguration<PorukaKnjizenja>
    {
        public PorukaKnjizenjaMap()
        {
            this.ToTable("PorukaKnjizenja");
            this.HasKey(e => e.ID);

        }
    }
}
