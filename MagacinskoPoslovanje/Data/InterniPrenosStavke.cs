using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("InterniPrenosStavke")]
    public  class InterniPrenosStavke
    {
        public int ID { get; set; }

        public int RB { get; set; }

        public int InterniPrenos { get; set; }

        public int Status { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        [Required]
        [StringLength(15)]
        public string SaVlasnika { get; set; }

        [Required]
        [StringLength(30)]
        public string SaArtikla { get; set; }

        [Required]
        [StringLength(10)]
        public string SaLokacije { get; set; }

        public int SaSarze { get; set; }

        public decimal SaKolicina { get; set; }

        [Required]
        [StringLength(4)]
        public string SaJM { get; set; }

        [Required]
        [StringLength(15)]
        public string NaVlasnika { get; set; }

        [Required]
        [StringLength(30)]
        public string NaArtikal { get; set; }

        [Required]
        [StringLength(10)]
        public string NaLokaciju { get; set; }

        public int NaSarzu { get; set; }

        public decimal NaKolicina { get; set; }

        [Required]
        [StringLength(4)]
        public string NaJM { get; set; }

        [StringLength(50)]
        public string SerijskiBroj { get; set; }

        public DateTime? DatumIsteka { get; set; }

        public DateTime? DatumProizvodnje { get; set; }

        [StringLength(50)]
        public string MagacinskiBroj { get; set; }

        public decimal? SerijaOd { get; set; }

        public decimal? SerijaDo { get; set; }

        [StringLength(250)]
        public string Atribut1 { get; set; }

        [StringLength(250)]
        public string Atribut2 { get; set; }

        [StringLength(50)]
        public string Serija { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        [StringLength(18)]
        public string SaLPN { get; set; }

        [StringLength(18)]
        public string NaLPN { get; set; }

        public decimal? BrojKoleta { get; set; }

        [StringLength(50)]
        public string BrojFakture { get; set; }

        [StringLength(50)]
        public string BrojDeklaracije { get; set; }

        public decimal CenaTarifa { get; set; }

        [StringLength(4)]
        public string TarifaJM { get; set; }

        public decimal? BrojKoletaNa { get; set; }

        [StringLength(50)]
        public string EksternoSkladisteNa { get; set; }

        [StringLength(128)]
        public string EksternaSifraStavke { get; set; }

        public decimal? Cena { get; set; }

        public virtual Artikal Artikal { get; set; }

        public virtual Artikal Artikal1 { get; set; }

        public virtual InterniPreno InterniPreno { get; set; }

        public virtual JM JM { get; set; }

        public virtual JM JM1 { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Lokacija Lokacija { get; set; }

        public virtual Lokacija Lokacija1 { get; set; }

        public virtual Sarza Sarza { get; set; }

        public virtual Skladiste Skladiste1 { get; set; }
        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }
       
    }
}
