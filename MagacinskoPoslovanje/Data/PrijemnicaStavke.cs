using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("PrijemnicaStavke")]
    public class PrijemnicaStavke
    {
        public int ID { get; set; }

        public int RB { get; set; }

        public int Prijemnica { get; set; }

        [StringLength(128)]
        public string EksternaSifraStavke { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Required]
        [StringLength(4)]
        public string JM { get; set; }

        public decimal OcekivanaKolicina { get; set; }

        public decimal PrimljenaKolicina { get; set; }

        public int Status { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public int? Sarza { get; set; }

        [StringLength(10)]
        public string Lokacija { get; set; }

        [StringLength(18)]
        public string LPN { get; set; }

        [StringLength(50)]
        public string SerijskiBroj { get; set; }

        public DateTime? DatumIsteka { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        [StringLength(50)]
        public string MagacinskiBroj { get; set; }

        public DateTime? DatumProizvodnje { get; set; }

        public decimal? SerijaOd { get; set; }

        public decimal? SerijaDo { get; set; }

        [StringLength(250)]
        public string Atribut1 { get; set; }

        [StringLength(250)]
        public string Atribut2 { get; set; }

        [StringLength(128)]
        public string EksternaSifraStavke2 { get; set; }

        [StringLength(128)]
        public string EksternaSifra { get; set; }

        [StringLength(128)]
        public string EksternaSifra2 { get; set; }

        public bool? Poslato { get; set; }

        [StringLength(50)]
        public string EksternoSkladiste { get; set; }

        public int? NabavniNalogStavke { get; set; }

        [StringLength(50)]
        public string Serija { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }

        public int? ReferentPrijema { get; set; }

        public DateTime? VremePrijema { get; set; }

        public decimal? BrojKoleta { get; set; }

        [StringLength(50)]
        public string BrojFakture { get; set; }

        [StringLength(50)]
        public string BrojDeklaracije { get; set; }

        public decimal? Cena { get; set; }

        public int? OtpremaStavkaId { get; set; }

        public decimal CenaTarifa { get; set; }

        public decimal? Tezina { get; set; }

        public decimal? Zapremina { get; set; }

        [StringLength(50)]
        public string ZemljaPorekla { get; set; }

        public virtual Artikal Artikal { get; set; }

        public virtual JM JM1 { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Lokacija Lokacija1 { get; set; }

        public virtual LokacijaKlijenta LokacijaKlijenta { get; set; }

        public virtual Prijemnica Prijemnica1 { get; set; }

        public virtual Sarza Sarza1 { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }

        public virtual Skladiste Skladiste1 { get; set; }
    }
}