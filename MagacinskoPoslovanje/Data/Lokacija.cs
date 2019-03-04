using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MagacinskoPoslovanje.Data
{
    [Table("Lokacija")]
    public class Lokacija
    {
        public Lokacija()
        {
            ArtikliLokacijes = new HashSet<ArtikliLokacije>();
            InterniPrenosStavkes = new HashSet<InterniPrenosStavke>();
            InterniPrenosStavkes1 = new HashSet<InterniPrenosStavke>();
            Otpremnicas = new HashSet<Otpremnica>();
            PopisListas = new HashSet<PopisLista>();
            PrijemnicaStavkes = new HashSet<PrijemnicaStavke>();
        }

        [Key]
        [StringLength(10)]
        public string Sifra { get; set; }

        public decimal Duzina { get; set; }

        public decimal Sirina { get; set; }

        public decimal Visina { get; set; }

        [Required]
        [StringLength(15)]
        public string Identifikator { get; set; }

        public int TipLokacije { get; set; }

        [Required]
        [StringLength(10)]
        public string Zona { get; set; }

        public decimal Sekvenca { get; set; }

        public decimal ZapreminskiKapacitet { get; set; }

        public decimal TezinskiKapacitet { get; set; }

        public bool IzgubitiLPN { get; set; }

        [Required]
        [StringLength(8)]
        public string Skladiste { get; set; }

        public decimal PaletniKapacitet { get; set; }

        public bool Neaktivna { get; set; }

        public DateTime? SledeciObracun { get; set; }

        [StringLength(10)]
        public string Prefiks { get; set; }

        public bool? Zatvorena { get; set; }

      
        public virtual ICollection<ArtikliLokacije> ArtikliLokacijes { get; set; }

        
        public virtual ICollection<InterniPrenosStavke> InterniPrenosStavkes { get; set; }

       
        public virtual ICollection<InterniPrenosStavke> InterniPrenosStavkes1 { get; set; }

        public virtual Sifarnik Sifarnik { get; set; }

        public virtual Zona Zona1 { get; set; }

      
        public virtual ICollection<Otpremnica> Otpremnicas { get; set; }

      
        public virtual ICollection<PopisLista> PopisListas { get; set; }

        
        public virtual ICollection<PrijemnicaStavke> PrijemnicaStavkes { get; set; }
    }
}