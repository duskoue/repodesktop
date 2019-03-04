using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class SifarnikEntitetaTipMap : EntityTypeConfiguration<SifarnikEntitetaTip>
    {
        public SifarnikEntitetaTipMap()
        {
            this.ToTable("SifarnikEntitetaTip");
            this.HasKey(e => e.ID);
            this.HasMany(e => e.Sifarniks)
               .WithRequired(e => e.SifarnikEntitetaTip1)
               .HasForeignKey(e => e.SifarnikEntitetaTip)
               .WillCascadeOnDelete(false);
        }

    }
}
