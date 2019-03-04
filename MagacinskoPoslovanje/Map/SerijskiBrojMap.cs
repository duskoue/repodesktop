using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
    class SerijskiBrojMap : EntityTypeConfiguration<SerijskiBroj>
    {
        public SerijskiBrojMap()
        {
            this.ToTable("SerijskiBroj");
            this.HasKey(e => e.ID);
        }
    }
}
