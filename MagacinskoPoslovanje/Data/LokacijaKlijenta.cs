using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{

    [Table("LokacijaKlijenta")]
    public class LokacijaKlijenta
    {
        public LokacijaKlijenta()
        {
            Otpremnicas = new HashSet<Otpremnica>();
            //Prijemnicas = new HashSet<Prijemnica>();
          //  Prijemnicas1 = new HashSet<Prijemnica>();
            PrijemnicaStavkes = new HashSet<PrijemnicaStavke>();
            Zalihas = new HashSet<Zaliha>();
        }

       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 0)]
        [StringLength(15)]
        public string SifraVlasnika { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string SifraLokacije { get; set; }

        [Required]
        [StringLength(50)]
        public string NazivLokacije { get; set; }

        [StringLength(50)]
        public string EksternaSifraLokacije { get; set; }

        public bool NePrateSeUIAtributi { get; set; }

        public virtual Kontakt Kontakt { get; set; }


        public virtual ICollection<Otpremnica> Otpremnicas { get; set; }


     //   public virtual ICollection<Prijemnica> Prijemnicas { get; set; }


    //    public virtual ICollection<Prijemnica> Prijemnicas1 { get; set; }


        public virtual ICollection<PrijemnicaStavke> PrijemnicaStavkes { get; set; }


        public virtual ICollection<Zaliha> Zalihas { get; set; }
    }
}