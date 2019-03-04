using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;


namespace MagacinskoPoslovanje.Map
{
   public class LokacijaKlijentaMap : EntityTypeConfiguration<LokacijaKlijenta>
    {
        public LokacijaKlijentaMap()
        {
            //this.ToTable("LokacijeKlijenta");
            //this.HasKey(e => e.ID);
            //this.HasMany(e => e.Otpremnicas)
            //    .WithOptional(e => e.LokacijaKlijenta)
            //    .HasForeignKey(e => new { e.Vlasnik, e.EksternoSkladiste });

            //this.HasMany(e => e.Prijemnicas)
            //    .WithOptional(e => e.LokacijaKlijenta)
            //    .HasForeignKey(e => new { e.Vlasnik, e.EksternoSkladiste });

            //this.HasMany(e => e.Prijemnicas1)
            //    .WithOptional(e => e.LokacijaKlijenta1)
            //    .HasForeignKey(e => new { e.Vlasnik, e.EksternoSkladiste });

            //this.HasMany(e => e.PrijemnicaStavkes)
            //     .WithOptional(e => e.LokacijaKlijenta)
            //     .HasForeignKey(e => new { e.ArtikalVlasnik, e.EksternoSkladiste });

            //this.HasMany(e => e.Zalihas)
            //    .WithOptional(e => e.LokacijaKlijenta)
            //    .HasForeignKey(e => new { e.ArtikalVlasnik, e.EksternoSkladiste });
        }
    }
}
