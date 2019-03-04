using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;


namespace MagacinskoPoslovanje.Map
{
  public  class TarifaMap :EntityTypeConfiguration<Tarifa>
    {
        public TarifaMap()
        {
            //this.ToTable("Tarifa");
            //this.HasKey(e => e.ID);
            this.HasMany(e => e.Artikals)
                .WithOptional(e => e.Tarifa1)
                .HasForeignKey(e => e.Tarifa);

            this.HasMany(e => e.TarifaStavkes)
                .WithRequired(e => e.Tarifa1)
                .HasForeignKey(e => e.Tarifa)
                .WillCascadeOnDelete(false);
        }
    }
}
