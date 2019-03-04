using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;


namespace MagacinskoPoslovanje.Map
{
   public class RazdvajanjePrijemaMap : EntityTypeConfiguration<RazdvajanjePrijema>
    {
        public RazdvajanjePrijemaMap()
        {
            this.ToTable("RazdvajanjePrijema");
            this.HasKey(e => e.ID);
           this.HasMany(e => e.RazdvajanjePrijemaStavkes)
                .WithRequired(e => e.RazdvajanjePrijema1)
                .HasForeignKey(e => e.RazdvajanjePrijema)
                .WillCascadeOnDelete(false);
        }
    }
}
