using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
    public class ArtikliLokacijeMap : EntityTypeConfiguration<ArtikliLokacije>
    {
        public ArtikliLokacijeMap()
    {
        this.Property(e => e.ArtikalSifra).IsUnicode(false);
        this.Property(e => e.ArtikalVlasnik).IsUnicode(false);
        this.Property(e => e.Lokacija).IsUnicode(false);
        this.Property(e => e.MinimalnaKolicina).HasPrecision(18, 4);
        this.Property(e => e.MaksimalnaKolicina).HasPrecision(18, 4);
        this.Property(e => e.NajmanjaJMDopune).IsUnicode(false);
    }
}
}
