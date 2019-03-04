using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class SpecZaCarinjenjeMap : EntityTypeConfiguration<SpecZaCarinjenje>
    {
        public SpecZaCarinjenjeMap()
        {
            //this.ToTable("SpecZaCarinjenje");
            //this.HasKey(e => e.ID);
            this.HasMany(e => e.SpecZaCarinjenjeStavkes)
                .WithRequired(e => e.SpecZaCarinjenje1)
                .HasForeignKey(e => e.SpecZaCarinjenje)
                .WillCascadeOnDelete(false);
        }
    }
}
