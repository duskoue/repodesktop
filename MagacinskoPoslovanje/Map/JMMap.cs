using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class JMMap : EntityTypeConfiguration<JM>
    {
        public JMMap()
        {
            //this.ToTable("JM");
            //this.HasKey(e => e.Sifra);
            this.HasMany(e => e.Artikals)
                .WithRequired(e => e.JM)
                .HasForeignKey(e => e.PodrazumevanaJM)
                .WillCascadeOnDelete(false);

           this.HasMany(e => e.Barcodes)
                .WithRequired(e => e.JM1)
                .HasForeignKey(e => e.JM)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.InterniPrenosStavkes)
                .WithRequired(e => e.JM)
                .HasForeignKey(e => e.NaJM)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.InterniPrenosStavkes1)
                .WithRequired(e => e.JM1)
                .HasForeignKey(e => e.SaJM)
                .WillCascadeOnDelete(false);

            this.HasMany(e => e.OtpremnicaStavkes)
                .WithRequired(e => e.JM1)
                .HasForeignKey(e => e.JM)
                .WillCascadeOnDelete(false);

           this.HasMany(e => e.Pakovanjes)
                .WithRequired(e => e.JM)
                .HasForeignKey(e => e.OsnovnaJM)
                .WillCascadeOnDelete(false);

           this.HasMany(e => e.Pakovanjes1)
                .WithOptional(e => e.JM1)
                .HasForeignKey(e => e.JMNivo1);

           this.HasMany(e => e.Pakovanjes2)
                .WithOptional(e => e.JM2)
                .HasForeignKey(e => e.JMNivo2);

           this.HasMany(e => e.Pakovanjes3)
                .WithOptional(e => e.JM3)
                .HasForeignKey(e => e.JMNivo3);

            this.HasMany(e => e.Pakovanjes4)
                .WithOptional(e => e.JM4)
                .HasForeignKey(e => e.JMNivo4);

            this.HasMany(e => e.PrijemnicaStavkes)
                .WithRequired(e => e.JM1)
                .HasForeignKey(e => e.JM)
                .WillCascadeOnDelete(false);
        }
    }
}
