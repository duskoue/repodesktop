using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class CarinskaPrijemnicaStavkeMap : EntityTypeConfiguration<CarinskaPrijemnicaStavke>
    {
        public CarinskaPrijemnicaStavkeMap()
        {
            this.ToTable("CarinskaPrijemnicaStavke");
            this.HasKey(e => e.ID);

        }
    }
}
