﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
   public class ObracunKomercijalniMap : EntityTypeConfiguration<ObracunKomercijalni>
    {
        public ObracunKomercijalniMap()
        {
            this.ToTable("ObracunKomercijalni");
            this.HasKey(e => e.ID);

        }
    }
}
