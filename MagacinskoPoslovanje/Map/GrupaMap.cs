using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class GrupaMap : EntityTypeConfiguration<Grupa>
    {
        public GrupaMap()
        {
            this.ToTable("Grupa");
            this.HasKey(e => e.ID);
            this.HasMany(e => e.GrupaStavkes)
                .WithRequired(e => e.Grupa1)
                .HasForeignKey(e => e.Grupa)
                .WillCascadeOnDelete(false);
        }
    }
}
