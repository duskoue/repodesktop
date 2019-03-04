using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
  public  class UtovarStavkeMap : EntityTypeConfiguration<UtovarStavke>
    {
        public UtovarStavkeMap()
        {
            this.ToTable("UtovarStavke");
            this.HasKey(e => e.ID);

        }
    }
}
