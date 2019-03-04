using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
  public  class SifarnikEntitetaMap : EntityTypeConfiguration<SifarnikEntiteta>
    {
        public SifarnikEntitetaMap()
        {
               this.HasMany(e => e.Brojacs)
                .WithRequired(e => e.SifarnikEntiteta)
                .HasForeignKey(e => e.Entitet)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.SifarnikEntitetaTips)
                .WithRequired(e => e.SifarnikEntiteta1)
                .HasForeignKey(e => e.SifarnikEntiteta)
                .WillCascadeOnDelete(false);
        }
    }
}
