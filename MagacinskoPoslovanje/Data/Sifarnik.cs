using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Data
{
    [Table("Sifarnik")]
    public class Sifarnik
    {

        public Sifarnik()
        {
            //Blokada = new HashSet<Blokada>();
            //CarinskaOtpremnica = new HashSet<CarinskaOtpremnica>();
            //CarinskaOtpremnicaStavke = new HashSet<CarinskaOtpremnicaStavke>();
            //CarinskaPrijemnica = new HashSet<CarinskaPrijemnica>();
            //CarinskaPrijemnicaStavke = new HashSet<CarinskaPrijemnicaStavke>();
            //IzlazniID = new HashSet<IzlazniID>();
            //Kontakt = new HashSet<Kontakt>();
            //Lokacija = new HashSet<Lokacija>();
            //Odabir = new HashSet<Odabir>();
            //Otpremnica = new HashSet<Otpremnica>();
            //OtpremnicaStavke = new HashSet<OtpremnicaStavke>();
            //PodesavanjeZalihaStavke = new HashSet<PodesavanjeZalihaStavke>();
            //Posao = new HashSet<Posao>();
            //Posao1 = new HashSet<Posao>();
            //Prijemnica = new HashSet<Prijemnica>();
            //Prijemnica1 = new HashSet<Prijemnica>();
            //PrijemnicaStavke = new HashSet<PrijemnicaStavke>();
            //Usluga = new HashSet<Usluga>();
            //Zaliha = new HashSet<Zaliha>();
        }

        #region PROPERTY CLASS
        public int ID { get; set; }

        public int SifarnikEntitetaTip { get; set; }

        
        public string Sifra { get; set; }

       
        public string Naziv { get; set; }
        #endregion

        #region PROPERTY NAVIGACIJA

        //public virtual ICollection<Blokada> Blokada { get; set; }


        //public virtual ICollection<CarinskaOtpremnica> CarinskaOtpremnica { get; set; }


        //public virtual ICollection<CarinskaOtpremnicaStavke> CarinskaOtpremnicaStavke { get; set; }


        //public virtual ICollection<CarinskaPrijemnica> CarinskaPrijemnica { get; set; }


        //public virtual ICollection<CarinskaPrijemnicaStavke> CarinskaPrijemnicaStavke { get; set; }


        //public virtual ICollection<IzlazniID> IzlazniID { get; set; }


        //public virtual ICollection<Kontakt> Kontakt { get; set; }


        //public virtual ICollection<Lokacija> Lokacija { get; set; }


        //public virtual ICollection<Odabir> Odabir { get; set; }


        //public virtual ICollection<Otpremnica> Otpremnica { get; set; }


        //public virtual ICollection<OtpremnicaStavke> OtpremnicaStavke { get; set; }


        //public virtual ICollection<PodesavanjeZalihaStavke> PodesavanjeZalihaStavke { get; set; }


        //public virtual ICollection<Posao> Posao { get; set; }


        //public virtual ICollection<Posao> Posao1 { get; set; }


        //public virtual ICollection<Prijemnica> Prijemnica { get; set; }


        //public virtual ICollection<Prijemnica> Prijemnica1 { get; set; }


        //public virtual ICollection<PrijemnicaStavke> PrijemnicaStavke { get; set; }

        public virtual SifarnikEntitetaTip SifarnikEntitetaTip1 { get; set; }


        //public virtual ICollection<Usluga> Usluga { get; set; }


        //public virtual ICollection<Zaliha> Zaliha { get; set; }

        #endregion
    }
}
