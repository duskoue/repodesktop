using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class NabavniNalogMap : EntityTypeConfiguration<NabavniNalog>
    {
        public NabavniNalogMap()
        {
            //this.ToTable("NabavniNalog");
            //this.HasKey(e => e.ID);
           this.HasMany(e => e.NabavniNalogStavkes)
                .WithRequired(e => e.NabavniNalog1)
                .HasForeignKey(e => e.NabavniNalog)
                .WillCascadeOnDelete(false);
        }
    }
}
