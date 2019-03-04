using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("GrupaStavke")]
    public class GrupaStavke
    {
        public int ID { get; set; }

        public int Grupa { get; set; }

        public int Otpremnica { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public int Kreirao { get; set; }

        public DateTime DatumPromene { get; set; }

        public int Promenio { get; set; }

        public int Prioritet { get; set; }

        public virtual Grupa Grupa1 { get; set; }
    }
}