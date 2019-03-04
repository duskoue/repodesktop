using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class LokacijaMap : EntityTypeConfiguration<Lokacija>
    {
        public LokacijaMap()
        {
            //this.ToTable("Lokacija");
            //this.HasKey(e => e.Sifra);
            this.HasMany(e => e.ArtikliLokacijes)
                .WithRequired(e => e.Lokacija1)
                .HasForeignKey(e => e.Lokacija)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.InterniPrenosStavkes)
                .WithRequired(e => e.Lokacija)
                .HasForeignKey(e => e.NaLokaciju)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.InterniPrenosStavkes1)
                .WithRequired(e => e.Lokacija1)
                .HasForeignKey(e => e.SaLokacije)
                .WillCascadeOnDelete(false);

           this.HasMany(e => e.Otpremnicas)
                .WithOptional(e => e.Lokacija)
                .HasForeignKey(e => e.LinijaEkspedicije);

          this.HasMany(e => e.PopisListas)
                .WithRequired(e => e.Lokacija1)
                .HasForeignKey(e => e.Lokacija)
                .WillCascadeOnDelete(false);

           this.HasMany(e => e.PrijemnicaStavkes)
                .WithOptional(e => e.Lokacija1)
                .HasForeignKey(e => e.Lokacija);
        }
    }
}
