using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Korisnik")]
    public class Korisnik
    {
        public Korisnik()
        {
            Blokadas = new HashSet<Blokada>();
            CarinskaOtpremnicas = new HashSet<CarinskaOtpremnica>();
            CarinskaOtpremnicas1 = new HashSet<CarinskaOtpremnica>();
            CarinskaOtpremnicaStavkes = new HashSet<CarinskaOtpremnicaStavke>();
            CarinskaOtpremnicaStavkes1 = new HashSet<CarinskaOtpremnicaStavke>();
            CarinskaPrijemnicas = new HashSet<CarinskaPrijemnica>();
            CarinskaPrijemnicas1 = new HashSet<CarinskaPrijemnica>();
            CarinskaPrijemnicas2 = new HashSet<CarinskaPrijemnica>();
            CarinskaPrijemnicaStavkes = new HashSet<CarinskaPrijemnicaStavke>();
            CarinskaPrijemnicaStavkes1 = new HashSet<CarinskaPrijemnicaStavke>();
            InterniPrenos = new HashSet<InterniPreno>();
            InterniPrenos1 = new HashSet<InterniPreno>();
            InterniPrenosStavkes = new HashSet<InterniPrenosStavke>();
            InterniPrenosStavkes1 = new HashSet<InterniPrenosStavke>();
            Otpremnicas = new HashSet<Otpremnica>();
            Otpremnicas1 = new HashSet<Otpremnica>();
            OtpremnicaStavkes = new HashSet<OtpremnicaStavke>();
            OtpremnicaStavkes1 = new HashSet<OtpremnicaStavke>();
            PodesavanjeZalihaStavkes = new HashSet<PodesavanjeZalihaStavke>();
            Posaos = new HashSet<Posao>();
            Prijemnicas = new HashSet<Prijemnica>();
            Prijemnicas1 = new HashSet<Prijemnica>();
            PrijemnicaStavkes = new HashSet<PrijemnicaStavke>();
            PrijemnicaStavkes1 = new HashSet<PrijemnicaStavke>();
            RazdvajanjePrijemas = new HashSet<RazdvajanjePrijema>();
            RazdvajanjePrijemas1 = new HashSet<RazdvajanjePrijema>();
            RazdvajanjePrijemaStavkes = new HashSet<RazdvajanjePrijemaStavke>();
            RazdvajanjePrijemaStavkes1 = new HashSet<RazdvajanjePrijemaStavke>();
            Rolas = new HashSet<Rola>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string KorisnickoIme { get; set; }

        [Required]
        [StringLength(64)]
        public string Lozinka { get; set; }

        [Required]
        [StringLength(50)]
        public string Ime { get; set; }

        [StringLength(50)]
        public string Prezime { get; set; }

        [StringLength(20)]
        public string Telefon { get; set; }

        [StringLength(32)]
        public string Email { get; set; }

        public bool Aktivan { get; set; }

      
        public virtual ICollection<Blokada> Blokadas { get; set; }

      
        public virtual ICollection<CarinskaOtpremnica> CarinskaOtpremnicas { get; set; }

       
        public virtual ICollection<CarinskaOtpremnica> CarinskaOtpremnicas1 { get; set; }

       
        public virtual ICollection<CarinskaOtpremnicaStavke> CarinskaOtpremnicaStavkes { get; set; }

       
        public virtual ICollection<CarinskaOtpremnicaStavke> CarinskaOtpremnicaStavkes1 { get; set; }

       
        public virtual ICollection<CarinskaPrijemnica> CarinskaPrijemnicas { get; set; }

       
        public virtual ICollection<CarinskaPrijemnica> CarinskaPrijemnicas1 { get; set; }

      
        public virtual ICollection<CarinskaPrijemnica> CarinskaPrijemnicas2 { get; set; }

       
        public virtual ICollection<CarinskaPrijemnicaStavke> CarinskaPrijemnicaStavkes { get; set; }

       
        public virtual ICollection<CarinskaPrijemnicaStavke> CarinskaPrijemnicaStavkes1 { get; set; }

       
        public virtual ICollection<InterniPreno> InterniPrenos { get; set; }

       
        public virtual ICollection<InterniPreno> InterniPrenos1 { get; set; }

      
        public virtual ICollection<InterniPrenosStavke> InterniPrenosStavkes { get; set; }

      
        public virtual ICollection<InterniPrenosStavke> InterniPrenosStavkes1 { get; set; }

       
        public virtual ICollection<Otpremnica> Otpremnicas { get; set; }

       
        public virtual ICollection<Otpremnica> Otpremnicas1 { get; set; }

        
        public virtual ICollection<OtpremnicaStavke> OtpremnicaStavkes { get; set; }

        
        public virtual ICollection<OtpremnicaStavke> OtpremnicaStavkes1 { get; set; }

       
        public virtual ICollection<PodesavanjeZalihaStavke> PodesavanjeZalihaStavkes { get; set; }

       
        public virtual ICollection<Posao> Posaos { get; set; }

       
        public virtual ICollection<Prijemnica> Prijemnicas { get; set; }

        
        public virtual ICollection<Prijemnica> Prijemnicas1 { get; set; }

        
        public virtual ICollection<PrijemnicaStavke> PrijemnicaStavkes { get; set; }

      
        public virtual ICollection<PrijemnicaStavke> PrijemnicaStavkes1 { get; set; }

        
        public virtual ICollection<RazdvajanjePrijema> RazdvajanjePrijemas { get; set; }

       
        public virtual ICollection<RazdvajanjePrijema> RazdvajanjePrijemas1 { get; set; }

     
        public virtual ICollection<RazdvajanjePrijemaStavke> RazdvajanjePrijemaStavkes { get; set; }

       
        public virtual ICollection<RazdvajanjePrijemaStavke> RazdvajanjePrijemaStavkes1 { get; set; }

        
        public virtual ICollection<Rola> Rolas { get; set; }
    }
}
