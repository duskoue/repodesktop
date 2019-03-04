using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
    public class ValutaMap : EntityTypeConfiguration<Valuta>
    {
        public ValutaMap()
        {
            //this.ToTable("Valuta");
            //this.HasKey(e => e.Sifra);
           this.HasMany(e => e.CarinskaOtpremnicaStavkes)
                .WithRequired(e => e.Valuta1)
                .HasForeignKey(e => e.Valuta)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CarinskaPrijemnicaStavkes)
                .WithRequired(e => e.Valuta1)
                .HasForeignKey(e => e.Valuta)
                .WillCascadeOnDelete(false);
        }
    }
}
