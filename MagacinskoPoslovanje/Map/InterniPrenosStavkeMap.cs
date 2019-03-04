using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;

namespace MagacinskoPoslovanje.Map
{
   public class InterniPrenosStavkeMap : EntityTypeConfiguration<InterniPrenosStavke> 
    {
        public InterniPrenosStavkeMap()
        {
            //this.ToTable("InterniPrenosStavke");
            //this.HasKey(e => new { e.SifraArtikla,e.SifraVlasnika});
        }

        
    }
}
