using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class OtpremnicaStavkeMap : EntityTypeConfiguration<OtpremnicaStavke>
    {
        public OtpremnicaStavkeMap()
        {
            this.ToTable("OtpremnicaStavke");
            this.HasKey(e => e.ID);

        }
    }
}
