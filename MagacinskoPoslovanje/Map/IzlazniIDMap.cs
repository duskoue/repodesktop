using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class IzlazniIDMap : EntityTypeConfiguration<IzlazniID>
    {
        public IzlazniIDMap()
        {
            //this.ToTable("IzlazniID");
            //this.HasKey(e => e.OtpremnicaID);
            this.HasMany(e => e.Otpremnicas)
                .WithOptional(e => e.IzlazniID)
                .HasForeignKey(e => e.IzlazniLPN);
        }
    }
}
