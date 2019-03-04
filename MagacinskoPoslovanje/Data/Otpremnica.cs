using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Otpremnica")]
    public class Otpremnica
    {
        public Otpremnica()
        {
            Odabirs = new HashSet<Odabir>();
            OtpremnicaStatusLogs = new HashSet<OtpremnicaStatusLog>();
            OtpremnicaStavkes = new HashSet<OtpremnicaStavke>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Broj { get; set; }

        [StringLength(128)]
        public string EksternaSifra { get; set; }

        public int Tip { get; set; }

        public int Status { get; set; }

        [Required]
        [StringLength(15)]
        public string Vlasnik { get; set; }

        [StringLength(15)]
        public string MagacinskiBroj { get; set; }

        public int? CarinskaOtpremnica { get; set; }

        public DateTime Datum { get; set; }

        public DateTime DatumIsporuke { get; set; }

        [StringLength(15)]
        public string Kupac { get; set; }

        [Required]
        [StringLength(256)]
        public string NazivKupca { get; set; }

        [Required]
        [StringLength(50)]
        public string Grad { get; set; }

        [StringLength(10)]
        public string PostanskiBroj { get; set; }

        [StringLength(256)]
        public string Adresa { get; set; }

        [StringLength(128)]
        public string KontaktOsoba { get; set; }

        [StringLength(20)]
        public string Telefon { get; set; }

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

        public int? RazdvajanjePrijema { get; set; }

        public bool Distribucija { get; set; }

        public bool Preneto { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }

        [StringLength(5)]
        public string PrefiksLPN { get; set; }

        public bool NacinPlacanja { get; set; }

        public bool LicnoUrucenje { get; set; }

        public bool Otkupnina { get; set; }

        public bool Povratnica { get; set; }

        public bool OsiguranjeRobe { get; set; }

        [StringLength(10)]
        public string EksternaLokacija { get; set; }

        public bool Urgentno { get; set; }

        public bool SpecijalniPrevoz { get; set; }

        [StringLength(400)]
        public string RazlogStorniranja { get; set; }

        [StringLength(128)]
        public string EksternaSifra2 { get; set; }

        public decimal? BrojPaketa { get; set; }

        public decimal? Tezina { get; set; }

        public decimal? Zapremina { get; set; }

        public decimal? BrojPaleta { get; set; }

        [StringLength(50)]
        public string EksternoSkladiste { get; set; }

        public bool? EksterniStorno { get; set; }

        public bool? Poslato { get; set; }

        public DateTime? RealizovanoVremeIsporuke { get; set; }

        [StringLength(50)]
        public string Napomena1 { get; set; }

        [StringLength(50)]
        public string Napomena2 { get; set; }

        public bool AngazovanjeRadneSnage { get; set; }

        public int? EksterniPrenosID { get; set; }

        [StringLength(50)]
        public string EksternoSkladistePrijema { get; set; }

        public DateTime? StvarnoRealizovanoVreme { get; set; }

        [StringLength(50)]
        public string EksterniKorisnik { get; set; }

        [StringLength(20)]
        public string StatusKnjizenja { get; set; }

        [StringLength(250)]
        public string KreatorExcel { get; set; }

        public bool PotrebnaKorekcija { get; set; }

        public DateTime? VremeZahtevaZaKorekciju { get; set; }

        [StringLength(400)]
        public string NapomenaKorekcije { get; set; }

        public DateTime? VremeKorekcijeNaloga { get; set; }

        [StringLength(32)]
        public string Email { get; set; }

        [StringLength(50)]
        public string KreatorEmail { get; set; }

        [StringLength(50)]
        public string PodnosilacIsprave { get; set; }

        [StringLength(20)]
        public string RegistracijaVozila { get; set; }

        [StringLength(50)]
        public string Nalogodavac { get; set; }

        public int? TipPrevoza { get; set; }

        public int? TipDokumenta { get; set; }

        [StringLength(50)]
        public string BrojDokumenta { get; set; }

        public bool GenerisaneCO { get; set; }

        public bool PotpisanaOtpremnica { get; set; }

        [StringLength(15)]
        public string Prodavac { get; set; }

        public int? Prijemnica { get; set; }

        public int? FormiranoPaleta { get; set; }

        [StringLength(50)]
        public string Vozac { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        public decimal? Udaljenost { get; set; }

        public decimal? Amount { get; set; }

        public bool Zapisnik { get; set; }

        public int? BrojStavki { get; set; }

        [StringLength(60)]
        public string Ulica { get; set; }

        [StringLength(20)]
        public string KucniBroj { get; set; }

        [StringLength(3)]
        public string SifraDrzave { get; set; }

        public bool PogresnoOdvojeno { get; set; }

        [StringLength(256)]
        public string InternaNapomena { get; set; }

        public DateTime? VremeIsporukeWMS { get; set; }

        public bool UvezeneStavke { get; set; }

        [StringLength(50)]
        public string Pomocno1 { get; set; }

        [StringLength(50)]
        public string Pomocno2 { get; set; }

        [StringLength(50)]
        public string Pomocno3 { get; set; }

        public bool StorniranaPrijemnicom { get; set; }

        [StringLength(128)]
        public string EkstSifraNabNaloga { get; set; }

        [StringLength(50)]
        public string EksterniSistem { get; set; }

        [StringLength(10)]
        public string LinijaEkspedicije { get; set; }

        [StringLength(50)]
        public string IzlazniLPN { get; set; }

        public int? B2BID { get; set; }

        public Guid? SalesOrderGUID { get; set; }

        public bool ExportFlagNZT { get; set; }

        public bool KontrolaNalepnice { get; set; }

        public virtual IzlazniID IzlazniID { get; set; }

        public virtual Kontakt Kontakt { get; set; }

        public virtual Kontakt Kontakt1 { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Lokacija Lokacija { get; set; }

        public virtual LokacijaKlijenta LokacijaKlijenta { get; set; }

        
        public virtual ICollection<Odabir> Odabirs { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }

        public virtual Skladiste Skladiste1 { get; set; }

      
        public virtual ICollection<OtpremnicaStatusLog> OtpremnicaStatusLogs { get; set; }

        
        public virtual ICollection<OtpremnicaStavke> OtpremnicaStavkes { get; set; }
    }
}