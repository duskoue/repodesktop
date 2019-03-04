using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Prijemnica")]
    public class Prijemnica
    {
        public Prijemnica()
        {
            PrijemnicaStavkes = new HashSet<PrijemnicaStavke>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string Broj { get; set; }

        public DateTime Datum { get; set; }

        [Required]
        [StringLength(15)]
        public string Vlasnik { get; set; }

        public int TipPrijema { get; set; }

        public int Status { get; set; }

        [StringLength(15)]
        public string MagacinskiBroj { get; set; }

        [StringLength(128)]
        public string EksternaSifra { get; set; }

        [StringLength(250)]
        public string Prevoznik { get; set; }

        [StringLength(50)]
        public string Vozilo { get; set; }

        [StringLength(50)]
        public string Vozac { get; set; }

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

        public decimal? UkupnoPaleta { get; set; }

        public DateTime? VremePrispeca { get; set; }

        public DateTime? VremeZatvaranja { get; set; }

        public DateTime? VremeNajave { get; set; }

        [StringLength(15)]
        public string Kupac { get; set; }

        [StringLength(256)]
        public string NazivKupca { get; set; }

        [StringLength(10)]
        public string PostanskiBroj { get; set; }

        [StringLength(50)]
        public string Grad { get; set; }

        [StringLength(256)]
        public string Adresa { get; set; }

        [StringLength(128)]
        public string KontaktOsoba { get; set; }

        [StringLength(20)]
        public string Telefon { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }

        [StringLength(128)]
        public string EksternaSifra2 { get; set; }

        [StringLength(50)]
        public string EksternoSkladiste { get; set; }

        public bool? Poslato { get; set; }

        public int? NabavniNalogID { get; set; }

        public int? NalogZaPakovanjeID { get; set; }

        [StringLength(10)]
        public string EksternaLokacija { get; set; }

        public decimal? UkupnaTezina { get; set; }

        [StringLength(50)]
        public string EksterniKorisnik { get; set; }

        public int? SastavnicaID { get; set; }

        public bool Distribucija { get; set; }

        public bool Preneto { get; set; }

        public bool Urgentno { get; set; }

        [StringLength(250)]
        public string KreatorExcel { get; set; }

        public int? PorukaKnjizenjaID { get; set; }

        public DateTime? VremeZahtevaZaRaspoznavanje { get; set; }

        public DateTime? VremeStrucnogRaspoznavanja { get; set; }

        public bool TrazenoStrucnoRaspoznavanje { get; set; }

        [StringLength(32)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Napomena1 { get; set; }

        [StringLength(50)]
        public string Napomena2 { get; set; }

        public DateTime? VremePreuzimanjaPovrata { get; set; }

        [StringLength(50)]
        public string KreatorEmail { get; set; }

        [StringLength(50)]
        public string PodnosilacIsprave { get; set; }

        [StringLength(50)]
        public string Nalogodavac { get; set; }

        public decimal? UkupnoKoleta { get; set; }

        [StringLength(50)]
        public string BrojFakture { get; set; }

        public decimal? McKomada { get; set; }

        public decimal? UkupnaVrednost { get; set; }

        public int? Otpremnica { get; set; }

        public bool PredatoDistribuciji { get; set; }

        [StringLength(50)]
        public string BrojDeklaracije { get; set; }

        public int? CarinskaPrijemnicaID { get; set; }

        [StringLength(60)]
        public string Ulica { get; set; }

        [StringLength(20)]
        public string KucniBroj { get; set; }

        [StringLength(3)]
        public string SifraDrzave { get; set; }

        public decimal? Tezina { get; set; }

        public decimal? Zapremina { get; set; }

        public int? RazlogPovrata { get; set; }

        [StringLength(20)]
        public string BrojOtpremnice { get; set; }

        public DateTime? VremeZavrsetkaPrijema { get; set; }

        public bool UvezeneStavke { get; set; }

        public int? TipDokumenta { get; set; }

        [StringLength(5)]
        public string CarinskaIspostava { get; set; }

        public DateTime? JCIDatum { get; set; }

        public bool StorniranaOtpremnicom { get; set; }

        [StringLength(50)]
        public string EksterniSistem { get; set; }

        public bool Zapisnik { get; set; }

        [StringLength(3)]
        public string Valuta { get; set; }

        [StringLength(128)]
        public string TrgovackiNaziv { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual LokacijaKlijenta LokacijaKlijenta { get; set; }

        public virtual LokacijaKlijenta LokacijaKlijenta1 { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }

        public virtual Sifarnik Sifarnik1 { get; set; }

        public virtual Skladiste Skladiste1 { get; set; }

       
        public virtual ICollection<PrijemnicaStavke> PrijemnicaStavkes { get; set; }
    }
}