using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class ZonaMap: EntityTypeConfiguration<Zona>
    {
        public ZonaMap()
        {
            //this.ToTable("Zona");
            //this.HasKey(e => e.Sifra);
           this.HasMany(e => e.Lokacijas)
               .WithRequired(e => e.Zona1)
               .HasForeignKey(e => e.Zona)
               .WillCascadeOnDelete(false);
        }
    }
}
