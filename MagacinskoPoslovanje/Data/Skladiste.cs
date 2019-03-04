using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Skladiste")]
    public class Skladiste
    {
        public Skladiste()
        {
            CarinskaOtpremnicas = new HashSet<CarinskaOtpremnica>();
            CarinskaOtpremnicaStavkes = new HashSet<CarinskaOtpremnicaStavke>();
            CarinskaPrijemnicas = new HashSet<CarinskaPrijemnica>();
            CarinskaPrijemnicaStavkes = new HashSet<CarinskaPrijemnicaStavke>();
            InterniPrenos = new HashSet<InterniPreno>();
            InterniPrenosStavkes = new HashSet<InterniPrenosStavke>();
            Otpremnicas = new HashSet<Otpremnica>();
            OtpremnicaStavkes = new HashSet<OtpremnicaStavke>();
            PodesavanjeZalihas = new HashSet<PodesavanjeZaliha>();
            PodesavanjeZalihaStavkes = new HashSet<PodesavanjeZalihaStavke>();
            Prijemnicas = new HashSet<Prijemnica>();
            PrijemnicaStavkes = new HashSet<PrijemnicaStavke>();
        }

        [Key]
        [StringLength(8)]
        public string Sifra { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        public double? X { get; set; }

        public double? Y { get; set; }

       
        public virtual ICollection<CarinskaOtpremnica> CarinskaOtpremnicas { get; set; }

      
        public virtual ICollection<CarinskaOtpremnicaStavke> CarinskaOtpremnicaStavkes { get; set; }

      
        public virtual ICollection<CarinskaPrijemnica> CarinskaPrijemnicas { get; set; }

       
        public virtual ICollection<CarinskaPrijemnicaStavke> CarinskaPrijemnicaStavkes { get; set; }

       
        public virtual ICollection<InterniPreno> InterniPrenos { get; set; }

       
        public virtual ICollection<InterniPrenosStavke> InterniPrenosStavkes { get; set; }

      
        public virtual ICollection<Otpremnica> Otpremnicas { get; set; }

       
        public virtual ICollection<OtpremnicaStavke> OtpremnicaStavkes { get; set; }

       
        public virtual ICollection<PodesavanjeZaliha> PodesavanjeZalihas { get; set; }

        
        public virtual ICollection<PodesavanjeZalihaStavke> PodesavanjeZalihaStavkes { get; set; }

       
        public virtual ICollection<Prijemnica> Prijemnicas { get; set; }

       
        public virtual ICollection<PrijemnicaStavke> PrijemnicaStavkes { get; set; }
    }
}