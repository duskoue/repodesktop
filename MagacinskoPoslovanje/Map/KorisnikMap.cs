using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class KorisnikMap : EntityTypeConfiguration<Korisnik>
    {
        public KorisnikMap()
        {
            this.ToTable("Korisnik");
            this.HasKey(e => e.ID);
            this.HasMany(e => e.Blokadas)
               .WithRequired(e => e.Korisnik)
               .HasForeignKey(e => e.Kreirao)
               .WillCascadeOnDelete(false);

            this.HasMany(e => e.CarinskaOtpremnicas)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Kreirao)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CarinskaOtpremnicas1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Promenio)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CarinskaOtpremnicaStavkes)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Kreirao)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CarinskaOtpremnicaStavkes1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Promenio)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CarinskaPrijemnicas)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Kreirao)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CarinskaPrijemnicas1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Promenio)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CarinskaPrijemnicas2)
                .WithRequired(e => e.Korisnik2)
                .HasForeignKey(e => e.Uskladistio)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CarinskaPrijemnicaStavkes)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Kreirao)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CarinskaPrijemnicaStavkes1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Promenio)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.InterniPrenos)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Kreirao)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.InterniPrenos1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Promenio)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.InterniPrenosStavkes)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Kreirao)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.InterniPrenosStavkes1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Promenio)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Otpremnicas)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Kreirao)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Otpremnicas1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Promenio)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.OtpremnicaStavkes)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Kreirao)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.OtpremnicaStavkes1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Promenio)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.PodesavanjeZalihaStavkes)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Kreirao)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Posaos)
                .WithOptional(e => e.Korisnik)
                .HasForeignKey(e => e.Radnik);

            this.HasMany(e => e.Prijemnicas)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Kreirao)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Prijemnicas1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Promenio)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.PrijemnicaStavkes)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Kreirao)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.PrijemnicaStavkes1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Promenio)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.RazdvajanjePrijemas)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Kreirao)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.RazdvajanjePrijemas1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Promenio)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.RazdvajanjePrijemaStavkes)
                .WithRequired(e => e.Korisnik)
                .HasForeignKey(e => e.Kreirao)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.RazdvajanjePrijemaStavkes1)
                .WithRequired(e => e.Korisnik1)
                .HasForeignKey(e => e.Promenio)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.Rolas)
                .WithMany(e => e.Korisniks)
                .Map(m => m.ToTable("KorisniciRole").MapLeftKey("IDKorisnik").MapRightKey("IDRola"));
        }
    }
}
