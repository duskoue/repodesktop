using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class CarinskaPrijemnicaMap : EntityTypeConfiguration<CarinskaPrijemnica> 
    {
        public CarinskaPrijemnicaMap()
        {
            this.ToTable("CarinskaPrijemnica");
            this.HasKey(e => e.ID);

            this.HasMany(e => e.CarinskaOtpremnicas)
                 .WithRequired(e => e.CarinskaPrijemnica1)
                 .HasForeignKey(e => e.CarinskaPrijemnica)
                 .WillCascadeOnDelete(false);

            this.HasMany(e => e.CarinskaPrijemnicaStavkes)
                .WithRequired(e => e.CarinskaPrijemnica1)
                .HasForeignKey(e => e.CarinskaPrijemnica)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.RazdvajanjePrijemas)
                .WithRequired(e => e.CarinskaPrijemnica1)
                .HasForeignKey(e => e.CarinskaPrijemnica)
                .WillCascadeOnDelete(false);
            
        }
    }
}
