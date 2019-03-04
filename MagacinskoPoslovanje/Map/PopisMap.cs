using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;


namespace MagacinskoPoslovanje.Map
{
   public class PopisMap : EntityTypeConfiguration<Popi>
    {
        public PopisMap()
        {
            //this.ToTable("Popis");
            //this.HasKey(e => e.ID);
           this.HasMany(e => e.PopisListas)
              .WithRequired(e => e.Popi)
              .HasForeignKey(e => e.Popis)
              .WillCascadeOnDelete(false);

            this.HasMany(e => e.PopisStavkes)
                .WithOptional(e => e.Popi)
                .HasForeignKey(e => e.Popis);
        }
    }
}
