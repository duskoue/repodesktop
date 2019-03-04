using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("NabavniNalogStavke")]
    public class NabavniNalogStavke
    {
        public int ID { get; set; }

        public int NabavniNalog { get; set; }

        [StringLength(128)]
        public string EksternaSifra { get; set; }

        [StringLength(128)]
        public string EksternaSifraStavke { get; set; }

        public DateTime OcekivaniDatum { get; set; }

        [StringLength(50)]
        public string SifraDobavljaca { get; set; }

        [StringLength(50)]
        public string NazivDobavljaca { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        public decimal Kolicina { get; set; }

        public bool DozvoljenNeogranicenVisak { get; set; }

        public decimal? TolerancijaVisak { get; set; }

        public decimal? TolerancijaManjak { get; set; }

        [Required]
        [StringLength(4)]
        public string JM { get; set; }

        [StringLength(10)]
        public string Pogon { get; set; }

        [StringLength(50)]
        public string EksternoSkladiste { get; set; }

        [StringLength(10)]
        public string PostavljanjeKategorijeTroska { get; set; }

        [StringLength(50)]
        public string MestoTroska { get; set; }

        [StringLength(50)]
        public string EksterniNalog { get; set; }

        public bool ZavrsenaIsporuka { get; set; }

        [StringLength(50)]
        public string SerijskiBroj { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public bool Obrisano { get; set; }

        [StringLength(50)]
        public string EksterniKorisnik { get; set; }

        [StringLength(100)]
        public string ReferentTM { get; set; }

        public int? RbrPoslovnica { get; set; }

        [StringLength(50)]
        public string Primalac { get; set; }

        public bool Ocarinjeno { get; set; }

        public bool ReturnsIndicator { get; set; }

        public bool BlockedIndicator { get; set; }

        public string ContentText { get; set; }

        [StringLength(128)]
        public string EksternaSifra2 { get; set; }

        [StringLength(128)]
        public string EksternaSifraStavke2 { get; set; }

        public virtual NabavniNalog NabavniNalog1 { get; set; }
    }
}