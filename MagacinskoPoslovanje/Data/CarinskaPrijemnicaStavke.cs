using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("CarinskaPrijemnicaStavke")]
    public class CarinskaPrijemnicaStavke
    {
        public int ID { get; set; }

        public int RB { get; set; }

        public int CarinskaPrijemnica { get; set; }

        public int TipDokumenta { get; set; }

        [Required]
        [StringLength(50)]
        public string BrojDokumenta { get; set; }

        [Required]
        [StringLength(128)]
        public string Dokument { get; set; }

        [Required]
        [StringLength(128)]
        public string TrgovackiNaziv { get; set; }

        public decimal BrojKoleta { get; set; }

        public decimal Tezina { get; set; }

        public decimal Vrednost { get; set; }

        [Required]
        [StringLength(3)]
        public string Valuta { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public int? CPPrenos { get; set; }

        public decimal? BrojKoletaFaktura { get; set; }

        public decimal? Zapremina { get; set; }

        public virtual CarinskaPrijemnica CarinskaPrijemnica1 { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }

        public virtual Skladiste Skladiste1 { get; set; }

        public virtual Valuta Valuta1 { get; set; }
    }
}