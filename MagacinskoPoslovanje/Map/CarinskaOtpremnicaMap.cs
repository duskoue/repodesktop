using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class CarinskaOtpremnicaMap : EntityTypeConfiguration<CarinskaOtpremnica>
    {
        public CarinskaOtpremnicaMap()
        {
            this.ToTable("CarinskaOtpremnica");
            this.HasKey(e => e.ID);

            this.HasMany(e => e.CarinskaOtpremnicaStavkes)
                .WithRequired(e => e.CarinskaOtpremnica1)
                .HasForeignKey(e => e.CarinskaOtpremnica)
                .WillCascadeOnDelete(false);
        }
    }
}
