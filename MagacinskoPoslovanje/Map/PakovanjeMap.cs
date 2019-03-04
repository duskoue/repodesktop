using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class PakovanjeMap : EntityTypeConfiguration<Pakovanje>
    {
        public PakovanjeMap()
        {
            this.ToTable("Pakovanje");
            this.HasKey(e => e.ID);
            this.HasMany(e => e.Artikals)
                .WithRequired(e => e.Pakovanje1)
                .HasForeignKey(e => e.Pakovanje)
                .WillCascadeOnDelete(false);

           this.HasMany(e => e.Barcodes)
                .WithRequired(e => e.Pakovanje1)
                .HasForeignKey(e => e.Pakovanje)
                .WillCascadeOnDelete(false);
        }
    }
}
