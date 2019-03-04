using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class SkladisteMap : EntityTypeConfiguration<Skladiste>
    {
        public SkladisteMap()
        {
            this.ToTable("Sklasiate");
            this.HasKey(e => e.Sifra);

           this.HasMany(e => e.CarinskaOtpremnicas)
               .WithRequired(e => e.Skladiste1)
               .HasForeignKey(e => e.Skladiste)
               .WillCascadeOnDelete(false);

           this .HasMany(e => e.CarinskaOtpremnicaStavkes)
                .WithRequired(e => e.Skladiste1)
                .HasForeignKey(e => e.Skladiste)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.CarinskaPrijemnicas)
                .WithRequired(e => e.Skladiste1)
                .HasForeignKey(e => e.Skladiste)
                .WillCascadeOnDelete(false);

           this .HasMany(e => e.CarinskaPrijemnicaStavkes)
                .WithRequired(e => e.Skladiste1)
                .HasForeignKey(e => e.Skladiste)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.InterniPrenos)
                .WithRequired(e => e.Skladiste1)
                .HasForeignKey(e => e.Skladiste)
                .WillCascadeOnDelete(false);

           this.HasMany(e => e.InterniPrenosStavkes)
                .WithRequired(e => e.Skladiste1)
                .HasForeignKey(e => e.Skladiste)
                .WillCascadeOnDelete(false);

           this .HasMany(e => e.Otpremnicas)
                .WithRequired(e => e.Skladiste1)
                .HasForeignKey(e => e.Skladiste)
                .WillCascadeOnDelete(false);

           this.HasMany(e => e.OtpremnicaStavkes)
                .WithRequired(e => e.Skladiste1)
                .HasForeignKey(e => e.Skladiste)
                .WillCascadeOnDelete(false);

           this .HasMany(e => e.PodesavanjeZalihas)
                .WithRequired(e => e.Skladiste1)
                .HasForeignKey(e => e.Skladiste)
                .WillCascadeOnDelete(false);

           this
                .HasMany(e => e.PodesavanjeZalihaStavkes)
                .WithRequired(e => e.Skladiste1)
                .HasForeignKey(e => e.Skladiste)
                .WillCascadeOnDelete(false);

           this .HasMany(e => e.Prijemnicas)
                .WithRequired(e => e.Skladiste1)
                .HasForeignKey(e => e.Skladiste)
                .WillCascadeOnDelete(false);

           this.HasMany(e => e.PrijemnicaStavkes)
                .WithRequired(e => e.Skladiste1)
                .HasForeignKey(e => e.Skladiste)
                .WillCascadeOnDelete(false);
        }
    }
}
