using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class OblastMap : EntityTypeConfiguration<Oblast>
    {
        public OblastMap()
        {
            //this.ToTable("Oblast");
            //this.HasKey(e => e.Sifra);
            this.HasMany(e => e.Zonas)
                .WithOptional(e => e.Oblast1)
                .HasForeignKey(e => e.Oblast);
        }
    }
}
