using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class SifarnikMap : EntityTypeConfiguration<Sifarnik>
    {
        public SifarnikMap()
        {
            this.ToTable("Sifarnik");
            this.HasKey(e => e.ID);

         //   this.HasMany(e => e.Blokada)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.Razlog)
         //       .WillCascadeOnDelete(false);

         //  this.HasMany(e => e.CarinskaOtpremnica)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.TipPrevoza)
         //       .WillCascadeOnDelete(false);

         //  this.HasMany(e => e.CarinskaOtpremnicaStavke)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.TipDokumenta)
         //       .WillCascadeOnDelete(false);

         //   this.HasMany(e => e.CarinskaPrijemnica)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.TipPrevoza)
         //       .WillCascadeOnDelete(false);

         //   this.HasMany(e => e.CarinskaPrijemnicaStavke)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.TipDokumenta)
         //       .WillCascadeOnDelete(false);

         //   this.HasMany(e => e.IzlazniID)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.TipAmbalaze)
         //       .WillCascadeOnDelete(false);

         //  this.HasMany(e => e.Kontakt)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.Tip)
         //       .WillCascadeOnDelete(false);

         //   this.HasMany(e => e.Lokacija)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.TipLokacije)
         //       .WillCascadeOnDelete(false);

         //   this.HasMany(e => e.Odabir)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.Status)
         //       .WillCascadeOnDelete(false);

         //   this.HasMany(e => e.Otpremnica)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.Tip)
         //       .WillCascadeOnDelete(false);

         //   this.HasMany(e => e.OtpremnicaStavke)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.Status)
         //       .WillCascadeOnDelete(false);

         //  this.HasMany(e => e.PodesavanjeZalihaStavke)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.Razlog)
         //       .WillCascadeOnDelete(false);

         //   this.HasMany(e => e.Posao)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.StatusPosla)
         //       .WillCascadeOnDelete(false);

         //  this.HasMany(e => e.Posao1)
         //       .WithRequired(e => e.Sifarnik1)
         //       .HasForeignKey(e => e.TipPosla)
         //       .WillCascadeOnDelete(false);

         //   this.HasMany(e => e.Prijemnica)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.TipPrijema)
         //       .WillCascadeOnDelete(false);

         //   this.HasMany(e => e.Prijemnica1)
         //       .WithRequired(e => e.Sifarnik1)
         //       .HasForeignKey(e => e.Status)
         //       .WillCascadeOnDelete(false);

         //this.HasMany(e => e.PrijemnicaStavke)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.Status)
         //       .WillCascadeOnDelete(false);

         //   this.HasMany(e => e.Usluga)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.VrstaUsluge)
         //       .WillCascadeOnDelete(false);

         //   this.HasMany(e => e.Zaliha)
         //       .WithRequired(e => e.Sifarnik)
         //       .HasForeignKey(e => e.StatusZalihe)
         //       .WillCascadeOnDelete(false);

        }
    }
}
