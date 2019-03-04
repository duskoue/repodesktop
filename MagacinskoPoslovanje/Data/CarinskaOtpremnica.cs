using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("CarinskaOtpremnica")]
    public class CarinskaOtpremnica
    {
        public CarinskaOtpremnica()
        {
            CarinskaOtpremnicaStavkes = new HashSet<CarinskaOtpremnicaStavke>();
        }

        public int ID { get; set; }

        [StringLength(20)]
        public string Broj { get; set; }

        [Required]
        [StringLength(15)]
        public string MagacinskiBroj { get; set; }

        public int CarinskaPrijemnica { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime Datum { get; set; }

        public DateTime DatumIsporuke { get; set; }

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
        public string PodnosilacIsprave { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }

        [StringLength(15)]
        public string Posiljalac { get; set; }

        [StringLength(15)]
        public string Primalac { get; set; }

        public DateTime DatumKreiranja { get; set; }

        [StringLength(15)]
        public string Spediter { get; set; }

        public int BrojJ7 { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        //[Column(TypeName = "timestamp")]
        //[MaxLength(8)]
        //[Timestamp]
        public byte[] RowVersion { get; set; }

        public int? BorderoStavka { get; set; }

        [StringLength(250)]
        public string PrimalacNaziv { get; set; }

        [StringLength(250)]
        public string Prevoznik { get; set; }

        [StringLength(10)]
        public string BorderoBroj { get; set; }

        [StringLength(250)]
        public string PosiljalacNaziv { get; set; }

        [StringLength(50)]
        public string PosiljalacGrad { get; set; }

        [StringLength(50)]
        public string PosiljalacPosBr { get; set; }

        [StringLength(250)]
        public string PosiljalacAdresa { get; set; }

        [StringLength(120)]
        public string PosiljalacKontakt { get; set; }

        [StringLength(50)]
        public string PrimalacGrad { get; set; }

        [StringLength(50)]
        public string PrimalacPosBr { get; set; }

        [StringLength(250)]
        public string PrimalacAdresa { get; set; }

        [StringLength(120)]
        public string PrimalacKontakt { get; set; }

        public int? EdId { get; set; }

        [StringLength(250)]
        public string IspravkaDeklaracije { get; set; }

        [StringLength(15)]
        public string PosiljalacJci { get; set; }

        [StringLength(250)]
        public string PosiljalacNazivJci { get; set; }

        [StringLength(50)]
        public string PosiljalacPosBrJci { get; set; }

        [StringLength(50)]
        public string PosiljalacGradJci { get; set; }

        [StringLength(250)]
        public string PosiljalacAdresaJci { get; set; }

        [StringLength(120)]
        public string PosiljalacKontaktJci { get; set; }

        public bool Distribucija { get; set; }

        public bool Preneto { get; set; }

        public bool Urgentno { get; set; }

        public bool PotpisanaOtpremnica { get; set; }

        public decimal UkupnoPaleta { get; set; }

        [StringLength(100)]
        public string PlatilacNaziv { get; set; }

        public int? PlatilacTMID { get; set; }

        public int? Status { get; set; }

        [StringLength(50)]
        public string EksternaSifra { get; set; }

        public bool RobuPratiFaktura { get; set; }

        public bool RobuPrateCarinskiPapiri { get; set; }

        public decimal BrojKoleta { get; set; }

        public bool Zapisnik { get; set; }

        public decimal? UkupnaZapremina { get; set; }

        public virtual CarinskaPrijemnica CarinskaPrijemnica1 { get; set; }

        public virtual Kontakt Kontakt { get; set; }

        public virtual Kontakt Kontakt1 { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Kontakt Kontakt2 { get; set; }

        public virtual Kontakt Kontakt3 { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }

        public virtual Skladiste Skladiste1 { get; set; }

        public virtual Kontakt Kontakt4 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarinskaOtpremnicaStavke> CarinskaOtpremnicaStavkes { get; set; }
    }
}
