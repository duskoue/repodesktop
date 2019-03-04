using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class PrijemnicaStavkeMap : EntityTypeConfiguration<PrijemnicaStavke>
    {
        public PrijemnicaStavkeMap()
        {
            this.ToTable("PrijemnicaStavke");
            this.HasKey(e => e.ID);

        }
    }
}
