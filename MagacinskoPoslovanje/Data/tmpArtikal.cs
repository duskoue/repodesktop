using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("tmpArtikal")]
    public class tmpArtikal
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(30)]
        public string Sifra { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(15)]
        public string SifraVlasnika { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(256)]
        public string Naziv { get; set; }

        [Key]
        [Column(Order = 4)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Pakovanje { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(4)]
        public string PodrazumevanaJM { get; set; }

        [Key]
        [Column(Order = 6)]
        public decimal NetoTezina { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal BrutoTezina { get; set; }

        [Key]
        [Column(Order = 8)]
        public decimal Zapremina { get; set; }

        public decimal? Cena { get; set; }

        [Key]
        [Column(Order = 9)]
        [StringLength(3)]
        public string Grupa { get; set; }

        [StringLength(10)]
        public string Zona { get; set; }

        [Key]
        [Column(Order = 10)]
        public bool SarzaDatumProizvodnje { get; set; }

        [Key]
        [Column(Order = 11)]
        public bool SarzaDatumIsteka { get; set; }

        [Key]
        [Column(Order = 12)]
        public bool SarzaSerijskiBroj { get; set; }

        [Key]
        [Column(Order = 13)]
        public bool SarzaMagacinskiBroj { get; set; }

        [Key]
        [Column(Order = 14)]
        public bool SarzaSerijaOdDo { get; set; }

        [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StrategijaOdabira { get; set; }

        [Key]
        [Column(Order = 16)]
        public bool SarzaAtribut1 { get; set; }

        [Key]
        [Column(Order = 17)]
        public bool SarzaAtribut2 { get; set; }

        public int? Tarifa { get; set; }

        [Key]
        [Column(Order = 18)]
        public bool UlazniAtribut1 { get; set; }

        [Key]
        [Column(Order = 19)]
        public bool UlazniAtribut2 { get; set; }

        [Key]
        [Column(Order = 20)]
        public bool UlazniAtribut3 { get; set; }

        [Key]
        [Column(Order = 21)]
        public bool IzlazniAtribut1 { get; set; }

        [Key]
        [Column(Order = 22)]
        public bool IzlazniAtribut2 { get; set; }

        [Key]
        [Column(Order = 23)]
        public bool IzlazniAtribut3 { get; set; }

        [StringLength(20)]
        public string Kategorija { get; set; }

        [Key]
        [Column(Order = 24)]
        public DateTime DatumKreiranja { get; set; }

        [Key]
        [Column(Order = 25)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Kreirao { get; set; }

        [Key]
        [Column(Order = 26)]
        public DateTime DatumPromene { get; set; }

        [Key]
        [Column(Order = 27)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Promenio { get; set; }

        [Key]
        [Column(Order = 28)]
        public bool SarzaSerija { get; set; }

        [Key]
        [Column(Order = 29)]
        public bool RucniUpdate { get; set; }

        [Key]
        [Column(Order = 30)]
        public bool SarzaBrojDeklaracije { get; set; }

        [Key]
        [Column(Order = 31)]
        public bool SarzaBrojFakture { get; set; }

        public int? CarinskaGrupa { get; set; }

        [StringLength(50)]
        public string TarifniBroj { get; set; }

        public decimal? MinimumZaliha { get; set; }

        [Key]
        
        public bool Neaktivan { get; set; }

        [StringLength(4)]
        public string SAPTypeId { get; set; }

        [StringLength(40)]
        public string SAPManufacturerPartNumber { get; set; }

        [StringLength(30)]
        public string MTPCode { get; set; }
    }
}
