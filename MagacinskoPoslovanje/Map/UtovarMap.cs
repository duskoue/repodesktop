using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class UtovarMap : EntityTypeConfiguration<Utovar>
    {
        public UtovarMap()
        {
            //this.ToTable("Utovar");
            //this.HasKey(e => e.ID);
            this.HasMany(e => e.UtovarStavkes)
                .WithRequired(e => e.Utovar1)
                .HasForeignKey(e => e.Utovar)
                .WillCascadeOnDelete(false);
        }
    }
}
