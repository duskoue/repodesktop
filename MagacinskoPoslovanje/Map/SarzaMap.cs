using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
  public  class SarzaMap : EntityTypeConfiguration<Sarza>
    {
        public SarzaMap()
        {
            this.ToTable("Sarza");
            this.HasKey(e => e.ID);
            this.HasMany(e => e.InterniPrenosStavkes)
               .WithRequired(e => e.Sarza)
               .HasForeignKey(e => e.SaSarze)
               .WillCascadeOnDelete(false);

            this.HasMany(e => e.Posaos)
                .WithOptional(e => e.Sarza1)
                .HasForeignKey(e => e.Sarza);

           this.HasMany(e => e.PrijemnicaStavkes)
                .WithOptional(e => e.Sarza1)
                .HasForeignKey(e => e.Sarza);

        }
    }
}
