using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("EksterniPrenosStavke")]
    public class EksterniPrenosStavke
    {
        public int ID { get; set; }

        public int EksterniPrenos { get; set; }

        [StringLength(10)]
        public string MestoTroska { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [StringLength(10)]
        public string PogonPrijema { get; set; }

        [StringLength(10)]
        public string EksternoSkladistePrijema { get; set; }

        [StringLength(128)]
        public string EksternaSifra { get; set; }

        [StringLength(128)]
        public string EksternaSifraStavke { get; set; }

        public decimal Kolicina { get; set; }

        [Required]
        [StringLength(4)]
        public string JM { get; set; }

        [StringLength(10)]
        public string Pogon { get; set; }

        [StringLength(10)]
        public string EksternoSkladiste { get; set; }

        [StringLength(50)]
        public string SerijskiBroj { get; set; }

        public bool Obrisano { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        [StringLength(10)]
        public string TipKretanja { get; set; }

        [StringLength(25)]
        public string BrojSredstva { get; set; }

        [StringLength(10)]
        public string PodbrojSredstva { get; set; }

        [StringLength(25)]
        public string Primalac { get; set; }

        [StringLength(25)]
        public string GLBroj { get; set; }

        [StringLength(10)]
        public string Oblast { get; set; }

        public bool? GMDozvoljenaRezervacija { get; set; }

        public bool? SpecijalniIndikatorZalihe { get; set; }

        [StringLength(10)]
        public string BrojKupca1 { get; set; }

        [StringLength(10)]
        public string SifraDobavljaca { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }
    }
}
