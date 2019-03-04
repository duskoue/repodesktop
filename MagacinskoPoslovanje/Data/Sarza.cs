using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Sarza")]
    public class Sarza
    {
        public Sarza()
        {
            InterniPrenosStavkes = new HashSet<InterniPrenosStavke>();
            Posaos = new HashSet<Posao>();
            PrijemnicaStavkes = new HashSet<PrijemnicaStavke>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [StringLength(50)]
        public string SerijskiBroj { get; set; }

        public DateTime? DatumIsteka { get; set; }

        public DateTime? DatumProizvodnje { get; set; }

        [StringLength(50)]
        public string MagacinskiBroj { get; set; }

        public decimal Kolicina { get; set; }

        public decimal RezervisanaKolicina { get; set; }

        public decimal IzabranaKolicina { get; set; }

        public decimal BlokiranaKolicina { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        //[Column(TypeName = "timestamp")]
        //[MaxLength(8)]
        //[Timestamp]
        public byte[] RowVersion { get; set; }

        public decimal? SerijaOd { get; set; }

        public decimal? SerijaDo { get; set; }

        [StringLength(250)]
        public string Atribut1 { get; set; }

        [StringLength(250)]
        public string Atribut2 { get; set; }

        [StringLength(50)]
        public string Serija { get; set; }

        [StringLength(50)]
        public string BrojFakture { get; set; }

        [StringLength(50)]
        public string BrojDeklaracije { get; set; }

        public decimal CenaTarifa { get; set; }

        [StringLength(4)]
        public string TarifaJM { get; set; }

        public DateTime? DatumPrijema { get; set; }

        public virtual Artikal Artikal { get; set; }

       
        public virtual ICollection<InterniPrenosStavke> InterniPrenosStavkes { get; set; }

       
        public virtual ICollection<Posao> Posaos { get; set; }

       
        public virtual ICollection<PrijemnicaStavke> PrijemnicaStavkes { get; set; }
    }
}