using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class ArtikliZamenaMap : EntityTypeConfiguration<ArtikliZamena>

    {
        public ArtikliZamenaMap()
        {
            this.ToTable("ArtikliZamena");
            this.HasKey(e => e.ArtikalSifra);
        }
    }
}
