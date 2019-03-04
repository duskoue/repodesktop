using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Kontakt")]
    public class Kontakt
    {
        public Kontakt()
        {
            Artikals = new HashSet<Artikal>();
            CarinskaOtpremnicas = new HashSet<CarinskaOtpremnica>();
            CarinskaOtpremnicas1 = new HashSet<CarinskaOtpremnica>();
            CarinskaOtpremnicas2 = new HashSet<CarinskaOtpremnica>();
            CarinskaOtpremnicas3 = new HashSet<CarinskaOtpremnica>();
            CarinskaOtpremnicas4 = new HashSet<CarinskaOtpremnica>();
            CarinskaPrijemnicas = new HashSet<CarinskaPrijemnica>();
            CarinskaPrijemnicas1 = new HashSet<CarinskaPrijemnica>();
            CarinskaPrijemnicas2 = new HashSet<CarinskaPrijemnica>();
            InterniPrenos = new HashSet<InterniPreno>();
            InterniPrenos1 = new HashSet<InterniPreno>();
            Kontakt1 = new HashSet<Kontakt>();
            LokacijaKlijentas = new HashSet<LokacijaKlijenta>();
            Otpremnicas = new HashSet<Otpremnica>();
            Otpremnicas1 = new HashSet<Otpremnica>();
            Popis = new HashSet<Popi>();
            RazdvajanjePrijemas = new HashSet<RazdvajanjePrijema>();
            Uslugas = new HashSet<Usluga>();
        }

        [Key]
        [StringLength(15)]
        public string Sifra { get; set; }

        [StringLength(15)]
        public string SifraVodeceg { get; set; }

        public int Tip { get; set; }

        [Required]
        [StringLength(256)]
        public string Naziv { get; set; }

        [StringLength(50)]
        public string Grad { get; set; }

        [StringLength(50)]
        public string Posta { get; set; }

        [StringLength(256)]
        public string Adresa { get; set; }

        [StringLength(16)]
        public string PIB { get; set; }

        [StringLength(20)]
        public string Telefon { get; set; }

        [StringLength(20)]
        public string Fax { get; set; }

        [StringLength(256)]
        public string Email { get; set; }

        [StringLength(128)]
        public string KontaktOsoba { get; set; }

        public int? Tarifa { get; set; }

        public int? TolerancijaPrijema { get; set; }

        public bool EksternoSkladiste { get; set; }

        public int NacinOdabira { get; set; }

        public bool BrojacCarinskeGrupe { get; set; }

        [StringLength(50)]
        public string UserName { get; set; }

        public int BrojDanaIsteka { get; set; }

        [StringLength(60)]
        public string Ulica { get; set; }

        [StringLength(20)]
        public string KucniBroj { get; set; }

        [StringLength(3)]
        public string SifraDrzave { get; set; }

        [StringLength(30)]
        public string EksternaSifra { get; set; }

        public double? X { get; set; }

        public double? Y { get; set; }

        public bool MogucPrilazKamionu { get; set; }

        public int? TMKontaktID { get; set; }

        public bool FlagNZT { get; set; }

        public bool OtpremaNivoPosiljke { get; set; }

       
        public virtual ICollection<Artikal> Artikals { get; set; }


        public virtual ICollection<CarinskaOtpremnica> CarinskaOtpremnicas { get; set; }


        public virtual ICollection<CarinskaOtpremnica> CarinskaOtpremnicas1 { get; set; }


        public virtual ICollection<CarinskaOtpremnica> CarinskaOtpremnicas2 { get; set; }


        public virtual ICollection<CarinskaOtpremnica> CarinskaOtpremnicas3 { get; set; }


        public virtual ICollection<CarinskaOtpremnica> CarinskaOtpremnicas4 { get; set; }


        public virtual ICollection<CarinskaPrijemnica> CarinskaPrijemnicas { get; set; }


        public virtual ICollection<CarinskaPrijemnica> CarinskaPrijemnicas1 { get; set; }


        public virtual ICollection<CarinskaPrijemnica> CarinskaPrijemnicas2 { get; set; }


        public virtual ICollection<InterniPreno> InterniPrenos { get; set; }


        public virtual ICollection<InterniPreno> InterniPrenos1 { get; set; }


        public virtual ICollection<Kontakt> Kontakt1 { get; set; }

        public virtual Kontakt Kontakt2 { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }


        public virtual ICollection<LokacijaKlijenta> LokacijaKlijentas { get; set; }


        public virtual ICollection<Otpremnica> Otpremnicas { get; set; }


        public virtual ICollection<Otpremnica> Otpremnicas1 { get; set; }


        public virtual ICollection<Popi> Popis { get; set; }


        public virtual ICollection<RazdvajanjePrijema> RazdvajanjePrijemas { get; set; }


        public virtual ICollection<Usluga> Uslugas { get; set; }
    }
}