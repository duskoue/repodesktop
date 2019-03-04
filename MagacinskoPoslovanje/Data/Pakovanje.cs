using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Pakovanje")]
    public class Pakovanje
    {
        public Pakovanje()
        {
            Artikals = new HashSet<Artikal>();
            Barcodes = new HashSet<Barcode>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(64)]
        public string Sifra { get; set; }

        [Required]
        [StringLength(128)]
        public string Opis { get; set; }

        [Required]
        [StringLength(4)]
        public string OsnovnaJM { get; set; }

        [StringLength(4)]
        public string JMNivo1 { get; set; }

        public decimal? Odnos1 { get; set; }

        [StringLength(4)]
        public string JMNivo2 { get; set; }

        public decimal? Odnos2 { get; set; }

        [StringLength(4)]
        public string JMNivo3 { get; set; }

        public decimal? Odnos3 { get; set; }

        [StringLength(4)]
        public string JMNivo4 { get; set; }

        public decimal? Odnos4 { get; set; }

        public decimal? Kutija { get; set; }

        public decimal? Paleta { get; set; }

      
        public virtual ICollection<Artikal> Artikals { get; set; }

      
        public virtual ICollection<Barcode> Barcodes { get; set; }

        public virtual JM JM { get; set; }

        public virtual JM JM1 { get; set; }

        public virtual JM JM2 { get; set; }

        public virtual JM JM3 { get; set; }

        public virtual JM JM4 { get; set; }
    }
}