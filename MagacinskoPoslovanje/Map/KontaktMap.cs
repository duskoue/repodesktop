using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;



namespace MagacinskoPoslovanje.Map
{
   public class KontaktMap : EntityTypeConfiguration<Kontakt>
    {
        public KontaktMap()
        {
            this.ToTable("Kontakt");
            this.HasKey(e => e.Sifra);

            this.HasMany(e => e.Artikals)
                .WithRequired(e => e.Kontakt)
                .HasForeignKey(e => e.SifraVlasnika)
                .WillCascadeOnDelete(false);

            //this.HasMany(e => e.CarinskaOtpremnica)
            //     .WithRequired(e => e.Kontakt)
            //     .HasForeignKey(e => e.Vlasnik)
            //     .WillCascadeOnDelete(false);

            //this.HasMany(e => e.CarinskaOtpremnica1)
            //     .WithOptional(e => e.Kontakt1)
            //     .HasForeignKey(e => e.PosiljalacJci);

            // this.HasMany(e => e.CarinskaOtpremnica2)
            //     .WithOptional(e => e.Kontakt2)
            //     .HasForeignKey(e => e.Posiljalac);

            // this.HasMany(e => e.CarinskaOtpremnica3)
            //     .WithOptional(e => e.Kontakt3)
            //     .HasForeignKey(e => e.Primalac);

            // this.HasMany(e => e.CarinskaOtpremnica4)
            //     .WithOptional(e => e.Kontakt4)
            //     .HasForeignKey(e => e.Spediter);

            this.HasMany(e => e.CarinskaPrijemnicas)
                .WithRequired(e => e.Kontakt)
                .HasForeignKey(e => e.Vlasnik)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.CarinskaPrijemnicas1)
                 .WithOptional(e => e.Kontakt1)
                 .HasForeignKey(e => e.Posiljalac);

            this.HasMany(e => e.CarinskaPrijemnicas2)
                .WithOptional(e => e.Kontakt2)
                .HasForeignKey(e => e.Spediter);

            this.HasMany(e => e.InterniPrenos)
                 .WithRequired(e => e.Kontakt)
                 .HasForeignKey(e => e.NaVlasnika)
                 .WillCascadeOnDelete(false);

            this.HasMany(e => e.InterniPrenos1)
                 .WithRequired(e => e.Kontakt1)
                 .HasForeignKey(e => e.SaVlasnika)
                 .WillCascadeOnDelete(false);

            //this.HasMany(e => e.Kontakt1)
            //     .WithOptional(e => e.Kontakt2)
            //     .HasForeignKey(e => e.SifraVodeceg);

            // this.HasMany(e => e.LokacijaKlijenta)
            //     .WithRequired(e => e.Kontakt)
            //     .HasForeignKey(e => e.SifraVlasnika)
            //     .WillCascadeOnDelete(false);

            // this.HasMany(e => e.Otpremnica)
            //     .WithOptional(e => e.Kontakt)
            //     .HasForeignKey(e => e.Kupac);

            // this.HasMany(e => e.Otpremnica1)
            //     .WithRequired(e => e.Kontakt1)
            //     .HasForeignKey(e => e.Vlasnik)
            //     .WillCascadeOnDelete(false);

            // this.HasMany(e => e.Popis)
            //     .WithRequired(e => e.Kontakt)
            //     .HasForeignKey(e => e.Vlasnik)
            //     .WillCascadeOnDelete(false);

            //this.HasMany(e => e.RazdvajanjePrijema)
            //     .WithRequired(e => e.Kontakt)
            //     .HasForeignKey(e => e.Vlasnik)
            //     .WillCascadeOnDelete(false);

            this.HasMany(e => e.Uslugas)
                 .WithRequired(e => e.Kontakt)
                 .HasForeignKey(e => e.Vlasnik)
                 .WillCascadeOnDelete(false);
        }
    }
}
