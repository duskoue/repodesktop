using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class OtpremnicaMap : EntityTypeConfiguration<Otpremnica>
    {
        public OtpremnicaMap()
        {
            //this.ToTable("Otpremnica");
            //this.HasKey(e => e.ID);
           this.HasMany(e => e.Odabirs)
                .WithRequired(e => e.Otpremnica1)
                .HasForeignKey(e => e.Otpremnica)
                .WillCascadeOnDelete(false);

          this.HasMany(e => e.OtpremnicaStatusLogs)
                .WithRequired(e => e.Otpremnica1)
                .HasForeignKey(e => e.Otpremnica)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.OtpremnicaStavkes)
                .WithRequired(e => e.Otpremnica1)
                .HasForeignKey(e => e.Otpremnica)
                .WillCascadeOnDelete(false);
        }
    }
}
