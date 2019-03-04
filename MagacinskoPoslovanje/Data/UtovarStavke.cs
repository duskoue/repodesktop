using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("UtovarStavke")]
    public  class UtovarStavke
    {
        public int ID { get; set; }

        public int Utovar { get; set; }

        public int Status { get; set; }

        [StringLength(15)]
        public string Vlasnik { get; set; }

        [StringLength(15)]
        public string Kupac { get; set; }

        [StringLength(256)]
        public string NazivKupca { get; set; }

        public decimal Zapremina { get; set; }

        public decimal Tezina { get; set; }

        [Required]
        [StringLength(20)]
        public string BrojNZI { get; set; }

        public int? Otpremnica { get; set; }

        public int? CarinskaOtpremnica { get; set; }

        public int Stop { get; set; }

        public int PlaniraniNalog { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public decimal? Koleta { get; set; }

        public decimal? UtovarenoKoleta { get; set; }

        public decimal? UtovarenaTezina { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }

        public int? NalogZaTransportID { get; set; }

        public virtual Utovar Utovar1 { get; set; }
    }
}
