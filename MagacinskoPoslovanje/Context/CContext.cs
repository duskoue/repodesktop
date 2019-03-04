using MagacinskoPoslovanje.Data;
using MagacinskoPoslovanje.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magacinsko
{
  public  class CContext :DbContext
    {
        public CContext(string connection) : base(connection)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<CContext>());
        }
        public DbSet<Artikal> Korisnici { get; set; }
      //  public DbSet<Cknjige> Knjige { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new ArtikalMap());
         //   modelBuilder.Configurations.Add(new CKnjigeMap());
           
        }
    }
}
