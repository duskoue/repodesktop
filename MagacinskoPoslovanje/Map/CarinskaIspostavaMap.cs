using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class CarinskaIspostavaMap : EntityTypeConfiguration<CarinskaIspostava>

    {
        public CarinskaIspostavaMap()
        {
            this.ToTable("CarinskaGrupaArtikala");
            this.HasKey(e => e.Sifra);
            this.HasMany(e => e.CarinskaPrijemnicas)
                .WithRequired(e => e.CarinskaIspostava)
                .HasForeignKey(e => e.Carinarnica)
                .WillCascadeOnDelete(false);

        }
    }
}
