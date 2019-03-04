using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MagacinskoPoslovanje.Data;
namespace MagacinskoPoslovanje.Map
{
    public class InterfaceLogMap : EntityTypeConfiguration<InterfaceLog>
    {
        public InterfaceLogMap()
        {
            this.ToTable("InterfaceLog");
            this.HasKey(e => e.ID);

        }
    }
}
