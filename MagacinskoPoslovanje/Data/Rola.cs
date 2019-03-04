using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Rola")]
    public class Rola
    {
        public Rola()
        {
            Korisniks = new HashSet<Korisnik>();
            Pravoes = new HashSet<Pravo>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Required]
        [StringLength(32)]
        public string Naziv { get; set; }

        [StringLength(250)]
        public string Opis { get; set; }

       
        public virtual ICollection<Korisnik> Korisniks { get; set; }

        
        public virtual ICollection<Pravo> Pravoes { get; set; }
    }
}