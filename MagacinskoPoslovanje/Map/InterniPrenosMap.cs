using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class InterniPrenosMap : EntityTypeConfiguration<InterniPreno>
    {
        public InterniPrenosMap()
        {
            this.ToTable("InterniPrenos");
            this.HasKey(e => e.ID);
            //this.HasMany(e => e.InterniPrenosStavke3)
            //      .WithRequired(e => e.InterniPrenos1)
            //      .HasForeignKey(e => e.InterniPrenos)
            //      .WillCascadeOnDelete(false);
        }
    }
}
