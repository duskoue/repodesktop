using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class PodesavanjeZalihaMap : EntityTypeConfiguration<PodesavanjeZaliha>
    {
        public PodesavanjeZalihaMap()
        {
            this.ToTable("PodesavanjeZaliha");
            this.HasKey(e => e.ID);
            this.HasMany(e => e.PodesavanjeZalihaStavkes)
                .WithRequired(e => e.PodesavanjeZaliha1)
                .HasForeignKey(e => e.PodesavanjeZaliha)
                .WillCascadeOnDelete(false);
        }
    }
}
