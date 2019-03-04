using MagacinskoPoslovanje.Data;
using MagacinskoPoslovanje.Map;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.Context
{
    public class MpContext : DbContext
    {
        public MpContext(string connection) : base(connection)
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<MpContext>());
        }

        #region DB SET

        public virtual DbSet<Artikal> Artikal { get; set; }
        public virtual DbSet<ArtikliLokacije> ArtikliLokacije { get; set; }
        public virtual DbSet<ArtikliZamena> ArtikliZamena { get; set; }
        public virtual DbSet<Atribut> Atribut { get; set; }
        public virtual DbSet<Barcode> Barcode { get; set; }
        public virtual DbSet<Blokada> Blokada { get; set; }
        public virtual DbSet<Brojac> Brojac { get; set; }
        public virtual DbSet<CarinskaGrupaArtikla> CarinskaGrupaArtikala { get; set; }
        public virtual DbSet<CarinskaIspostava> CarinskaIspostava { get; set; }
        public virtual DbSet<CarinskaOtpremnica> CarinskaOtpremnica { get; set; }
        public virtual DbSet<CarinskaOtpremnicaStavke> CarinskaOtpremnicaStavke { get; set; }
        public virtual DbSet<CarinskaPrijemnica> CarinskaPrijemnica { get; set; }
        public virtual DbSet<CarinskaPrijemnicaStavke> CarinskaPrijemnicaStavke { get; set; }
        public virtual DbSet<CrossDock> CrosDock { get; set; }
        public virtual DbSet<DodatnoAngazovaniRadnik> DodatnoAngazovaniRadnik { get; set; }
        public virtual DbSet<EksterniKorisnik> EksterniKorisnik { get; set; }
        public virtual DbSet<EksterniPreno> EksterniPrenos { get; set; }
        public virtual DbSet<EksterniPrenosStavke> EksterniPrenosStavke { get; set; }
        public virtual DbSet<Grupa> Grupa { get; set; }
        public virtual DbSet<GrupaStavke> GrupaStavke { get; set; }
        public virtual DbSet<ImportSerijskihBrojevaTemp> ImportSerijskihBrojevaTemp { get; set; }
        public virtual DbSet<InterfaceLog> InterfaceLog { get; set; }
        public virtual DbSet<InterniPreno> InterniPrenos { get; set; }
        public virtual DbSet<InterniPrenosStavke> InterniPrenosStavke { get; set; }
        public virtual DbSet<IzlazniID> IzlazniID { get; set; }
        public virtual DbSet<IzvestajSkladistenja> IzvestajSkladistenja { get; set; }
        public virtual DbSet<JCINaimenovanja> JCINaimenovanja { get; set; }
        public virtual DbSet<JM> JM { get; set; }
        public virtual DbSet<KEPU> KEPU { get; set; }
        public virtual DbSet<Kontakt> Kontakt { get; set; }
        public virtual DbSet<Kontejner> Kontejner { get; set; }
        public virtual DbSet<Korisnik> Korisnik { get; set; }
        public virtual DbSet<KontejnerPrijem> KontejnerPrijem { get; set; }
        public virtual DbSet<LogHost> LogHost { get; set; }
        public virtual DbSet<Lokacija> Lokacija { get; set; }
        public virtual DbSet<LokacijaKlijenta> LokacijaKlijenta { get; set; }
        public virtual DbSet<LPN> LPN { get; set; }
        public virtual DbSet<Mesto> Mesto { get; set; }
        public virtual DbSet<NabavniNalog> NabavniNalog { get; set; }
        public virtual DbSet<NabavniNalogStavke> NabavniNalogStavke { get; set; }
        public virtual DbSet<NalogZaPakovanje> NalogZaPakovanje { get; set; }
        public virtual DbSet<NeradniDani> NeradniDani { get; set; }
        public virtual DbSet<Oblast> Oblast { get; set; }
        public virtual DbSet<Obracun> Obracun { get; set; }
        public virtual DbSet<ObracunCarinski> ObracunCarinski { get; set; }
        public virtual DbSet<ObracunKomercijalni> ObracunKomercijalni { get; set; }
        public virtual DbSet<Odabir> Odabir { get; set; }
        public virtual DbSet<Otpremnica> Otpremnica { get; set; }
        public virtual DbSet<OtpremnicaKontrola> OtpremnicaKontrola { get; set; }
        public virtual DbSet<OtpremnicaStatusLog> OtpremnicaStatusLog { get; set; }
        public virtual DbSet<OtpremnicaStavke> OtpremnicaStavke { get; set; }
        public virtual DbSet<Pakovanje> Pakovanje { get; set; }
        public virtual DbSet<Parametrizacija> Parametrizacija { get; set; }
        public virtual DbSet<PodesavanjaFormi> PodesavanjaFormi { get; set; }
        public virtual DbSet<PodesavanjeZaliha> PodesavanjeZaliha { get; set; }
        public virtual DbSet<PodesavanjeZalihaStavke> PodesavanjeZalihaStavke { get; set; }
        public virtual DbSet<Popi> Popis { get; set; }
        public virtual DbSet<PopisLista> PopisLista { get; set; }
        public virtual DbSet<PopisStavke> PopisStavke { get; set; }
        public virtual DbSet<PorukaKnjizenja> PorukaKnjizenja { get; set; }
        public virtual DbSet<Posao> Posao { get; set; }
        public virtual DbSet<Pravo> Pravo { get; set; }
        public virtual DbSet<Prijemnica> Prijemnica { get; set; }
        public virtual DbSet<PrijemnicaStavke> PrijemnicaStavke { get; set; }
        public virtual DbSet<Prilog> Prilog { get; set; }
        public virtual DbSet<RazdvajanjePrijema> RazdvajanjePrijema { get; set; }
        public virtual DbSet<RazdvajanjePrijemaStavke> RazdvajanjePrijemaStavke { get; set; }
        public virtual DbSet<Rola> Rola { get; set; }
        public virtual DbSet<Sarza> Sarza { get; set; }
        public virtual DbSet<Sastavnica> Sastavnica { get; set; }
        public virtual DbSet<SastavnicaPrijem> SastavnicaPrijem { get; set; }
        public virtual DbSet<SastavnicaStavke> SastavnicaStavke { get; set; }
        public virtual DbSet<SerijskiBroj> SerijskiBroj { get; set; }
        public virtual DbSet<Sifarnik> Sifarnik { get; set; }
        public virtual DbSet<SifarnikEntiteta> SifarnikEntiteta { get; set; }
        public virtual DbSet<SifarnikEntitetaTip> SifarnikEntitetaTip { get; set; }
        public virtual DbSet<Skladiste> Skladiste { get; set; }
        public virtual DbSet<SpecifikacijaOtpreme> SpecifikacijaOpreme { get; set; }
        public virtual DbSet<SpecZaCarinjenje> SpecZaCarinjenje { get; set; }
        public virtual DbSet<SpecZaCarinjenjeStavke> SpecZaCarinjenjeStavke { get; set; }
        public virtual DbSet<StampaciNalepnice> StampaciNalepnice { get; set; }
        public virtual DbSet<StanjeZaliha> StanjeZaliha { get; set; }
        public virtual DbSet<StanjeZalihaArhiva> StanjeZalihaArhiva { get; set; }
        public virtual DbSet<StatusLog> StatusLog { get; set; }
        public virtual DbSet<StorageReportZenith> StorageReportZenith { get; set; }
        public virtual DbSet<StornoDokumenta> StornoDokumenta { get; set; }
        public virtual DbSet<Tarifa> Tarifa { get; set; }
        public virtual DbSet<TarifaStavke> TarifaStavke { get; set; }
        public virtual DbSet<TransakcijaZaliha> TransakcijeZaliha { get; set; }
        public virtual DbSet<Usluga> Usluga { get; set; }
        public virtual DbSet<Utovar> Utovar { get; set; }
        public virtual DbSet<UtovarStavke> UtovarStavke { get; set; }
        public virtual DbSet<Valuta> Valuta { get; set; }
        public virtual DbSet<Verzija> Verzija { get; set; }
        public virtual DbSet<ZahtevZaPromenuZaliha> ZahtevZaPromenuZaliha { get; set; }
        public virtual DbSet<Zaliha> Zaliha { get; set; }
        public virtual DbSet<Zona> Zona { get; set; }


        #endregion


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region ARTIKAL
            modelBuilder.Configurations.Add(new ArtikalMap());
            //modelBuilder.Entity<Artikal>().Property(e => e.Sifra).IsUnicode(false);
            //modelBuilder.Entity<Artikal>().Property(e => e.SifraVlasnika).IsUnicode(false);
            //modelBuilder.Entity<Artikal>().Property(e => e.PodrazumevanaJM).IsUnicode(false);
            //modelBuilder.Entity<Artikal>().Property(e => e.NetoTezina).HasPrecision(18, 4);
            //modelBuilder.Entity<Artikal>().Property(e => e.BrutoTezina).HasPrecision(18, 4);
            //modelBuilder.Entity<Artikal>().Property(e => e.Zapremina).HasPrecision(18, 4);
            //modelBuilder.Entity<Artikal>().Property(e => e.Cena).HasPrecision(18, 4);
            //modelBuilder.Entity<Artikal>().Property(e => e.Grupa).IsFixedLength().IsUnicode(false);
            //modelBuilder.Entity<Artikal>().Property(e => e.Zona).IsUnicode(false);
            //modelBuilder.Entity<Artikal>().Property(e => e.Kategorija).IsUnicode(false);
            //modelBuilder.Entity<Artikal>().Property(e => e.TarifniBroj).IsUnicode(false);
            //modelBuilder.Entity<Artikal>().Property(e => e.MinimumZaliha).HasPrecision(18, 4);
            //modelBuilder.Entity<Artikal>().Property(e => e.MTPCode).IsUnicode(false);

            //modelBuilder.Entity<Artikal>().HasMany(e => e.ArtikliLokacije)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Artikal>().HasMany(e => e.ArtikliZamena)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Artikal>()
            //    .HasMany(e => e.Barcode)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.SifraArtikla, e.SifraVlasnika })
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Artikal>()
            //    .HasMany(e => e.InterniPrenosStavke)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Artikal>()
            //    .HasMany(e => e.InterniPrenosStavke1)
            //    .WithRequired(e => e.Artikal1)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            ////modelBuilder.Entity<Artikal>()
            ////    .HasMany(e => e.Odabir)
            ////    .WithRequired(e => e.Artikal)
            ////    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            ////    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Artikal>()
            //    .HasMany(e => e.OtpremnicaStavke)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Artikal>()
            //    .HasMany(e => e.PodesavanjeZalihaStavke)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Artikal>()
            //    .HasMany(e => e.PopisLista)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Artikal>()
            //    .HasMany(e => e.Posao)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            ////modelBuilder.Entity<Artikal>()
            ////  .HasMany(e => e.PrijemnicaStavke)
            ////  .WithRequired(e => e.Artikal)
            ////  .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            ////  .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Artikal>()
            //    .HasMany(e => e.Sarza)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Artikal>()
            //    .HasMany(e => e.Sastavnica)
            //    .WithOptional(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalZaglavlja, e.Vlasnik });

            //modelBuilder.Entity<Artikal>()
            //    .HasMany(e => e.Zaliha)
            //    .WithRequired(e => e.Artikal)
            //    .HasForeignKey(e => new { e.ArtikalSifra, e.ArtikalVlasnik })
            //    .WillCascadeOnDelete(false);



            #endregion

            #region ARTIKLI LKACIJE
            //modelBuilder.Entity<ArtikliLokacije>().Property(e => e.ArtikalSifra).IsUnicode(false);
            //modelBuilder.Entity<ArtikliLokacije>().Property(e => e.ArtikalVlasnik).IsUnicode(false);
            //modelBuilder.Entity<ArtikliLokacije>().Property(e => e.Lokacija).IsUnicode(false);
            //modelBuilder.Entity<ArtikliLokacije>().Property(e => e.MinimalnaKolicina).HasPrecision(18, 4);
            //modelBuilder.Entity<ArtikliLokacije>().Property(e => e.MaksimalnaKolicina).HasPrecision(18, 4);
            //modelBuilder.Entity<ArtikliLokacije>().Property(e => e.NajmanjaJMDopune).IsUnicode(false);
            modelBuilder.Configurations.Add(new ArtikliLokacijeMap());

            #endregion

            #region ARTIKLI ZAMENA
            //modelBuilder.Entity<ArtikliZamena>().Property(e => e.ArtikalSifra).IsUnicode(false);
            //modelBuilder.Entity<ArtikliZamena>().Property(e => e.ArtikalVlasnik).IsUnicode(false);
            //modelBuilder.Entity<ArtikliZamena>().Property(e => e.Barcode).IsUnicode(false);

            #endregion

            #region ATRIBUTI

            //modelBuilder.Entity<Atribut>().Property(e => e.UlazniAtribut1).IsUnicode(false);
            //modelBuilder.Entity<Atribut>().Property(e => e.UlazniAtribut2).IsUnicode(false);
            //modelBuilder.Entity<Atribut>().Property(e => e.UlazniAtribut3).IsUnicode(false);
            //modelBuilder.Entity<Atribut>().Property(e => e.IzlazniAtribut1).IsUnicode(false);
            //modelBuilder.Entity<Atribut>().Property(e => e.IzlazniAtribut2).IsUnicode(false);
            //modelBuilder.Entity<Atribut>().Property(e => e.IzlazniAtribut3).IsUnicode(false);
            //modelBuilder.Entity<Atribut>().Property(e => e.UlazIzlaz).IsUnicode(false);
            //modelBuilder.Entity<Atribut>().Property(e => e.SifraArtikla).IsUnicode(false);
            //modelBuilder.Entity<Atribut>().Property(e => e.SifraVlasnika).IsUnicode(false);
            //modelBuilder.Entity<Atribut>().Property(e => e.Lokacija).IsUnicode(false);
            //modelBuilder.Entity<Atribut>().Property(e => e.LPN).IsUnicode(false);
            //modelBuilder.Entity<Atribut>().Property(e => e.AplikacijaIzvor).IsUnicode(false);


            #endregion

            //#region BARCODE

            //modelBuilder.Entity<Barcode>()
            //    .Property(e => e.Sifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Barcode>()
            //    .Property(e => e.SifraVlasnika)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Barcode>()
            //    .Property(e => e.SifraArtikla)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Barcode>()
            //    .Property(e => e.JM)
            //    .IsUnicode(false);
            //#endregion

            //#region BLOKADA

            //modelBuilder.Entity<Blokada>()
            //   .Property(e => e.Lokacija)
            //   .IsUnicode(false);

            //modelBuilder.Entity<Blokada>()
            //    .Property(e => e.LPN)
            //    .IsUnicode(false);

            //#endregion

            //#region CARINSKA GRUPA ARTIKALA

            //modelBuilder.Entity<CarinskaGrupaArtikla>()
            //   .Property(e => e.Vlasnik)
            //   .IsUnicode(false);

            //modelBuilder.Entity<CarinskaGrupaArtikla>()
            //    .Property(e => e.PodrazumevanaLokacija)
            //    .IsUnicode(false);
            //#endregion

            //#region CARINSKA ISPOSTAVA
            //modelBuilder.Entity<CarinskaIspostava>().Property(e => e.Sifra).IsUnicode(false);
            //modelBuilder.Entity<CarinskaIspostava>()
            //    .HasMany(e => e.CarinskaPrijemnicas)
            //    .WithRequired(e => e.CarinskaIspostava)
            //    .HasForeignKey(e => e.Carinarnica)
            //    .WillCascadeOnDelete(false);

            //#endregion

            //#region CARINSKA OTPREMNICA

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //   .Property(e => e.Broj)
            //   .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.MagacinskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.Vlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.Carinarnica)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.Posiljalac)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.Primalac)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.Spediter)
            //    .IsUnicode(false);

            modelBuilder.Entity<CarinskaOtpremnica>()
                .Property(e => e.RowVersion)
                .HasMaxLength(8).HasColumnName("timestamp");

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.BorderoBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.PosiljalacPosBr)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.PrimalacPosBr)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.PosiljalacJci)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.PosiljalacPosBrJci)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.UkupnoPaleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.BrojKoleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .Property(e => e.UkupnaZapremina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CarinskaOtpremnica>()
            //    .HasMany(e => e.CarinskaOtpremnicaStavkes)
            //    .WithRequired(e => e.CarinskaOtpremnica1)
            //    .HasForeignKey(e => e.CarinskaOtpremnica)
            //    .WillCascadeOnDelete(false);

            //
            
            //#endregion

            #region CARINSKA OTPREMNICA STAVKE

            //modelBuilder.Entity<CarinskaOtpremnicaStavke>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnicaStavke>()
            //    .Property(e => e.BrojDokumenta)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnicaStavke>()
            //    .Property(e => e.Dokument)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnicaStavke>()
            //    .Property(e => e.BrojKoleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CarinskaOtpremnicaStavke>()
            //    .Property(e => e.Tezina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CarinskaOtpremnicaStavke>()
            //    .Property(e => e.Vrednost)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CarinskaOtpremnicaStavke>()
            //    .Property(e => e.Valuta)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaOtpremnicaStavke>()
            //    .Property(e => e.Zapremina)
            //    .HasPrecision(18, 4);
            //#endregion

            #region CARINSKA PRIJEMNICA

            //modelBuilder.Entity<CarinskaPrijemnica>()
            // .Property(e => e.MagacinskiBroj)
            // .IsUnicode(false);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .Property(e => e.Vlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .Property(e => e.Carinarnica)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .Property(e => e.BrojTranzitnogDok)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .Property(e => e.Posiljalac)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .Property(e => e.Spediter)
            //    .IsUnicode(false);

            modelBuilder.Entity<CarinskaPrijemnica>()
                .Property(e => e.RowVersion)
                .HasMaxLength(8).HasColumnName("timestamp");

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .Property(e => e.BorderoBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .Property(e => e.UkupnoPaleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .Property(e => e.EksterniMB)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .Property(e => e.Kontejner)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .Property(e => e.UkupnoKoleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .Property(e => e.UkupnaZapremina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .HasMany(e => e.CarinskaOtpremnicas)
            //    .WithRequired(e => e.CarinskaPrijemnica1)
            //    .HasForeignKey(e => e.CarinskaPrijemnica)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .HasMany(e => e.CarinskaPrijemnicaStavkes)
            //    .WithRequired(e => e.CarinskaPrijemnica1)
            //    .HasForeignKey(e => e.CarinskaPrijemnica)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<CarinskaPrijemnica>()
            //    .HasMany(e => e.RazdvajanjePrijemas)
            //    .WithRequired(e => e.CarinskaPrijemnica1)
            //    .HasForeignKey(e => e.CarinskaPrijemnica)
            //    .WillCascadeOnDelete(false);

            #endregion

            //#region CARINSKA PRIJEMNICA STAVKE
            //modelBuilder.Entity<CarinskaPrijemnicaStavke>()
            //   .Property(e => e.BrojDokumenta)
            //   .IsUnicode(false);

            //modelBuilder.Entity<CarinskaPrijemnicaStavke>()
            //    .Property(e => e.Dokument)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaPrijemnicaStavke>()
            //    .Property(e => e.BrojKoleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CarinskaPrijemnicaStavke>()
            //    .Property(e => e.Tezina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CarinskaPrijemnicaStavke>()
            //    .Property(e => e.Valuta)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaPrijemnicaStavke>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CarinskaPrijemnicaStavke>()
            //    .Property(e => e.BrojKoletaFaktura)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CarinskaPrijemnicaStavke>()
            //    .Property(e => e.Zapremina)
            //    .HasPrecision(18, 4);

            #endregion

            //#region CROS DOCK

            //modelBuilder.Entity<CrossDock>()
            //    .Property(e => e.Tezina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CrossDock>()
            //    .Property(e => e.BrojPaleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<CrossDock>()
            //    .Property(e => e.Region)
            //    .IsUnicode(false);

            //modelBuilder.Entity<CrossDock>()
            //    .Property(e => e.BrojKoleta)
            //    .HasPrecision(18, 4);

            //#endregion

            //#region DODATNO ANGAZOVANJE RADNIKA
            //modelBuilder.Entity<DodatnoAngazovaniRadnik>()
            // .Property(e => e.Tabela)
            // .IsUnicode(false);
            //#endregion

            //#region EKSTERNI KORISNIK
            //modelBuilder.Entity<EksterniKorisnik>()
            //   .Property(e => e.Sifra)
            //   .IsUnicode(false);

            //modelBuilder.Entity<EksterniKorisnik>()
            //    .Property(e => e.Email)
            //    .IsUnicode(false);

            //#endregion

            //#region EKSTERNI PRENOS
            //modelBuilder.Entity<EksterniPreno>()
            //  .Property(e => e.BrojRezervacije)
            //  .IsUnicode(false);

            //modelBuilder.Entity<EksterniPreno>()
            //    .Property(e => e.PostanskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPreno>()
            //    .Property(e => e.Telefon)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPreno>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPreno>()
            //    .Property(e => e.EksterniKorisnik)
            //    .IsUnicode(false);
            //#endregion

            //#region EKSTERNI PRENOS STAVKE
            //modelBuilder.Entity<EksterniPrenosStavke>()
            //   .Property(e => e.MestoTroska)
            //   .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.ArtikalVlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.PogonPrijema)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.EksternoSkladistePrijema)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.EksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.EksternaSifraStavke)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.Kolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.JM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.Pogon)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.EksternoSkladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.SerijskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.TipKretanja)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.BrojSredstva)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.PodbrojSredstva)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.Primalac)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.GLBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.Oblast)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.BrojKupca1)
            //    .IsUnicode(false);

            //modelBuilder.Entity<EksterniPrenosStavke>()
            //    .Property(e => e.SifraDobavljaca)
            //    .IsUnicode(false);
            //#endregion

            //#region GRUPA

            //modelBuilder.Entity<Grupa>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            modelBuilder.Entity<Grupa>()
                .Property(e => e.RowVersion)
               .HasMaxLength(8).HasColumnName("timestamp");

            //modelBuilder.Entity<Grupa>()
            //    .Property(e => e.EksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Grupa>()
            //    .HasMany(e => e.GrupaStavkes)
            //    .WithRequired(e => e.Grupa1)
            //    .HasForeignKey(e => e.Grupa)
            //    .WillCascadeOnDelete(false);

            //#endregion

            //#region GRUPA STAVKE

            //modelBuilder.Entity<GrupaStavke>()
            //  .Property(e => e.Skladiste)
            //  .IsUnicode(false);

            //#endregion

            //#region IMPORT SERIJSKIH BROJEVA

            //modelBuilder.Entity<ImportSerijskihBrojevaTemp>()
            //   .Property(e => e.LPN)
            //   .IsUnicode(false);

            //modelBuilder.Entity<ImportSerijskihBrojevaTemp>()
            //    .Property(e => e.SerijskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ImportSerijskihBrojevaTemp>()
            //    .Property(e => e.Atribut1)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ImportSerijskihBrojevaTemp>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //#endregion

            //#region INTERFACE LOG

            //modelBuilder.Entity<InterfaceLog>()
            //  .Property(e => e.Vlasnik)
            //  .IsUnicode(false);

            //modelBuilder.Entity<InterfaceLog>()
            //    .Property(e => e.EksternaSifra2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterfaceLog>()
            //    .Property(e => e.EksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterfaceLog>()
            //    .Property(e => e.Tip)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterfaceLog>()
            //    .Property(e => e.Dokument)
            //    .IsUnicode(false);


            //#endregion

            //#region INTERNI PRENOS

            //modelBuilder.Entity<InterniPreno>()
            //    .Property(e => e.SaVlasnika)
            //    .IsUnicode(false);
            //modelBuilder.Entity<InterniPreno>()
            //    .Property(e => e.NaVlasnika)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPreno>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPreno>()
            //    .Property(e => e.RowVersion)
            //    .IsFixedLength();

            //modelBuilder.Entity<InterniPreno>()
            //    .Property(e => e.Broj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPreno>()
            //    .Property(e => e.EksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPreno>()
            //    .Property(e => e.EksternaSifra2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPreno>()
            //    .Property(e => e.KreatorEmail)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPreno>()
            //    .HasMany(e => e.InterniPrenosStavkes)
            //    .WithRequired(e => e.InterniPreno)
            //    .HasForeignKey(e => e.InterniPrenos)
            //    .WillCascadeOnDelete(false);

            //#endregion

            //#region INTERNI PRENOS STAVKE
            //modelBuilder.Entity<InterniPrenosStavke>()
            // .Property(e => e.Skladiste)
            // .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.SaVlasnika)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.SaArtikla)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.SaLokacije)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.SaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.SaJM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.NaVlasnika)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.NaArtikal)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.NaLokaciju)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.NaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.NaJM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.SerijskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.MagacinskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.SerijaOd)
            //    .HasPrecision(25, 0);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.SerijaDo)
            //    .HasPrecision(25, 0);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.Serija)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.SaLPN)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.NaLPN)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.BrojKoleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.BrojFakture)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.BrojDeklaracije)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.CenaTarifa)
            //    .HasPrecision(38, 20);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.TarifaJM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.BrojKoletaNa)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.EksternoSkladisteNa)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.EksternaSifraStavke)
            //    .IsUnicode(false);

            //modelBuilder.Entity<InterniPrenosStavke>()
            //    .Property(e => e.Cena)
            //    .HasPrecision(18, 4);
            //#endregion

            //#region IZLAZNI ID

            //modelBuilder.Entity<IzlazniID>()
            //  .Property(e => e.Sifra)
            //  .IsUnicode(false);

            //modelBuilder.Entity<IzlazniID>()
            //    .Property(e => e.LinijaEkspedicije)
            //    .IsUnicode(false);

            //modelBuilder.Entity<IzlazniID>()
            //    .HasMany(e => e.Otpremnicas)
            //    .WithOptional(e => e.IzlazniID)
            //    .HasForeignKey(e => e.IzlazniLPN);

            //#endregion

            //#region IZVESTAJ SKLADISTENJA

            //modelBuilder.Entity<IzvestajSkladistenja>()
            //  .Property(e => e.ArtikalVlasnik)
            //  .IsUnicode(false);

            //modelBuilder.Entity<IzvestajSkladistenja>()
            //    .Property(e => e.PaletaZona1)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<IzvestajSkladistenja>()
            //    .Property(e => e.PaletaZona2)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<IzvestajSkladistenja>()
            //    .Property(e => e.PaletaZona3)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<IzvestajSkladistenja>()
            //    .Property(e => e.PaletaZona4)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<IzvestajSkladistenja>()
            //    .Property(e => e.PaletaPrimljeno)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<IzvestajSkladistenja>()
            //    .Property(e => e.PaletaIzdato)
            //    .HasPrecision(18, 4);
            //#endregion

            //#region JCI NAIMENOVANJA

            //modelBuilder.Entity<JCINaimenovanja>()
            //   .Property(e => e.BrojKoleta)
            //   .HasPrecision(18, 4);

            //modelBuilder.Entity<JCINaimenovanja>()
            //    .Property(e => e.BrutoTezina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<JCINaimenovanja>()
            //    .Property(e => e.Carinarnica)
            //    .IsUnicode(false);
            //#endregion

            //#region JM

            //modelBuilder.Entity<JM>()
            //.Property(e => e.Sifra)
            //.IsUnicode(false);

            //modelBuilder.Entity<JM>()
            //    .Property(e => e.Naziv)
            //    .IsUnicode(false);

            //modelBuilder.Entity<JM>()
            //    .HasMany(e => e.Artikals)
            //    .WithRequired(e => e.JM)
            //    .HasForeignKey(e => e.PodrazumevanaJM)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<JM>()
            //    .HasMany(e => e.Barcodes)
            //    .WithRequired(e => e.JM1)
            //    .HasForeignKey(e => e.JM)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<JM>()
            //    .HasMany(e => e.InterniPrenosStavkes)
            //    .WithRequired(e => e.JM)
            //    .HasForeignKey(e => e.NaJM)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<JM>()
            //    .HasMany(e => e.InterniPrenosStavkes1)
            //    .WithRequired(e => e.JM1)
            //    .HasForeignKey(e => e.SaJM)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<JM>()
            //    .HasMany(e => e.OtpremnicaStavkes)
            //    .WithRequired(e => e.JM1)
            //    .HasForeignKey(e => e.JM)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<JM>()
            //    .HasMany(e => e.Pakovanjes)
            //    .WithRequired(e => e.JM)
            //    .HasForeignKey(e => e.OsnovnaJM)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<JM>()
            //    .HasMany(e => e.Pakovanjes1)
            //    .WithOptional(e => e.JM1)
            //    .HasForeignKey(e => e.JMNivo1);

            //modelBuilder.Entity<JM>()
            //    .HasMany(e => e.Pakovanjes2)
            //    .WithOptional(e => e.JM2)
            //    .HasForeignKey(e => e.JMNivo2);

            //modelBuilder.Entity<JM>()
            //    .HasMany(e => e.Pakovanjes3)
            //    .WithOptional(e => e.JM3)
            //    .HasForeignKey(e => e.JMNivo3);

            //modelBuilder.Entity<JM>()
            //    .HasMany(e => e.Pakovanjes4)
            //    .WithOptional(e => e.JM4)
            //    .HasForeignKey(e => e.JMNivo4);

            //modelBuilder.Entity<JM>()
            //    .HasMany(e => e.PrijemnicaStavkes)
            //    .WithRequired(e => e.JM1)
            //    .HasForeignKey(e => e.JM)
            //    .WillCascadeOnDelete(false);

            //#endregion

            #region KEPU

            //modelBuilder.Entity<KEPU>()
            //  .Property(e => e.Izvor)
            //  .IsUnicode(false);

            //modelBuilder.Entity<KEPU>()
            //    .Property(e => e.BrojIzvora)
            //    .IsUnicode(false);

            //modelBuilder.Entity<KEPU>()
            //    .Property(e => e.Zaduzenje)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<KEPU>()
            //    .Property(e => e.Razduzenje)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<KEPU>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //#endregion

            //#region KONTAKT

            //modelBuilder.Entity<Kontakt>()
            //   .Property(e => e.Sifra)
            //   .IsUnicode(false);


            //modelBuilder.Entity<Kontakt>()
            //    .Property(e => e.SifraVodeceg)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Kontakt>()
            //    .Property(e => e.Posta)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Kontakt>()
            //    .Property(e => e.PIB)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Kontakt>()
            //    .Property(e => e.Telefon)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Kontakt>()
            //    .Property(e => e.Fax)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Kontakt>()
            //    .Property(e => e.Email)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Kontakt>()
            //    .Property(e => e.EksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.Artikals)
            //    .WithRequired(e => e.Kontakt)
            //    .HasForeignKey(e => e.SifraVlasnika)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.CarinskaOtpremnicas)
            //    .WithRequired(e => e.Kontakt)
            //    .HasForeignKey(e => e.Vlasnik)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.CarinskaOtpremnicas1)
            //    .WithOptional(e => e.Kontakt1)
            //    .HasForeignKey(e => e.PosiljalacJci);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.CarinskaOtpremnicas2)
            //    .WithOptional(e => e.Kontakt2)
            //    .HasForeignKey(e => e.Posiljalac);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.CarinskaOtpremnicas3)
            //    .WithOptional(e => e.Kontakt3)
            //    .HasForeignKey(e => e.Primalac);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.CarinskaOtpremnicas4)
            //    .WithOptional(e => e.Kontakt4)
            //    .HasForeignKey(e => e.Spediter);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.CarinskaPrijemnicas)
            //    .WithRequired(e => e.Kontakt)
            //    .HasForeignKey(e => e.Vlasnik)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.CarinskaPrijemnicas1)
            //    .WithOptional(e => e.Kontakt1)
            //    .HasForeignKey(e => e.Posiljalac);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.CarinskaPrijemnicas2)
            //    .WithOptional(e => e.Kontakt2)
            //    .HasForeignKey(e => e.Spediter);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.InterniPrenos)
            //    .WithRequired(e => e.Kontakt)
            //    .HasForeignKey(e => e.NaVlasnika)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.InterniPrenos1)
            //    .WithRequired(e => e.Kontakt1)
            //    .HasForeignKey(e => e.SaVlasnika)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.Kontakt1)
            //    .WithOptional(e => e.Kontakt2)
            //    .HasForeignKey(e => e.SifraVodeceg);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.LokacijaKlijentas)
            //    .WithRequired(e => e.Kontakt)
            //    .HasForeignKey(e => e.SifraVlasnika)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.Otpremnicas)
            //    .WithOptional(e => e.Kontakt)
            //    .HasForeignKey(e => e.Kupac);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.Otpremnicas1)
            //    .WithRequired(e => e.Kontakt1)
            //    .HasForeignKey(e => e.Vlasnik)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.Popis)
            //    .WithRequired(e => e.Kontakt)
            //    .HasForeignKey(e => e.Vlasnik)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.RazdvajanjePrijemas)
            //    .WithRequired(e => e.Kontakt)
            //    .HasForeignKey(e => e.Vlasnik)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Kontakt>()
            //    .HasMany(e => e.Uslugas)
            //    .WithRequired(e => e.Kontakt)
            //    .HasForeignKey(e => e.Vlasnik)
            //    .WillCascadeOnDelete(false);

            #endregion

            #region KONTEJNER
            //modelBuilder.Entity<Kontejner>()
            //   .Property(e => e.Sifra)
            //   .IsUnicode(false);

            //modelBuilder.Entity<Kontejner>()
            //    .Property(e => e.Cena)
            //    .HasPrecision(18, 4);
            #endregion

            #region KONTEJNER PRIJEM
            //modelBuilder.Entity<KontejnerPrijem>()
            //    .Property(e => e.Izvor)
            //    .IsUnicode(false);

            //modelBuilder.Entity<KontejnerPrijem>()
            //    .Property(e => e.Paleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<KontejnerPrijem>()
            //    .Property(e => e.Kontejner)
            //    .IsUnicode(false);

            //modelBuilder.Entity<KontejnerPrijem>()
            //    .Property(e => e.Cena)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<KontejnerPrijem>()
            //    .Property(e => e.MB)
            //    .IsUnicode(false);
            #endregion

            //#region KORISNIK
            //modelBuilder.Entity<Korisnik>()
            //  .Property(e => e.KorisnickoIme)
            //  .IsUnicode(false);

            //modelBuilder.Entity<Korisnik>()
            //    .Property(e => e.Lozinka)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Korisnik>()
            //    .Property(e => e.Telefon)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Korisnik>()
            //    .Property(e => e.Email)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.Blokadas)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.CarinskaOtpremnicas)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.CarinskaOtpremnicas1)
            //    .WithRequired(e => e.Korisnik1)
            //    .HasForeignKey(e => e.Promenio)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.CarinskaOtpremnicaStavkes)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.CarinskaOtpremnicaStavkes1)
            //    .WithRequired(e => e.Korisnik1)
            //    .HasForeignKey(e => e.Promenio)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.CarinskaPrijemnicas)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.CarinskaPrijemnicas1)
            //    .WithRequired(e => e.Korisnik1)
            //    .HasForeignKey(e => e.Promenio)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.CarinskaPrijemnicas2)
            //    .WithRequired(e => e.Korisnik2)
            //    .HasForeignKey(e => e.Uskladistio)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.CarinskaPrijemnicaStavkes)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.CarinskaPrijemnicaStavkes1)
            //    .WithRequired(e => e.Korisnik1)
            //    .HasForeignKey(e => e.Promenio)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.InterniPrenos)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.InterniPrenos1)
            //    .WithRequired(e => e.Korisnik1)
            //    .HasForeignKey(e => e.Promenio)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.InterniPrenosStavkes)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.InterniPrenosStavkes1)
            //    .WithRequired(e => e.Korisnik1)
            //    .HasForeignKey(e => e.Promenio)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.Otpremnicas)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.Otpremnicas1)
            //    .WithRequired(e => e.Korisnik1)
            //    .HasForeignKey(e => e.Promenio)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.OtpremnicaStavkes)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.OtpremnicaStavkes1)
            //    .WithRequired(e => e.Korisnik1)
            //    .HasForeignKey(e => e.Promenio)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.PodesavanjeZalihaStavkes)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.Posaos)
            //    .WithOptional(e => e.Korisnik)
            //    .HasForeignKey(e => e.Radnik);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.Prijemnicas)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.Prijemnicas1)
            //    .WithRequired(e => e.Korisnik1)
            //    .HasForeignKey(e => e.Promenio)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.PrijemnicaStavkes)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.PrijemnicaStavkes1)
            //    .WithRequired(e => e.Korisnik1)
            //    .HasForeignKey(e => e.Promenio)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.RazdvajanjePrijemas)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.RazdvajanjePrijemas1)
            //    .WithRequired(e => e.Korisnik1)
            //    .HasForeignKey(e => e.Promenio)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.RazdvajanjePrijemaStavkes)
            //    .WithRequired(e => e.Korisnik)
            //    .HasForeignKey(e => e.Kreirao)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.RazdvajanjePrijemaStavkes1)
            //    .WithRequired(e => e.Korisnik1)
            //    .HasForeignKey(e => e.Promenio)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Korisnik>()
            //    .HasMany(e => e.Rolas)
            //    .WithMany(e => e.Korisniks)
            //    .Map(m => m.ToTable("KorisniciRole").MapLeftKey("IDKorisnik").MapRightKey("IDRola"));

            //#endregion
            ////////////////////////////////////////////////////////////////////////////////////////////////////
            //#region LOKACIJA
            //modelBuilder.Entity<Lokacija>()
            //    .Property(e => e.Sifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Lokacija>()
            //    .Property(e => e.Duzina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Lokacija>()
            //    .Property(e => e.Sirina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Lokacija>()
            //    .Property(e => e.Visina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Lokacija>()
            //    .Property(e => e.Identifikator)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Lokacija>()
            //    .Property(e => e.Zona)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Lokacija>()
            //    .Property(e => e.Sekvenca)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Lokacija>()
            //    .Property(e => e.ZapreminskiKapacitet)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Lokacija>()
            //    .Property(e => e.TezinskiKapacitet)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Lokacija>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Lokacija>()
            //    .Property(e => e.PaletniKapacitet)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Lokacija>()
            //    .Property(e => e.Prefiks)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Lokacija>()
            //    .HasMany(e => e.ArtikliLokacijes)
            //    .WithRequired(e => e.Lokacija1)
            //    .HasForeignKey(e => e.Lokacija)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Lokacija>()
            //    .HasMany(e => e.InterniPrenosStavkes)
            //    .WithRequired(e => e.Lokacija)
            //    .HasForeignKey(e => e.NaLokaciju)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Lokacija>()
            //    .HasMany(e => e.InterniPrenosStavkes1)
            //    .WithRequired(e => e.Lokacija1)
            //    .HasForeignKey(e => e.SaLokacije)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Lokacija>()
            //    .HasMany(e => e.Otpremnicas)
            //    .WithOptional(e => e.Lokacija)
            //    .HasForeignKey(e => e.LinijaEkspedicije);

            //modelBuilder.Entity<Lokacija>()
            //    .HasMany(e => e.PopisListas)
            //    .WithRequired(e => e.Lokacija1)
            //    .HasForeignKey(e => e.Lokacija)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Lokacija>()
            //    .HasMany(e => e.PrijemnicaStavkes)
            //    .WithOptional(e => e.Lokacija1)
            //    .HasForeignKey(e => e.Lokacija);
            //////////////////////////////////////////////////
            //#endregion

            //#region LOKACIJA KLIJENTA

            //modelBuilder.Entity<LokacijaKlijenta>()
            //    .Property(e => e.SifraVlasnika)
            //    .IsUnicode(false);

            //modelBuilder.Entity<LokacijaKlijenta>()
            //    .Property(e => e.SifraLokacije)
            //    .IsUnicode(false);

            //modelBuilder.Entity<LokacijaKlijenta>()
            //    .Property(e => e.NazivLokacije)
            //    .IsUnicode(false);

            //modelBuilder.Entity<LokacijaKlijenta>()
            //    .Property(e => e.EksternaSifraLokacije)
            //    .IsUnicode(false);

            //modelBuilder.Entity<LokacijaKlijenta>()
            //    .HasMany(e => e.Otpremnicas)
            //    .WithOptional(e => e.LokacijaKlijenta)
            //    .HasForeignKey(e => new { e.Vlasnik, e.EksternoSkladiste });

            //modelBuilder.Entity<LokacijaKlijenta>()
            //    .HasMany(e => e.Prijemnicas)
            //    .WithOptional(e => e.LokacijaKlijenta)
            //    .HasForeignKey(e => new { e.Vlasnik, e.EksternoSkladiste });

            //modelBuilder.Entity<LokacijaKlijenta>()
            //    .HasMany(e => e.Prijemnicas1)
            //    .WithOptional(e => e.LokacijaKlijenta1)
            //    .HasForeignKey(e => new { e.Vlasnik, e.EksternoSkladiste });

            //modelBuilder.Entity<LokacijaKlijenta>()
            //    .HasMany(e => e.PrijemnicaStavkes)
            //    .WithOptional(e => e.LokacijaKlijenta)
            //    .HasForeignKey(e => new { e.ArtikalVlasnik, e.EksternoSkladiste });

            //modelBuilder.Entity<LokacijaKlijenta>()
            //    .HasMany(e => e.Zalihas)
            //    .WithOptional(e => e.LokacijaKlijenta)
            //    .HasForeignKey(e => new { e.ArtikalVlasnik, e.EksternoSkladiste });
            //#endregion
            /////////////////////////////////////////////
            //#region LPN
            //modelBuilder.Entity<LPN>()
            //    .Property(e => e.Prefiks)
            //    .IsUnicode(false);
            //#endregion

            ///////////////////////////////////
            //#region MESTO
            //modelBuilder.Entity<Mesto>()
            //    .Property(e => e.PostanskiBroj)
            //    .IsUnicode(false);
            //#endregion
            /////////////////////////////////////
            //#region NABAVNI NALOG
            //modelBuilder.Entity<NabavniNalog>()
            //    .Property(e => e.EksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalog>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalog>()
            //    .Property(e => e.ProcessingTypeCode)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalog>()
            //    .Property(e => e.SellerPartyID)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalog>()
            //    .Property(e => e.ResponsiblePurchasingGroupPartyID)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalog>()
            //    .Property(e => e.EksternaSifra2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalog>()
            //    .HasMany(e => e.NabavniNalogStavkes)
            //    .WithRequired(e => e.NabavniNalog1)
            //    .HasForeignKey(e => e.NabavniNalog)
            //    .WillCascadeOnDelete(false);

            //#endregion
            //////////////////////////////////////////////////
            //#region NABAVNI NALOG STAVKE
            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.EksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.EksternaSifraStavke)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.SifraDobavljaca)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.NazivDobavljaca)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.ArtikalVlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.Kolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.TolerancijaVisak)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.TolerancijaManjak)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.JM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.Pogon)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.EksternoSkladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.PostavljanjeKategorijeTroska)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.MestoTroska)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.EksterniNalog)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.SerijskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.EksterniKorisnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.Primalac)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.EksternaSifra2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NabavniNalogStavke>()
            //    .Property(e => e.EksternaSifraStavke2)
            //    .IsUnicode(false);

            //#endregion

            /////////////////////////////////////////////////////////////////
            #region NALOG ZA PAKOVANJE
            //modelBuilder.Entity<NalogZaPakovanje>()
            //    .Property(e => e.Broj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NalogZaPakovanje>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NalogZaPakovanje>()
            //    .Property(e => e.ArtikalVlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NalogZaPakovanje>()
            //    .Property(e => e.JM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NalogZaPakovanje>()
            //    .Property(e => e.UkupnaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<NalogZaPakovanje>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NalogZaPakovanje>()
            //    .Property(e => e.EksterniKorisnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NalogZaPakovanje>()
            //    .Property(e => e.NNEksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<NalogZaPakovanje>()
            //    .Property(e => e.NNEksternaSifraStavke)
            //    .IsUnicode(false);

            //#endregion
            ////////////////////////////////////////////////////////////
            //#region OBLAST
            //modelBuilder.Entity<Oblast>()
            //    .Property(e => e.Sifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Oblast>()
            //    .HasMany(e => e.Zonas)
            //    .WithOptional(e => e.Oblast1)
            //    .HasForeignKey(e => e.Oblast);
            //#endregion
            /////////////////////////////////////////////////////////////////
            //#region OBRACUN
            //modelBuilder.Entity<Obracun>()
            //    .Property(e => e.SifraVlasnika)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Obracun>()
            //    .Property(e => e.SifraArtikla)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Obracun>()
            //    .Property(e => e.LPN)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Obracun>()
            //    .Property(e => e.Izvor)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Obracun>()
            //    .Property(e => e.Iznos)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Obracun>()
            //    .Property(e => e.Cena)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Obracun>()
            //    .Property(e => e.Kolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Obracun>()
            //    .Property(e => e.Osnova)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Obracun>()
            //    .Property(e => e.GenerisanIznos)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Obracun>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Obracun>()
            //    .Property(e => e.PodrazumevanaJM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Obracun>()
            //    .Property(e => e.KolicinaPodrazumevanaJM)
            //    .HasPrecision(18, 4);
            //#endregion
            ////////////////////////////////////////////////////////////////////
            //#region OBRACUN CARINSKI
            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.SifraVlasnika)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.MB)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.TipTroska)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.OsnovaTroska)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.JM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.Cena)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.KolicinaPrijem)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.KolicinaTrenutno)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.PaletaPrijem)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.PaletaTrenutno)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.KontejnerTip)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.KontejnerKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.KontejnerCena)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.BrutoTezina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<ObracunCarinski>()
            //    .Property(e => e.Zapremina)
            //    .HasPrecision(18, 4);
            //#endregion
            ////////////////////////////////////////////////////////////
            //#region OBRACUN KOMERCIJALNI
            //modelBuilder.Entity<ObracunKomercijalni>()
            //    .Property(e => e.SifraVlasnika)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunKomercijalni>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunKomercijalni>()
            //    .Property(e => e.Cena)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<ObracunKomercijalni>()
            //    .Property(e => e.TipTroska)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunKomercijalni>()
            //    .Property(e => e.OsnovaTroska)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunKomercijalni>()
            //    .Property(e => e.Lokacija)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunKomercijalni>()
            //    .Property(e => e.PaletnaMesta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<ObracunKomercijalni>()
            //    .Property(e => e.Tezina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<ObracunKomercijalni>()
            //    .Property(e => e.MB)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunKomercijalni>()
            //    .Property(e => e.PaletaTrenutno)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<ObracunKomercijalni>()
            //    .Property(e => e.TrenutniMB)
            //    .IsUnicode(false);

            //modelBuilder.Entity<ObracunKomercijalni>()
            //    .Property(e => e.Valuta)
            //    .IsUnicode(false);
            //#endregion
            /////////////////////////////////////////////////////
            //#region ODABIR
            //modelBuilder.Entity<Odabir>()
            //    .Property(e => e.Lokacija)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Odabir>()
            //    .Property(e => e.LPN)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Odabir>()
            //    .Property(e => e.ArtikalVlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Odabir>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Odabir>()
            //    .Property(e => e.Kolicina)
            //    .HasPrecision(18, 4);

            modelBuilder.Entity<Odabir>()
                .Property(e => e.RowVersion)
                .HasMaxLength(8).HasColumnName("timestamp");

            //modelBuilder.Entity<Odabir>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Odabir>()
            //    .Property(e => e.IzlazniLPN)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Odabir>()
            //    .Property(e => e.BrojKoleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Odabir>()
            //    .Property(e => e.KolicinaPovrata)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Odabir>()
            //    .Property(e => e.KoletaPovrat)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Odabir>()
            //    .Property(e => e.UtovarenaKolicina)
            //    .HasPrecision(18, 4);


            //modelBuilder.Entity<Odabir>()
            //    .Property(e => e.OdabranaKolicina)
            //    .HasPrecision(18, 4);
            //#endregion

            ////////////////////////////////////////////////////////////////////////////////////
            #region OTPREMNICA
            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.Broj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.EksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.Vlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.MagacinskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.Kupac)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.PostanskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.Telefon)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            modelBuilder.Entity<Otpremnica>()
                .Property(e => e.RowVersion)
                .HasMaxLength(8).HasColumnName("timestamp");

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.PrefiksLPN)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.EksternaLokacija)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.EksternaSifra2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.BrojPaketa)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.Tezina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.Zapremina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.BrojPaleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.EksternoSkladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.EksternoSkladistePrijema)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.EksterniKorisnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.StatusKnjizenja)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.Email)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.KreatorEmail)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.BrojDokumenta)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.Prodavac)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.EkstSifraNabNaloga)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.EksterniSistem)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.LinijaEkspedicije)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .Property(e => e.IzlazniLPN)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .HasMany(e => e.Odabirs)
            //    .WithRequired(e => e.Otpremnica1)
            //    .HasForeignKey(e => e.Otpremnica)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .HasMany(e => e.OtpremnicaStatusLogs)
            //    .WithRequired(e => e.Otpremnica1)
            //    .HasForeignKey(e => e.Otpremnica)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Otpremnica>()
            //    .HasMany(e => e.OtpremnicaStavkes)
            //    .WithRequired(e => e.Otpremnica1)
            //    .HasForeignKey(e => e.Otpremnica)
            //    .WillCascadeOnDelete(false);
            #endregion

            /////////////////////////////////////////////////////////////////////
            #region OTPREMNICA KONTROLA
            //modelBuilder.Entity<OtpremnicaKontrola>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaKontrola>()
            //    .Property(e => e.ArtikalVlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaKontrola>()
            //    .Property(e => e.Kolicina)
            //    .HasPrecision(18, 4);
            //#endregion
            /////////////////////////////////////////////////////////////////////////////////
            //#region OTPREMNICA STAVKE
            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.EksternaSifraStavke)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.ArtikalVlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.JM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.Kolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.RezervisanaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.OdabranaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.IsporucenaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.SerijskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.MagacinskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.SerijaOd)
            //    .HasPrecision(25, 0);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.SerijaDo)
            //    .HasPrecision(25, 0);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.EksternaSifraStavke2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.EksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.EksternaSifra2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.Pomocno1)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.Pomocno2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.Pomocno3)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.Pomocno4)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.Serija)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.BrojKoleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.Cena)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.BrojFakture)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.KolicinaPovrata)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.KoletaPovrat)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.LpnRezervacije)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.LokacijaRezervacije)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.EksternoSkladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.Tezina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.Zapremina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<OtpremnicaStavke>()
            //    .Property(e => e.UtovarenaKolicina)
            //    .HasPrecision(18, 4);
            //#endregion
            ////////////////////////////////////////////////////////////////////////////
            //#region PAKOVANJE
            //modelBuilder.Entity<Pakovanje>()
            //    .Property(e => e.Sifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Pakovanje>()
            //    .Property(e => e.OsnovnaJM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Pakovanje>()
            //    .Property(e => e.JMNivo1)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Pakovanje>()
            //    .Property(e => e.Odnos1)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Pakovanje>()
            //    .Property(e => e.JMNivo2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Pakovanje>()
            //    .Property(e => e.Odnos2)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Pakovanje>()
            //    .Property(e => e.JMNivo3)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Pakovanje>()
            //    .Property(e => e.Odnos3)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Pakovanje>()
            //    .Property(e => e.JMNivo4)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Pakovanje>()
            //    .Property(e => e.Odnos4)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Pakovanje>()
            //    .Property(e => e.Kutija)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Pakovanje>()
            //    .Property(e => e.Paleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Pakovanje>()
            //    .HasMany(e => e.Artikals)
            //    .WithRequired(e => e.Pakovanje1)
            //    .HasForeignKey(e => e.Pakovanje)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Pakovanje>()
            //    .HasMany(e => e.Barcodes)
            //    .WithRequired(e => e.Pakovanje1)
            //    .HasForeignKey(e => e.Pakovanje)
            //    .WillCascadeOnDelete(false);
            //#endregion
            /////////////////////////////////////////////////////////////////
            //#region PARAMETRIZACIJA
            //modelBuilder.Entity<Parametrizacija>()
            //    .Property(e => e.PrefiksMB)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Parametrizacija>()
            //    .Property(e => e.PodrazumevaniVlasnik)
            //    .IsUnicode(false);
            //#endregion
            ///////////////////////////////////////////////////////////////////////
            //#region PODESAVANJE ZALIHA
            //modelBuilder.Entity<PodesavanjeZaliha>()
            //    .Property(e => e.Kontakt)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PodesavanjeZaliha>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PodesavanjeZaliha>()
            //    .HasMany(e => e.PodesavanjeZalihaStavkes)
            //    .WithRequired(e => e.PodesavanjeZaliha1)
            //    .HasForeignKey(e => e.PodesavanjeZaliha)
            //    .WillCascadeOnDelete(false);
            //#endregion
            ///////////////////////////////////////////////////////////////////////////////
            //#region PODESAVANJE ZALIHA STAVKE
            //modelBuilder.Entity<PodesavanjeZalihaStavke>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PodesavanjeZalihaStavke>()
            //    .Property(e => e.ArtikalVlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PodesavanjeZalihaStavke>()
            //    .Property(e => e.Lokacija)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PodesavanjeZalihaStavke>()
            //    .Property(e => e.LPN)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PodesavanjeZalihaStavke>()
            //    .Property(e => e.TrenutnaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PodesavanjeZalihaStavke>()
            //    .Property(e => e.KolicinaPodesavanja)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PodesavanjeZalihaStavke>()
            //    .Property(e => e.CiljnaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PodesavanjeZalihaStavke>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);
            //#endregion
            /////////////////////////////////////////////////////////////////////
            //#region POPIS
            //modelBuilder.Entity<Popi>()
            //    .Property(e => e.Broj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Popi>()
            //    .Property(e => e.Vlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Popi>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Popi>()
            //    .HasMany(e => e.PopisListas)
            //    .WithRequired(e => e.Popi)
            //    .HasForeignKey(e => e.Popis)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Popi>()
            //    .HasMany(e => e.PopisStavkes)
            //    .WithOptional(e => e.Popi)
            //    .HasForeignKey(e => e.Popis);
            //#endregion
            ////////////////////////////////////////////////////////////////
            //#region POPIS LISTA
            //modelBuilder.Entity<PopisLista>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PopisLista>()
            //    .Property(e => e.ArtikalVlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PopisLista>()
            //    .Property(e => e.Lokacija)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PopisLista>()
            //    .Property(e => e.LPN)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PopisLista>()
            //    .Property(e => e.EksternoSkladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PopisLista>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);
            //#endregion
            ////////////////////////////////////////////////////////////////////
            //#region POPIS STAVKE
            //modelBuilder.Entity<PopisStavke>()
            //    .Property(e => e.ArtikalVlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PopisStavke>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PopisStavke>()
            //    .Property(e => e.Lokacija)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PopisStavke>()
            //    .Property(e => e.LPN)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PopisStavke>()
            //    .Property(e => e.EksternoSkladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PopisStavke>()
            //    .Property(e => e.Kolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PopisStavke>()
            //    .Property(e => e.SistemskaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PopisStavke>()
            //    .Property(e => e.KolicinaPodesavanja)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PopisStavke>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);
            //#endregion
            ////////////////////////////////////////////////////////////////////
            //#region PORUKA KNJIZENJA
            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.NabavniNalog)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.NabavniNalogStavke)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.ProizvodniNalog)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.EksterniPrenos)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.EksterniPrenosStavke)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.BrojIsporuke)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.BrojIsporukeStavke)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.StornoDokumenta)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.StornoDokumentaStavke)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.TipPoruke)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.BrojPoruke)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.StornoDokumentaGodina)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.BrojDokumenta)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.StavkaDokumenta)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.GodinaDokumenta)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.KlasaPoruke)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.MatDocOldId)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.MatDocNewId)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.EksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PorukaKnjizenja>()
            //    .Property(e => e.Izvor)
            //    .IsUnicode(false);
            //#endregion
            //////////////////////////////////////////////////////////////////////////
            //#region POSAO
            //modelBuilder.Entity<Posao>()
            //    .Property(e => e.ArtikalVlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Posao>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Posao>()
            //    .Property(e => e.JM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Posao>()
            //    .Property(e => e.Kolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Posao>()
            //    .Property(e => e.SaLokacije)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Posao>()
            //    .Property(e => e.SaPJ)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Posao>()
            //    .Property(e => e.NaLokaciju)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Posao>()
            //    .Property(e => e.NaPJ)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Posao>()
            //    .Property(e => e.Izvor)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Posao>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);
            //#endregion
            /////////////////////////////////////////////////////////////////
            //#region PRAVO
            //modelBuilder.Entity<Pravo>()
            //    .Property(e => e.Naziv)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Pravo>()
            //    .Property(e => e.Opis)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Pravo>()
            //    .HasMany(e => e.Rolas)
            //    .WithMany(e => e.Pravoes)
            //    .Map(m => m.ToTable("RolePrava").MapLeftKey("IDPravo").MapRightKey("IDRola"));
            //#endregion
            //////////////////////////////////////////////////////////////////////
            //#region PRIJEMNICA
            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.Broj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.Vlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.MagacinskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.EksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            modelBuilder.Entity<Prijemnica>()
                .Property(e => e.RowVersion)
                .HasMaxLength(8).HasColumnName("timestamp");

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.UkupnoPaleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.Kupac)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.PostanskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.Telefon)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.EksternaSifra2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.EksternoSkladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.EksternaLokacija)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.UkupnaTezina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.EksterniKorisnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.Email)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.KreatorEmail)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.UkupnoKoleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.BrojFakture)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.McKomada)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.UkupnaVrednost)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.BrojDeklaracije)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.Tezina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.Zapremina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.BrojOtpremnice)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.CarinskaIspostava)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.EksterniSistem)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .Property(e => e.Valuta)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prijemnica>()
            //    .HasMany(e => e.PrijemnicaStavkes)
            //    .WithRequired(e => e.Prijemnica1)
            //    .HasForeignKey(e => e.Prijemnica)
            //    .WillCascadeOnDelete(false);
            //#endregion
            ////////////////////////////////////////////////////////////////////
            //#region PRIJEMNICA STAVKE
            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.EksternaSifraStavke)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.ArtikalVlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.JM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.OcekivanaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.PrimljenaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.Lokacija)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.LPN)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.SerijskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.MagacinskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.SerijaOd)
            //    .HasPrecision(25, 0);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.SerijaDo)
            //    .HasPrecision(25, 0);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.EksternaSifraStavke2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.EksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.EksternaSifra2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.EksternoSkladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.Serija)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.BrojKoleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.BrojFakture)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.BrojDeklaracije)
            //    .IsUnicode(false);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.Cena)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.CenaTarifa)
            //    .HasPrecision(38, 20);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.Tezina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.Zapremina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<PrijemnicaStavke>()
            //    .Property(e => e.ZemljaPorekla)
            //    .IsUnicode(false);
            //#endregion
            //////////////////////////////////////////////////////////////////
            //#region PRILOG
            //modelBuilder.Entity<Prilog>()
            //    .Property(e => e.Klijent)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prilog>()
            //    .Property(e => e.Broj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Prilog>()
            //    .HasOptional(e => e.Prilog1)
            //    .WithRequired(e => e.Prilog2);

            //#endregion


            ////////////////////////////////////////////////////////////////////////////////
            //#region RAZDVAJANJE PRIJEMA
            //modelBuilder.Entity<RazdvajanjePrijema>()
            //    .Property(e => e.MagacinskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<RazdvajanjePrijema>()
            //    .Property(e => e.Vlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<RazdvajanjePrijema>()
            //    .Property(e => e.UkupnoKoleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<RazdvajanjePrijema>()
            //    .Property(e => e.UkupnaTezina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<RazdvajanjePrijema>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<RazdvajanjePrijema>()
            //    .Property(e => e.BorderoBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<RazdvajanjePrijema>()
            //    .Property(e => e.BrojDokumenta)
            //    .IsUnicode(false);

            //modelBuilder.Entity<RazdvajanjePrijema>()
            //    .HasMany(e => e.RazdvajanjePrijemaStavkes)
            //    .WithRequired(e => e.RazdvajanjePrijema1)
            //    .HasForeignKey(e => e.RazdvajanjePrijema)
            //    .WillCascadeOnDelete(false);
            #endregion
            ////////////////////////////////////////////////////////////////////////
            #region RAZDVAJANJE PRIJEMA STAVKE
            //modelBuilder.Entity<RazdvajanjePrijemaStavke>()
            //    .Property(e => e.Koleta)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<RazdvajanjePrijemaStavke>()
            //    .Property(e => e.Tezina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<RazdvajanjePrijemaStavke>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<RazdvajanjePrijemaStavke>()
            //    .Property(e => e.LPN)
            //    .IsUnicode(false);
            //#endregion
            /////////////////////////////////////////////////////////////////////////////////
            //#region ROLA
            //modelBuilder.Entity<Rola>()
            //    .Property(e => e.Naziv)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Rola>()
            //    .Property(e => e.Opis)
            //    .IsUnicode(false);
            //#endregion
            ///////////////////////////////////////////////////////////////////////////////
            //#region SARZA
            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.ArtikalVlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.SerijskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.MagacinskiBroj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.Kolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.RezervisanaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.IzabranaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.BlokiranaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            modelBuilder.Entity<Sarza>()
                .Property(e => e.RowVersion)
                .HasMaxLength(8).HasColumnName("timestamp");

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.SerijaOd)
            //    .HasPrecision(25, 0);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.SerijaDo)
            //    .HasPrecision(25, 0);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.Serija)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.BrojFakture)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.BrojDeklaracije)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.CenaTarifa)
            //    .HasPrecision(38, 20);

            //modelBuilder.Entity<Sarza>()
            //    .Property(e => e.TarifaJM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sarza>()
            //    .HasMany(e => e.InterniPrenosStavkes)
            //    .WithRequired(e => e.Sarza)
            //    .HasForeignKey(e => e.SaSarze)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sarza>()
            //    .HasMany(e => e.Posaos)
            //    .WithOptional(e => e.Sarza1)
            //    .HasForeignKey(e => e.Sarza);

            //modelBuilder.Entity<Sarza>()
            //    .HasMany(e => e.PrijemnicaStavkes)
            //    .WithOptional(e => e.Sarza1)
            //    .HasForeignKey(e => e.Sarza);
            //#endregion
            ///////////////////////////////////////////////////////////////////////
            //#region SASTAVNICA
            //modelBuilder.Entity<Sastavnica>()
            //    .Property(e => e.Broj)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sastavnica>()
            //    .Property(e => e.Vlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sastavnica>()
            //    .Property(e => e.JM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sastavnica>()
            //    .Property(e => e.UkupnaKolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<Sastavnica>()
            //    .Property(e => e.ArtikalZaglavlja)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sastavnica>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sastavnica>()
            //    .Property(e => e.EksternaSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<Sastavnica>()
            //    .Property(e => e.OcekivanaKolicina)
            //    .HasPrecision(18, 4);
            //#endregion
            /////////////////////////////////////////////////////////////////////////////
            //#region SASTAVNICA STAVKE
            //modelBuilder.Entity<SastavnicaStavke>()
            //    .Property(e => e.ArtikalSifra)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SastavnicaStavke>()
            //    .Property(e => e.ArtikalVlasnik)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SastavnicaStavke>()
            //    .Property(e => e.JM)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SastavnicaStavke>()
            //    .Property(e => e.Kolicina)
            //    .HasPrecision(18, 4);

            //modelBuilder.Entity<SastavnicaStavke>()
            //    .Property(e => e.Skladiste)
            //    .IsUnicode(false);
            //#endregion
            ////////////////////////////////////////////////////////////////////////////
            //#region SERIJSKI BROJ
            //modelBuilder.Entity<SerijskiBroj>()
            //    .Property(e => e.SerijskiBrojKartice)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SerijskiBroj>()
            //    .Property(e => e.BrojTelefona)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SerijskiBroj>()
            //    .Property(e => e.LPN)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SerijskiBroj>()
            //    .Property(e => e.SifraArtikla)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SerijskiBroj>()
            //    .Property(e => e.Paket)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SerijskiBroj>()
            //    .Property(e => e.OdabranPaket)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SerijskiBroj>()
            //    .Property(e => e.GenerisanLPN)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SerijskiBroj>()
            //    .Property(e => e.SerijskiBrojKartice2)
            //    .IsUnicode(false);

            //modelBuilder.Entity<SerijskiBroj>()
            //    .Property(e => e.BrojTelefona2)
            //    .IsUnicode(false);
            #endregion
            //////////////////////////////////////////////////////////////////////
            #region SIFARNIK
            modelBuilder.Configurations.Add(new SifarnikMap());
            modelBuilder.Entity<Sifarnik>()
                .Property(e => e.Sifra)
                .IsUnicode(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.Blokada)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.Razlog)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.CarinskaOtpremnica)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.TipPrevoza)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.CarinskaOtpremnicaStavke)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.TipDokumenta)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.CarinskaPrijemnica)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.TipPrevoza)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.CarinskaPrijemnicaStavke)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.TipDokumenta)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.IzlazniID)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.TipAmbalaze)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.Kontakt)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.Tip)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.Lokacija)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.TipLokacije)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.Odabir)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.Status)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.Otpremnica)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.Tip)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.OtpremnicaStavke)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.Status)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.PodesavanjeZalihaStavke)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.Razlog)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.Posao)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.StatusPosla)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.Posao1)
            //    .WithRequired(e => e.Sifarnik1)
            //    .HasForeignKey(e => e.TipPosla)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.Prijemnica)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.TipPrijema)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.Prijemnica1)
            //    .WithRequired(e => e.Sifarnik1)
            //    .HasForeignKey(e => e.Status)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.PrijemnicaStavke)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.Status)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.Usluga)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.VrstaUsluge)
            //    .WillCascadeOnDelete(false);

            //modelBuilder.Entity<Sifarnik>()
            //    .HasMany(e => e.Zaliha)
            //    .WithRequired(e => e.Sifarnik)
            //    .HasForeignKey(e => e.StatusZalihe)
            //    .WillCascadeOnDelete(false);
            #endregion
            //////////////////////////////////////////////////////////////////////
            #region SIFARNIK ENTITETA
            modelBuilder.Configurations.Add(new SifarnikEntitetaMap());
            modelBuilder.Entity<SifarnikEntiteta>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<SifarnikEntiteta>()
                .HasMany(e => e.Brojacs)
                .WithRequired(e => e.SifarnikEntiteta)
                .HasForeignKey(e => e.Entitet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SifarnikEntiteta>()
                .HasMany(e => e.SifarnikEntitetaTips)
                .WithRequired(e => e.SifarnikEntiteta1)
                .HasForeignKey(e => e.SifarnikEntiteta)
                .WillCascadeOnDelete(false);
            #endregion
            /////////////////////////////////////////////////////////////////////////
            #region SIFARNIK ENTITETA TIP
            modelBuilder.Configurations.Add(new SifarnikEntitetaTipMap());
            modelBuilder.Entity<SifarnikEntitetaTip>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<SifarnikEntitetaTip>()
                .HasMany(e => e.Sifarniks)
                .WithRequired(e => e.SifarnikEntitetaTip1)
                .HasForeignKey(e => e.SifarnikEntitetaTip)
                .WillCascadeOnDelete(false);
            #endregion

            //////////////////////////////////////////////////////////////////////////////
            //            #region SKLADISTE
            //            modelBuilder.Entity<Skladiste>()
            //                .Property(e => e.Sifra)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Skladiste>()
            //                .HasMany(e => e.CarinskaOtpremnicas)
            //                .WithRequired(e => e.Skladiste1)
            //                .HasForeignKey(e => e.Skladiste)
            //                .WillCascadeOnDelete(false);

            //            modelBuilder.Entity<Skladiste>()
            //                .HasMany(e => e.CarinskaOtpremnicaStavkes)
            //                .WithRequired(e => e.Skladiste1)
            //                .HasForeignKey(e => e.Skladiste)
            //                .WillCascadeOnDelete(false);

            //            modelBuilder.Entity<Skladiste>()
            //                .HasMany(e => e.CarinskaPrijemnicas)
            //                .WithRequired(e => e.Skladiste1)
            //                .HasForeignKey(e => e.Skladiste)
            //                .WillCascadeOnDelete(false);

            //            modelBuilder.Entity<Skladiste>()
            //                .HasMany(e => e.CarinskaPrijemnicaStavkes)
            //                .WithRequired(e => e.Skladiste1)
            //                .HasForeignKey(e => e.Skladiste)
            //                .WillCascadeOnDelete(false);

            //            modelBuilder.Entity<Skladiste>()
            //                .HasMany(e => e.InterniPrenos)
            //                .WithRequired(e => e.Skladiste1)
            //                .HasForeignKey(e => e.Skladiste)
            //                .WillCascadeOnDelete(false);

            //            modelBuilder.Entity<Skladiste>()
            //                .HasMany(e => e.InterniPrenosStavkes)
            //                .WithRequired(e => e.Skladiste1)
            //                .HasForeignKey(e => e.Skladiste)
            //                .WillCascadeOnDelete(false);

            //            modelBuilder.Entity<Skladiste>()
            //                .HasMany(e => e.Otpremnicas)
            //                .WithRequired(e => e.Skladiste1)
            //                .HasForeignKey(e => e.Skladiste)
            //                .WillCascadeOnDelete(false);

            //            modelBuilder.Entity<Skladiste>()
            //                .HasMany(e => e.OtpremnicaStavkes)
            //                .WithRequired(e => e.Skladiste1)
            //                .HasForeignKey(e => e.Skladiste)
            //                .WillCascadeOnDelete(false);

            //            modelBuilder.Entity<Skladiste>()
            //                .HasMany(e => e.PodesavanjeZalihas)
            //                .WithRequired(e => e.Skladiste1)
            //                .HasForeignKey(e => e.Skladiste)
            //                .WillCascadeOnDelete(false);

            //            modelBuilder.Entity<Skladiste>()
            //                .HasMany(e => e.PodesavanjeZalihaStavkes)
            //                .WithRequired(e => e.Skladiste1)
            //                .HasForeignKey(e => e.Skladiste)
            //                .WillCascadeOnDelete(false);

            //            modelBuilder.Entity<Skladiste>()
            //                .HasMany(e => e.Prijemnicas)
            //                .WithRequired(e => e.Skladiste1)
            //                .HasForeignKey(e => e.Skladiste)
            //                .WillCascadeOnDelete(false);

            //            modelBuilder.Entity<Skladiste>()
            //                .HasMany(e => e.PrijemnicaStavkes)
            //                .WithRequired(e => e.Skladiste1)
            //                .HasForeignKey(e => e.Skladiste)
            //                .WillCascadeOnDelete(false);
            //            #endregion
            //            ///////////////////////////////////////////////////////////////////////////////////
            //            #region SPECIFIKACIJA OTPREME
            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.Broj)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.EksternaSifra)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.EksternaSifra2)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.ArtikalSifra)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.Isporuceno)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.Povrat)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.BrojKoleta)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.NabavnaCena)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.ProdajnaCena)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.Kupac)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.Prodavac)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.JedNetoTezina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.Tarifa)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<SpecifikacijaOtpreme>()
            //                .Property(e => e.JedBrutoTezina)
            //                .HasPrecision(18, 4);
            //            #endregion
            //            ///////////////////////////////////////////////////////////////////
            //            #region SPEC ZA CARINJENJE
            //            modelBuilder.Entity<SpecZaCarinjenje>()
            //                .Property(e => e.Broj)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<SpecZaCarinjenje>()
            //                .HasMany(e => e.SpecZaCarinjenjeStavkes)
            //                .WithRequired(e => e.SpecZaCarinjenje1)
            //                .HasForeignKey(e => e.SpecZaCarinjenje)
            //                .WillCascadeOnDelete(false);
            //            #endregion
            //            ////////////////////////////////////////////////////////////////////////
            //            #region SPEC ZA CARINJENJE STAVKE
            //            modelBuilder.Entity<SpecZaCarinjenjeStavke>()
            //                .Property(e => e.Faktura)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<SpecZaCarinjenjeStavke>()
            //                .Property(e => e.SifraArtikla)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<SpecZaCarinjenjeStavke>()
            //                .Property(e => e.Kolicina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<SpecZaCarinjenjeStavke>()
            //                .Property(e => e.JedinicnaCena)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<SpecZaCarinjenjeStavke>()
            //                .Property(e => e.Ukupno)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<SpecZaCarinjenjeStavke>()
            //                .Property(e => e.TarifniBroj)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<SpecZaCarinjenjeStavke>()
            //                .Property(e => e.Neto)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<SpecZaCarinjenjeStavke>()
            //                .Property(e => e.JM)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<SpecZaCarinjenjeStavke>()
            //                .Property(e => e.Stopa)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<SpecZaCarinjenjeStavke>()
            //                .Property(e => e.BrutoMasa)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<SpecZaCarinjenjeStavke>()
            //                .Property(e => e.Carinarnica)
            //                .IsUnicode(false);
            //            #endregion
            //            ////////////////////////////////////////////////////////////////////////
            //            #region STANJE ZALIHA
            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.Lokacija)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.LPN)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.ArtikalVlasnik)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.ArtikalSifra)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.Kolicina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.SerijskiBroj)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.SerijaOd)
            //                .HasPrecision(25, 0);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.SerijaDo)
            //                .HasPrecision(25, 0);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.MagacinskiBroj)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.Skladiste)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.PaletniKapacitet)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.EksternoSkladiste)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.BrojFakture)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.BrojDeklaracije)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.BrutoTezinaArtikla)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.NetoTezinaArtikla)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StanjeZaliha>()
            //                .Property(e => e.Serija)
            //                .IsUnicode(false);
            //            #endregion
            //            ////////////////////////////////////////////////////////////////////////////////////
            //            #region STANJE ZALIHA ARHIVA
            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.Lokacija)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.LPN)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.ArtikalVlasnik)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.ArtikalSifra)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.Kolicina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.SerijskiBroj)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.SerijaOd)
            //                .HasPrecision(25, 0);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.SerijaDo)
            //                .HasPrecision(25, 0);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.MagacinskiBroj)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.Skladiste)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.PaletniKapacitet)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.EksternoSkladiste)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.BrojFakture)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.BrojDeklaracije)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.BrutoTezinaArtikla)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StanjeZalihaArhiva>()
            //                .Property(e => e.NetoTezinaArtikla)
            //                .HasPrecision(18, 4);
            //            #endregion
            //            ///////////////////////////////////////////////////////////////////////////
            //            #region STORAGE REPORT ZENITH
            //            modelBuilder.Entity<StorageReportZenith>()
            //                .Property(e => e.ArtikalSifra)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StorageReportZenith>()
            //                .Property(e => e.ArtikalVlasnik)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StorageReportZenith>()
            //                .Property(e => e.Kolicina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StorageReportZenith>()
            //                .Property(e => e.KolicinaUlaz)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StorageReportZenith>()
            //                .Property(e => e.KolicinaIzlaz)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StorageReportZenith>()
            //                .Property(e => e.CenaPoDanuZapremina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StorageReportZenith>()
            //                .Property(e => e.ZapreminaUlaz)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StorageReportZenith>()
            //                .Property(e => e.ZapreminaIzlaz)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StorageReportZenith>()
            //                .Property(e => e.CenaManipulacije)
            //                .HasPrecision(18, 4);
            //            #endregion
            //            /////////////////////////////////////////////////////////////////////////////////
            //            #region STORNO DOKUMENTA
            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.BrojDokumenta)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.StavkaDokumenta)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.VrstaKretanja)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.ArtikalSifra)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.ArtikalVlasnik)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.Kolicina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.JM)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.Postrojenje)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.EksternoSkladiste)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.Serija)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.PostrojenjePrijema)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.EksternoSkladistePrijema)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.SerijaPrijem)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.TekstStavke)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<StornoDokumenta>()
            //                .Property(e => e.Entitet)
            //                .IsUnicode(false);
            //            #endregion
            //            ///////////////////////////////////////////////////////////////////////
            //            #region TARIFA
            //            modelBuilder.Entity<Tarifa>()
            //                .Property(e => e.TipPerioda)
            //                .IsFixedLength()
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Tarifa>()
            //                .Property(e => e.ProcenatPrePreseka)
            //                .HasPrecision(12, 6);

            //            modelBuilder.Entity<Tarifa>()
            //                .Property(e => e.ProcenatPoslePreseka)
            //                .HasPrecision(12, 6);

            //            modelBuilder.Entity<Tarifa>()
            //                .Property(e => e.Valuta)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Tarifa>()
            //                .Property(e => e.Skladiste)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Tarifa>()
            //                .HasMany(e => e.Artikals)
            //                .WithOptional(e => e.Tarifa1)
            //                .HasForeignKey(e => e.Tarifa);

            //            modelBuilder.Entity<Tarifa>()
            //                .HasMany(e => e.TarifaStavkes)
            //                .WithRequired(e => e.Tarifa1)
            //                .HasForeignKey(e => e.Tarifa)
            //                .WillCascadeOnDelete(false);
            //            #endregion
            //            ////////////////////////////////////////////////////////////////
            //            #region TARIFA STAVKE
            //            modelBuilder.Entity<TarifaStavke>()
            //                .Property(e => e.TipTroska)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<TarifaStavke>()
            //                .Property(e => e.OsnovaTroska)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<TarifaStavke>()
            //                .Property(e => e.Cena)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<TarifaStavke>()
            //                .Property(e => e.KolicinaOd)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<TarifaStavke>()
            //                .Property(e => e.KolicinaDo)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<TarifaStavke>()
            //                .Property(e => e.Kontejner)
            //                .IsUnicode(false);
            //            #endregion
            //            //////////////////////////////////////////////////////////////
            //            #region TRANSAKCIJA ZALIHA
            //            modelBuilder.Entity<TransakcijaZaliha>()
            //                .Property(e => e.TipTransakcije)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<TransakcijaZaliha>()
            //                .Property(e => e.ArtikalVlasnik)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<TransakcijaZaliha>()
            //                .Property(e => e.ArtikalSifra)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<TransakcijaZaliha>()
            //                .Property(e => e.SaLokacije)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<TransakcijaZaliha>()
            //                .Property(e => e.SaPJ)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<TransakcijaZaliha>()
            //                .Property(e => e.NaLokaciju)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<TransakcijaZaliha>()
            //                .Property(e => e.NaPJ)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<TransakcijaZaliha>()
            //                .Property(e => e.Izvor)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<TransakcijaZaliha>()
            //                .Property(e => e.Status)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<TransakcijaZaliha>()
            //                .Property(e => e.Kolicina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<TransakcijaZaliha>()
            //                .Property(e => e.Skladiste)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<TransakcijaZaliha>()
            //                .Property(e => e.MB)
            //                .IsUnicode(false);
            //            #endregion
            //            /////////////////////////////////////////////////////////////////////
            //            #region USLUGA
            //            modelBuilder.Entity<Usluga>()
            //                .Property(e => e.Vlasnik)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Usluga>()
            //                .Property(e => e.Cena)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<Usluga>()
            //                .Property(e => e.Kolicina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<Usluga>()
            //                .Property(e => e.JedinicaMere)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Usluga>()
            //                .Property(e => e.Iznos)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<Usluga>()
            //                .Property(e => e.Skladiste)
            //                .IsUnicode(false);
            //            #endregion
            //            ////////////////////////////////////////////////////////////////////////
            //            #region UTOVAR
            //            modelBuilder.Entity<Utovar>()
            //                .Property(e => e.UkupnaZapremina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<Utovar>()
            //                .Property(e => e.UkupnaTezina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<Utovar>()
            //                .Property(e => e.DistributivniCentar)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Utovar>()
            //                .HasMany(e => e.UtovarStavkes)
            //                .WithRequired(e => e.Utovar1)
            //                .HasForeignKey(e => e.Utovar)
            //                .WillCascadeOnDelete(false);
            //            #endregion
            //            /////////////////////////////////////////////////////////////////
            //            #region UTOVAR STAVKE
            //            modelBuilder.Entity<UtovarStavke>()
            //                .Property(e => e.Vlasnik)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<UtovarStavke>()
            //                .Property(e => e.Kupac)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<UtovarStavke>()
            //                .Property(e => e.Zapremina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<UtovarStavke>()
            //                .Property(e => e.Tezina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<UtovarStavke>()
            //                .Property(e => e.BrojNZI)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<UtovarStavke>()
            //                .Property(e => e.Koleta)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<UtovarStavke>()
            //                .Property(e => e.UtovarenoKoleta)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<UtovarStavke>()
            //                .Property(e => e.UtovarenaTezina)
            //                .HasPrecision(18, 4);
            //            #endregion
            //            /////////////////////////////////////////////////////////////////////
            //            #region VALUTA
            //            modelBuilder.Entity<Valuta>()
            //                .Property(e => e.Sifra)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Valuta>()
            //                .Property(e => e.Drzava)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Valuta>()
            //                .HasMany(e => e.CarinskaOtpremnicaStavkes)
            //                .WithRequired(e => e.Valuta1)
            //                .HasForeignKey(e => e.Valuta)
            //                .WillCascadeOnDelete(false);

            //            modelBuilder.Entity<Valuta>()
            //                .HasMany(e => e.CarinskaPrijemnicaStavkes)
            //                .WithRequired(e => e.Valuta1)
            //                .HasForeignKey(e => e.Valuta)
            //                .WillCascadeOnDelete(false);
            //            #endregion
            //            /////////////////////////////////////////////////////////////////////////
            //            #region VERTIGO
            //            modelBuilder.Entity<VertigoNijeUcitano_>()
            //                .Property(e => e.Kolicina)
            //                .HasPrecision(18, 0);
            //            #endregion
            //            /////////////////////////////////////////////////////////////////////////////
            //            #region ZAHTEV ZA PROMENU ZALIHA
            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.BrojDokumenta)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.EksternaSifraStavke)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.ArtikalSifra)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.ArtikalVlasnik)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.Kolicina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.JM)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.TipKretanja)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.EksternoSkladiste)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.SerijskiBroj)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.Serija)
            //                .IsUnicode(false);

            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
                .Property(e => e.RowVersion)
                .HasMaxLength(8).HasColumnName("timestamp");

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.PurchaseOrderId)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.PurchaseOrderItemNumber)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.DeliveryId)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.DeliveryItemNumber)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.VlasnikPrijema)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.EksternoSkladistePrijema)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.SerijaPrijema)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<ZahtevZaPromenuZaliha>()
            //                .Property(e => e.SerijskiBrojUIID)
            //                .IsUnicode(false);
            //            #endregion
            //            ////////////////////////////////////////////////////////////////////////////////
            //            #region ZALIHA
            //            modelBuilder.Entity<Zaliha>()
            //                .Property(e => e.Lokacija)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Zaliha>()
            //                .Property(e => e.LPN)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Zaliha>()
            //                .Property(e => e.ArtikalVlasnik)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Zaliha>()
            //                .Property(e => e.ArtikalSifra)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Zaliha>()
            //                .Property(e => e.Kolicina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<Zaliha>()
            //                .Property(e => e.RezervisanaKolicina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<Zaliha>()
            //                .Property(e => e.IzabranaKolicina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<Zaliha>()
            //                .Property(e => e.BlokiranaKolicina)
            //                .HasPrecision(18, 4);

            //            modelBuilder.Entity<Zaliha>()
            //                .Property(e => e.Skladiste)
            //                .IsUnicode(false);

            modelBuilder.Entity<Zaliha>()
                .Property(e => e.RowVersion)
                .HasMaxLength(8).HasColumnName("timestamp");

            //            modelBuilder.Entity<Zaliha>()
            //                .Property(e => e.EksternoSkladiste)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Zaliha>()
            //                .Property(e => e.BrojKoleta)
            //                .HasPrecision(18, 4);
            //            ////////////////////////////////////////////////////////////////////
            //            #endregion


            //            ////////////////////////////////////////////////////////////////////////////////
            //            #region ZONA
            //            modelBuilder.Entity<Zona>()
            //                .Property(e => e.Sifra)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Zona>()
            //                .Property(e => e.Oblast)
            //                .IsUnicode(false);

            //            modelBuilder.Entity<Zona>()
            //                .HasMany(e => e.Lokacijas)
            //                .WithRequired(e => e.Zona1)
            //                .HasForeignKey(e => e.Zona)
            //                .WillCascadeOnDelete(false);
            //            /////////////////////////////////////////////////////////////////////////////////
            //            #endregion

            //            ////////////////////////////////////////////////////
        }
   }
}

#endregion