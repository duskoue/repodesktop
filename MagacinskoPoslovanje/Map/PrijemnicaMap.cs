using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class PrijemnicaMap : EntityTypeConfiguration<Prijemnica>
    {
        public PrijemnicaMap()
        {
            //this.ToTable("Prijemnica");
            //this.HasKey(e => e.ID);
           this.HasMany(e => e.PrijemnicaStavkes)
               .WithRequired(e => e.Prijemnica1)
               .HasForeignKey(e => e.Prijemnica)
               .WillCascadeOnDelete(false);
        }
    }
}
