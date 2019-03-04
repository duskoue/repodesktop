using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class EksterniKorisnikMap : EntityTypeConfiguration<EksterniKorisnik>

    {
        public EksterniKorisnikMap()
        {
            this.ToTable("EksterniKorisnik");
            this.HasKey(e => e.ID);
        }
    }
}
