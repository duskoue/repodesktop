using MagacinskoPoslovanje.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Artikal")]
    public class Artikal
    {
        public Artikal()
        {
            ArtikliLokacije = new HashSet<ArtikliLokacije>();
            ArtikliZamena = new HashSet<ArtikliZamena>();
            Barcode = new HashSet<Barcode>();
            InterniPrenosStavke = new HashSet<InterniPrenosStavke>();
            InterniPrenosStavke1 = new HashSet<InterniPrenosStavke>();
            Odabir = new HashSet<Odabir>();
            OtpremnicaStavke = new HashSet<OtpremnicaStavke>();
            PodesavanjeZalihaStavke = new HashSet<PodesavanjeZalihaStavke>();
            PopisLista = new HashSet<PopisLista>();
            Posao = new HashSet<Posao>();
            PrijemnicaStavke = new HashSet<PrijemnicaStavke>();
            Sarza = new HashSet<Sarza>();
            Sastavnica = new HashSet<Sastavnica>();
            Zaliha = new HashSet<Zaliha>();
        }


        #region property class
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string Sifra { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(15)]
        public string SifraVlasnika { get; set; }

        [Required]
        [StringLength(256)]
        public string Naziv { get; set; }

        public int Pakovanje { get; set; }

        [Required]
        [StringLength(4)]
        public string PodrazumevanaJM { get; set; }

        public decimal NetoTezina { get; set; }

        public decimal BrutoTezina { get; set; }

        public decimal Zapremina { get; set; }

        public decimal? Cena { get; set; }

        [Required]
        [StringLength(3)]
        public string Grupa { get; set; }

        [StringLength(10)]
        public string Zona { get; set; }

        public bool SarzaDatumProizvodnje { get; set; }

        public bool SarzaDatumIsteka { get; set; }

        public bool SarzaSerijskiBroj { get; set; }

        public bool SarzaMagacinskiBroj { get; set; }

        public bool SarzaSerijaOdDo { get; set; }

        public int StrategijaOdabira { get; set; }

        public bool SarzaAtribut1 { get; set; }

        public bool SarzaAtribut2 { get; set; }

        public int? Tarifa { get; set; }

        public bool UlazniAtribut1 { get; set; }

        public bool UlazniAtribut2 { get; set; }

        public bool UlazniAtribut3 { get; set; }

        public bool IzlazniAtribut1 { get; set; }

        public bool IzlazniAtribut2 { get; set; }

        public bool IzlazniAtribut3 { get; set; }

        [StringLength(20)]
        public string Kategorija { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public bool SarzaSerija { get; set; }

        public bool RucniUpdate { get; set; }

        public bool SarzaBrojDeklaracije { get; set; }

        public bool SarzaBrojFakture { get; set; }

        public int? CarinskaGrupa { get; set; }

        [StringLength(50)]
        public string TarifniBroj { get; set; }

        public decimal? MinimumZaliha { get; set; }

        public bool Neaktivan { get; set; }

        [StringLength(4)]
        public string SAPTypeId { get; set; }

        [StringLength(40)]
        public string SAPManufacturerPartNumber { get; set; }

        [StringLength(30)]
        public string MTPCode { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }

        public bool DozvoliGenerisanjeUIAtributa { get; set; }

        [StringLength(50)]
        public string Brand { get; set; }

        [StringLength(50)]
        public string Boja { get; set; }

        [StringLength(50)]
        public string Varijanta { get; set; }

        [StringLength(50)]
        public string SifraProizvodjaca { get; set; }

        #endregion

        #region PROPERTY NAVIGACIJA
        public virtual JM JM { get; set; }

        public virtual Kontakt Kontakt { get; set; }

        public virtual Pakovanje Pakovanje1 { get; set; }

        public virtual Tarifa Tarifa1 { get; set; }


        public virtual ICollection<ArtikliLokacije> ArtikliLokacije { get; set; }


        public virtual ICollection<ArtikliZamena> ArtikliZamena { get; set; }


        public virtual ICollection<Barcode> Barcode { get; set; }


        public virtual ICollection<InterniPrenosStavke> InterniPrenosStavke { get; set; }


        public virtual ICollection<InterniPrenosStavke> InterniPrenosStavke1 { get; set; }


        public virtual ICollection<Odabir> Odabir { get; set; }


        public virtual ICollection<OtpremnicaStavke> OtpremnicaStavke { get; set; }


        public virtual ICollection<PodesavanjeZalihaStavke> PodesavanjeZalihaStavke { get; set; }


        public virtual ICollection<PopisLista> PopisLista { get; set; }


        public virtual ICollection<Posao> Posao { get; set; }


        public virtual ICollection<PrijemnicaStavke> PrijemnicaStavke { get; set; }


        public virtual ICollection<Sarza> Sarza { get; set; }


        public virtual ICollection<Sastavnica> Sastavnica { get; set; }


        public virtual ICollection<Zaliha> Zaliha { get; set; }

        #endregion
    }
}
