using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Atribut")]
    public class Atribut
    {
        public int ID { get; set; }

        [StringLength(30)]
        public string UlazniAtribut1 { get; set; }

        [StringLength(30)]
        public string UlazniAtribut2 { get; set; }

        [StringLength(30)]
        public string UlazniAtribut3 { get; set; }

        [StringLength(30)]
        public string IzlazniAtribut1 { get; set; }

        [StringLength(30)]
        public string IzlazniAtribut2 { get; set; }

        [StringLength(30)]
        public string IzlazniAtribut3 { get; set; }

        [StringLength(5)]
        public string UlazIzlaz { get; set; }

        public int? IzvorID { get; set; }

        public int? Odabir { get; set; }

        [StringLength(15)]
        public string SifraVlasnika { get; set; }

        [StringLength(30)]
        public string SifraArtikla { get; set; }

        public int? Sarza { get; set; }

        [StringLength(10)]
        public string Lokacija { get; set; }

        [StringLength(18)]
        public string LPN { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public int? IzvorStavkaID { get; set; }

        [StringLength(10)]
        public string AplikacijaIzvor { get; set; }
    }
}
