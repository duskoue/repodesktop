using MagacinskoPoslovanje.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Map
{
   public class ArtikalMap : EntityTypeConfiguration<Artikal>
    {
        public ArtikalMap()
        {
            this.ToTable("Artikal");
            this.HasKey(e => e.Sifra);
            //this.HasMany(e => e.ArtikliLokacije)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            ////this.HasMany(e => e.ArtikliZamena)
            ////    .WithRequired(e => e.Artikal)
            ////    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            ////    .WillCascadeOnDelete(false);

            //this.HasMany(e => e.Barcode)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.SifraArtikla, e.SifraVlasnika })
            //    .WillCascadeOnDelete(false);

            //this.HasMany(e => e.InterniPrenosStavke)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //this.HasMany(e => e.InterniPrenosStavke1)
            //    .WithRequired(e => e.Artikal1)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //this
            //    .HasMany(e => e.Odabir)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //this
            //    .HasMany(e => e.OtpremnicaStavke)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //this
            //    .HasMany(e => e.PodesavanjeZalihaStavke)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //this
            //    .HasMany(e => e.PopisLista)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //this
            //    .HasMany(e => e.Posao)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //this
            //  .HasMany(e => e.PrijemnicaStavke)
            //  .WithRequired(e => e.Artikal)
            //  .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //  .WillCascadeOnDelete(false);

            //this
            //    .HasMany(e => e.Sarza)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //this
            //    .HasMany(e => e.Sastavnica)
            //    .WithOptional(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalZaglavlja, e.Vlasnik });

            //this
            //    .HasMany(e => e.Zaliha)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

        }
    }
}
