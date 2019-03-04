using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("StanjeZalihaArhiva")]
    public   class StanjeZalihaArhiva
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        public DateTime Datum { get; set; }

        public int Sarza { get; set; }

        [Required]
        [StringLength(10)]
        public string Lokacija { get; set; }

        [Required]
        [StringLength(18)]
        public string LPN { get; set; }

        [Required]
        [StringLength(15)]
        public string ArtikalVlasnik { get; set; }

        [Required]
        [StringLength(30)]
        public string ArtikalSifra { get; set; }

        public decimal Kolicina { get; set; }

        [StringLength(50)]
        public string SerijskiBroj { get; set; }

        public decimal? SerijaOd { get; set; }

        public decimal? SerijaDo { get; set; }

        public DateTime? DatumIsteka { get; set; }

        public DateTime? DatumProizvodnje { get; set; }

        [StringLength(50)]
        public string MagacinskiBroj { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public decimal PaletniKapacitet { get; set; }

        [StringLength(50)]
        public string EksternoSkladiste { get; set; }

        [StringLength(250)]
        public string Atribut1 { get; set; }

        [StringLength(250)]
        public string Atribut2 { get; set; }

        [StringLength(50)]
        public string BrojFakture { get; set; }

        [StringLength(50)]
        public string BrojDeklaracije { get; set; }

        public decimal? BrutoTezinaArtikla { get; set; }

        public decimal? NetoTezinaArtikla { get; set; }
    }
}
