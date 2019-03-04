using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("CarinskaPrijemnica")]
    public class CarinskaPrijemnica
    {
        public CarinskaPrijemnica()
        {
            CarinskaOtpremnicas = new HashSet<CarinskaOtpremnica>();
            CarinskaPrijemnicaStavkes = new HashSet<CarinskaPrijemnicaStavke>();
            RazdvajanjePrijemas = new HashSet<RazdvajanjePrijema>();
        }

        public int ID { get; set; }

        [Required]
       [StringLength(15)]
        public string MagacinskiBroj { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime Datum { get; set; }

        public int TipPrevoza { get; set; }

        [Required]
        [StringLength(15)]
        public string Vlasnik { get; set; }

        [StringLength(20)]
        public string RegistracijaVozila { get; set; }

        [Required]
        [StringLength(5)]
        public string Carinarnica { get; set; }

        [StringLength(50)]
        public string BrojTranzitnogDok { get; set; }

        [StringLength(50)]
        public string PodnosilacIsprave { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }

        [StringLength(15)]
        public string Posiljalac { get; set; }

        public int BrojJ7 { get; set; }

        public DateTime DatumKreiranja { get; set; }

        [StringLength(15)]
        public string Spediter { get; set; }

        public int Uskladistio { get; set; }

        public bool Povezana { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

       // [Column(TypeName = "timestamptz")]
        //[MaxLength(8)]
       // [Timestamp]
        public byte[] RowVersion { get; set; }

        public int? Bordero { get; set; }

        [StringLength(10)]
        public string BorderoBroj { get; set; }

        [StringLength(250)]
        public string PosiljalacNaziv { get; set; }

        public int? EdId { get; set; }

        [StringLength(250)]
        public string IspravkaDeklaracije { get; set; }

        public decimal? UkupnoPaleta { get; set; }

        public int? InterniPrenos { get; set; }

        [StringLength(20)]
        public string EksterniMB { get; set; }

        public bool Obracunato { get; set; }

        [StringLength(50)]
        public string Kontejner { get; set; }

        public DateTime? JCIDatum { get; set; }

        public bool Izvoz { get; set; }

        public int? Prijemnica { get; set; }

        public int? Status { get; set; }

        [StringLength(50)]
        public string EksternaSifra { get; set; }

        public decimal? UkupnoKoleta { get; set; }

        public decimal? UkupnaZapremina { get; set; }

        public virtual CarinskaIspostava CarinskaIspostava { get; set; }


        public virtual ICollection<CarinskaOtpremnica> CarinskaOtpremnicas { get; set; }

        public virtual Kontakt Kontakt { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Kontakt Kontakt1 { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }

        public virtual Skladiste Skladiste1 { get; set; }

        public virtual Kontakt Kontakt2 { get; set; }

        public virtual Korisnik Korisnik2 { get; set; }


        public virtual ICollection<CarinskaPrijemnicaStavke> CarinskaPrijemnicaStavkes { get; set; }


        public virtual ICollection<RazdvajanjePrijema> RazdvajanjePrijemas { get; set; }
    }
}