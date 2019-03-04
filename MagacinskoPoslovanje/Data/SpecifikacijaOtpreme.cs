using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("SpecifikacijaOtpreme")]
    public   class SpecifikacijaOtpreme
    {
        public int ID { get; set; }

        public int? Otpremnica { get; set; }

        public DateTime? Datum { get; set; }

        [StringLength(20)]
        public string Broj { get; set; }

        [StringLength(256)]
        public string NazivKupca { get; set; }

        [StringLength(128)]
        public string EksternaSifra { get; set; }

        [StringLength(128)]
        public string EksternaSifra2 { get; set; }

        public int? RB { get; set; }

        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [StringLength(256)]
        public string ArtikalNaziv { get; set; }

        public decimal? Isporuceno { get; set; }

        public decimal? Povrat { get; set; }

        [StringLength(400)]
        public string Napomena { get; set; }

        public decimal? BrojKoleta { get; set; }

        [StringLength(256)]
        public string NazivProdavca { get; set; }

        public decimal? NabavnaCena { get; set; }

        public decimal? ProdajnaCena { get; set; }

        public DateTime DatumKreiranja { get; set; }

        [StringLength(15)]
        public string Kupac { get; set; }

        [StringLength(15)]
        public string Prodavac { get; set; }

        public int? SpecZaCarinjenje { get; set; }

        public decimal JedNetoTezina { get; set; }

        [StringLength(50)]
        public string Tarifa { get; set; }

        public decimal JedBrutoTezina { get; set; }
    }
}
