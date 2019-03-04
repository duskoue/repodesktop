using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class PravoMap : EntityTypeConfiguration<Pravo>
    {
        public PravoMap()
        {
            this.ToTable("Pravo");
            this.HasKey(e => e.ID);
           this.HasMany(e => e.Rolas)
               .WithMany(e => e.Pravoes)
               .Map(m => m.ToTable("RolePrava").MapLeftKey("IDPravo").MapRightKey("IDRola"));
        }
    }
}
