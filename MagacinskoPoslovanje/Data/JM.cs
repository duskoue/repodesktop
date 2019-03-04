using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("JM")]
    public class JM
    {
        public JM()
        {
            Artikals = new HashSet<Artikal>();
            Barcodes = new HashSet<Barcode>();
           InterniPrenosStavkes = new HashSet<InterniPrenosStavke>();
           InterniPrenosStavkes1 = new HashSet<InterniPrenosStavke>();
            OtpremnicaStavkes = new HashSet<OtpremnicaStavke>();
            Pakovanjes = new HashSet<Pakovanje>();
            Pakovanjes1 = new HashSet<Pakovanje>();
            Pakovanjes2 = new HashSet<Pakovanje>();
            Pakovanjes3 = new HashSet<Pakovanje>();
            Pakovanjes4 = new HashSet<Pakovanje>();
           PrijemnicaStavkes = new HashSet<PrijemnicaStavke>();
        }

        [Key]
        [StringLength(4)]
        public string Sifra { get; set; }

        [Required]
        [StringLength(50)]
        public string Naziv { get; set; }

        public bool Fiksno { get; set; }

      
        public virtual ICollection<Artikal> Artikals { get; set; }

       
        public virtual ICollection<Barcode> Barcodes { get; set; }
        public virtual ICollection<InterniPrenosStavke> InterniPrenosStavkes { get; set; }


        public virtual ICollection<InterniPrenosStavke> InterniPrenosStavkes1 { get; set; }


        public virtual ICollection<OtpremnicaStavke> OtpremnicaStavkes { get; set; }


        public virtual ICollection<Pakovanje> Pakovanjes { get; set; }

       
        public virtual ICollection<Pakovanje> Pakovanjes1 { get; set; }

      
        public virtual ICollection<Pakovanje> Pakovanjes2 { get; set; }

      
        public virtual ICollection<Pakovanje> Pakovanjes3 { get; set; }

       
        public virtual ICollection<Pakovanje> Pakovanjes4 { get; set; }


        public virtual ICollection<PrijemnicaStavke> PrijemnicaStavkes { get; set; }
    }
}