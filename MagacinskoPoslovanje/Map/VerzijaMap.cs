using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class VerzijaMap : EntityTypeConfiguration<Verzija>
    {
        public VerzijaMap()
        {
            this.ToTable("Verzija");
            this.HasKey(e => e.Broj);
        }
    }
}
