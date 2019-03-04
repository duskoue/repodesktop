using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagacinskoPoslovanje.Data;
using MagacinskoPoslovanje.Services;
using MagacinskoPoslovanje.Context;
using System.Data.Entity;

namespace MagacinskoPoslovanje.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly MpContext _dbContext;

        #region Repositories
        public IRepository<SifarnikEntiteta> SifarnikEntitetaRepository =>
           new GenericRepository<SifarnikEntiteta>(_dbContext);

        public IRepository<SifarnikEntitetaTip> SifarnikEntitetaTipRepository =>
            new GenericRepository<SifarnikEntitetaTip>(_dbContext);

        public IRepository<Sifarnik> SifarnikRepository =>
           new GenericRepository<Sifarnik>(_dbContext);

        public IRepository<Artikal> ArtikalRepository =>
           new GenericRepository<Artikal>(_dbContext);


        public IRepository<ArtikliIzlaz> ArtikliIzlazRepository =>
           new GenericRepository<ArtikliIzlaz>(_dbContext);


        public IRepository<ArtikliUlaz> ArtikliUlazRepository =>
           new GenericRepository<ArtikliUlaz>(_dbContext);


        public IRepository<ArtikliZamena> ArtikliZamenaRepository =>
           new GenericRepository<ArtikliZamena>(_dbContext);


        public IRepository<Atribut> AtributRepository =>
           new GenericRepository<Atribut>(_dbContext);


        public IRepository<Barcode> BarcodeRepository =>
           new GenericRepository<Barcode>(_dbContext);


        public IRepository<Blokada> BlokadaRepository =>
           new GenericRepository<Blokada>(_dbContext);

        public IRepository<Brojac> BrojacRepository =>
           new GenericRepository<Brojac>(_dbContext);


        public IRepository<CarinskaGrupaArtikla> CarinskaGrupaArtiklaRepository =>
           new GenericRepository<CarinskaGrupaArtikla>(_dbContext);


        public IRepository<CarinskaIspostava> CarinskaIspostavaRepository =>
           new GenericRepository<CarinskaIspostava>(_dbContext);


        public IRepository<CarinskaOtpremnica> CarinskaOtpremnicaRepository =>
           new GenericRepository<CarinskaOtpremnica>(_dbContext);


        public IRepository<CarinskaOtpremnicaStavke> CarinskaOtpremnicaStavkeRepository =>
           new GenericRepository<CarinskaOtpremnicaStavke>(_dbContext);

        public IRepository<CarinskaPrijemnica> CarinskaPrijemnicaRepository =>
           new GenericRepository<CarinskaPrijemnica>(_dbContext);


        public IRepository<CarinskaPrijemnicaStavke> CarinskaPrijemnicaStavkeRepository =>
           new GenericRepository<CarinskaPrijemnicaStavke>(_dbContext);


        public IRepository<COReport> COReportRepository =>
           new GenericRepository<COReport>(_dbContext);


        public IRepository<CrossDock> CrossDockRepository =>
           new GenericRepository<CrossDock>(_dbContext);

        public IRepository<DodatnoAngazovaniRadnik> DodatnoAngazovaniRadnikRepository =>
           new GenericRepository<DodatnoAngazovaniRadnik>(_dbContext);


        public IRepository<DupleSifre> DupleSifreRepository =>
           new GenericRepository<DupleSifre>(_dbContext);


        public IRepository<EksterniKorisnik> EksterniKorisnikRepository =>
           new GenericRepository<EksterniKorisnik>(_dbContext);


        public IRepository<EksterniPreno> EksterniPrenosRepository =>
           new GenericRepository<EksterniPreno>(_dbContext);

        public IRepository<EksterniPrenosStavke> EksterniPrnosStavkeRepository =>
           new GenericRepository<EksterniPrenosStavke>(_dbContext);


        public IRepository<Grupa> GrupaRepository =>
           new GenericRepository<Grupa>(_dbContext);


        public IRepository<GrupaStavke> GrupaStavkeReposiory =>
           new GenericRepository<GrupaStavke>(_dbContext);


        public IRepository<ImportSerijskihBrojevaTemp> ImportSerijskihBrojevaRepository =>
           new GenericRepository<ImportSerijskihBrojevaTemp>(_dbContext);


        public IRepository<InterfaceLog> InterfaceLogRepository =>
           new GenericRepository<InterfaceLog>(_dbContext);


        public IRepository<InterniPreno> InterniPrenosRepository =>
           new GenericRepository<InterniPreno>(_dbContext);


        public IRepository<InterniPrenosStavke> InterniPrenosStavke =>
           new GenericRepository<InterniPrenosStavke>(_dbContext);


        public IRepository<IzlazniID> IzlazniIDRepository =>
           new GenericRepository<IzlazniID>(_dbContext);


        public IRepository<IzvestajSkladistenja> IzvestajSkladistenjaRepository =>
           new GenericRepository<IzvestajSkladistenja>(_dbContext);


        public IRepository<JCINaimenovanja> JCINaimenovanjaRepository =>
           new GenericRepository<JCINaimenovanja>(_dbContext);


        public IRepository<JM> JMRepository =>
           new GenericRepository<JM>(_dbContext);


        public IRepository<KarticaArtikla> KarticaArtiklaRepository =>
           new GenericRepository<KarticaArtikla>(_dbContext);

        public IRepository<KEPU> KEPURepository =>
           new GenericRepository<KEPU>(_dbContext);


        public IRepository<Kontakt> KontaktRepository =>
           new GenericRepository<Kontakt>(_dbContext);


        public IRepository<Kontejner> KontejnerRepository =>
           new GenericRepository<Kontejner>(_dbContext);


        public IRepository<KontejnerPrijem> KontejnerPrijemRepository =>
           new GenericRepository<KontejnerPrijem>(_dbContext);


        public IRepository<Korisnik> KorisnikRepository =>
           new GenericRepository<Korisnik>(_dbContext);


        public IRepository<LogHost> LogHostRepository =>
           new GenericRepository<LogHost>(_dbContext);


        public IRepository<Lokacija> LokacijaRepository =>
           new GenericRepository<Lokacija>(_dbContext);


        public IRepository<LokacijaKlijenta> LokacijaKlijentaRepository =>
           new GenericRepository<LokacijaKlijenta>(_dbContext);


        public IRepository<LPN> LPNRepository =>
           new GenericRepository<LPN>(_dbContext);


        public IRepository<MagacinskaKnjiga> MagacinskaKnjigaRepository =>
           new GenericRepository<MagacinskaKnjiga>(_dbContext);


        public IRepository<Mesto> MestoRepository =>
           new GenericRepository<Mesto>(_dbContext);


        public IRepository<NabavniNalog> NabavniNalogRepository =>
           new GenericRepository<NabavniNalog>(_dbContext);


        public IRepository<NabavniNalogStavke> NabavniNalogStavkeRepository =>
           new GenericRepository<NabavniNalogStavke>(_dbContext);


        public IRepository<NalogLogPodaci> NalogLogPodaciRepository =>
           new GenericRepository<NalogLogPodaci>(_dbContext);


        public IRepository<NalogZaPakovanje> NalogZaPakovanjeRepository =>
           new GenericRepository<NalogZaPakovanje>(_dbContext);


        public IRepository<NeradniDani> NeradniDaniRepository =>
           new GenericRepository<NeradniDani>(_dbContext);


        public IRepository<NerazduzeniMB> NerazduzeniMBRepository =>
           new GenericRepository<NerazduzeniMB>(_dbContext);


        public IRepository<Oblast> OblastRepository =>
           new GenericRepository<Oblast>(_dbContext);


        public IRepository<Obracun> ObracunRepository =>
           new GenericRepository<Obracun>(_dbContext);


        public IRepository<ObracunCarinski> ObracunCarinskiRepository =>
           new GenericRepository<ObracunCarinski>(_dbContext);



        public IRepository<ObracunKomercijalni> ObracunKomercijalniRepository =>
           new GenericRepository<ObracunKomercijalni>(_dbContext);


        public IRepository<Odabir> OdabirRepository =>
           new GenericRepository<Odabir>(_dbContext);


        public IRepository<OdabirReport> OdabirReportRepository =>
           new GenericRepository<OdabirReport>(_dbContext);


        public IRepository<Otpremnica> OtpremnicaRepository =>
           new GenericRepository<Otpremnica>(_dbContext);


        public IRepository<OtpremnicaKontrola> OtpremnicaKontrolaRepository =>
           new GenericRepository<OtpremnicaKontrola>(_dbContext);


        public IRepository<OtpremnicaStatusLog> OtpremnicaStatusiLogRepository =>
           new GenericRepository<OtpremnicaStatusLog>(_dbContext);


        public IRepository<OtpremnicaStavke> OtpremnicaStavkeRepository =>
           new GenericRepository<OtpremnicaStavke>(_dbContext);


        public IRepository<Pakovanje> PakovanjeRepository =>
           new GenericRepository<Pakovanje>(_dbContext);


        public IRepository<Parametrizacija> ParametrizacijaRepository =>
           new GenericRepository<Parametrizacija>(_dbContext);


        public IRepository<PodesavanjaFormi> PodesavanjeFormiRepository =>
           new GenericRepository<PodesavanjaFormi>(_dbContext);

        public IRepository<PodesavanjeZaliha> PodesavanjeZalihaStavkiRepository =>
           new GenericRepository<PodesavanjeZaliha>(_dbContext);


        public IRepository<PodesavanjeZalihaStavke> PodesavanjZalihaStavkeRepository =>
           new GenericRepository<PodesavanjeZalihaStavke>(_dbContext);


        public IRepository<Popi> PopisRepository =>
           new GenericRepository<Popi>(_dbContext);


        public IRepository<PopisLista> PopisListaRepository =>
           new GenericRepository<PopisLista>(_dbContext);


        public IRepository<PopisStavke> PopisStavkeRepository =>
           new GenericRepository<PopisStavke>(_dbContext);


        public IRepository<PorukaKnjizenja> PorukaKnjizanjaRepository =>
           new GenericRepository<PorukaKnjizenja>(_dbContext);


        public IRepository<Posao> PosaoRepository =>
           new GenericRepository<Posao>(_dbContext);


        public IRepository<Pravo> PravoRepository =>
           new GenericRepository<Pravo>(_dbContext);


        public IRepository<Prijemnica> PrijemnicaRepository =>
           new GenericRepository<Prijemnica>(_dbContext);


        public IRepository<PrijemnicaStavke> PrijemnicaStavkeRepository =>
           new GenericRepository<PrijemnicaStavke>(_dbContext);


        public IRepository<PrijemReport> PrijemReportRepository =>
           new GenericRepository<PrijemReport>(_dbContext);


        public IRepository<Prilog> PrilogRepository =>
           new GenericRepository<Prilog>(_dbContext);


        public IRepository<PSLArtikliTemp> PSLArtikliTemoRepository =>
           new GenericRepository<PSLArtikliTemp>(_dbContext);


        public IRepository<RazduzenjaMB> RazduzenjaMBRepository =>
           new GenericRepository<RazduzenjaMB>(_dbContext);


        public IRepository<RazdvajanjePrijema> RazdvajanjePrijemaRepository =>
           new GenericRepository<RazdvajanjePrijema>(_dbContext);


        public IRepository<RazdvajanjePrijemaStavke> RazdvajanjePrijemaStavkeRepository =>
           new GenericRepository<RazdvajanjePrijemaStavke>(_dbContext);

        public IRepository<Rola> RolaRepository =>
           new GenericRepository<Rola>(_dbContext);


        public IRepository<Sarza> SarzaRepository =>
           new GenericRepository<Sarza>(_dbContext);


        public IRepository<Sastavnica> SastavnicaRepository =>
           new GenericRepository<Sastavnica>(_dbContext);


        public IRepository<SastavnicaPrijem> SastavnicaPrijemRepository =>
           new GenericRepository<SastavnicaPrijem>(_dbContext);


        public IRepository<SastavnicaStavke> SastavnicaStavkeRepository =>
           new GenericRepository<SastavnicaStavke>(_dbContext);


        public IRepository<SerijskiBroj> SerijskiBrojRepository =>
           new GenericRepository<SerijskiBroj>(_dbContext);

        public IRepository<SerijskiBrojPakovanje> SerijskiBrojPakovanjeRepository =>
           new GenericRepository<SerijskiBrojPakovanje>(_dbContext);


        public IRepository<Skladiste> SkladisteRepository =>
           new GenericRepository<Skladiste>(_dbContext);


        public IRepository<SpecifikacijaOtpreme> SpecifikacijaOtpremeRepository =>
           new GenericRepository<SpecifikacijaOtpreme>(_dbContext);


        public IRepository<SpecZaCarinjenje> SpecZaCarinjenjeRepository =>
           new GenericRepository<SpecZaCarinjenje>(_dbContext);


        public IRepository<SpecZaCarinjenjeStavke> SpecZaCarinjenjeStavkeRepository =>
           new GenericRepository<SpecZaCarinjenjeStavke>(_dbContext);


        public IRepository<StampaciNalepnice> StampaciNalepniceRepository =>
           new GenericRepository<StampaciNalepnice>(_dbContext);


        public IRepository<StanjeZaliha> StanjeZalihaRepository =>
           new GenericRepository<StanjeZaliha>(_dbContext);


        public IRepository<StanjeZalihaArhiva> StanjeZalihaArhivaRepository =>
           new GenericRepository<StanjeZalihaArhiva>(_dbContext);


        public IRepository<StatusLog> StatusLogRepository =>
           new GenericRepository<StatusLog>(_dbContext);


        public IRepository<StorageReportZenith> StorageReportZenithRepository =>
           new GenericRepository<StorageReportZenith>(_dbContext);


        public IRepository<StornoDokumenta> StornoDokumentaRepository =>
           new GenericRepository<StornoDokumenta>(_dbContext);


        public IRepository<SumaSarzaMB> SumaSarzaMBRepository =>
           new GenericRepository<SumaSarzaMB>(_dbContext);


        public IRepository<Tarifa> TarifaRepository =>
           new GenericRepository<Tarifa>(_dbContext);


        public IRepository<TarifaStavke> TarifaStavkeRepository =>
           new GenericRepository<TarifaStavke>(_dbContext);


        public IRepository<tmpArtikal> TmpArtikalRepository =>
           new GenericRepository<tmpArtikal>(_dbContext);


        public IRepository<TransakcijaZaliha> TransakcijaZalihaRepository =>
           new GenericRepository<TransakcijaZaliha>(_dbContext);


        public IRepository<TranZal> TranZalRepository =>
           new GenericRepository<TranZal>(_dbContext);


        public IRepository<UlaziIzlazi> UlaziIzlaziRepository =>
           new GenericRepository<UlaziIzlazi>(_dbContext);


        public IRepository<Usluga> UslugaRepository =>
           new GenericRepository<Usluga>(_dbContext);


        public IRepository<Utovar> UtovarRepository =>
           new GenericRepository<Utovar>(_dbContext);


        public IRepository<UtovarStavke> UtovarStavkeRepository =>
           new GenericRepository<UtovarStavke>(_dbContext);


        public IRepository<Valuta> ValutaRepository =>
           new GenericRepository<Valuta>(_dbContext);


        public IRepository<Verzija> VerzijaRepository =>
           new GenericRepository<Verzija>(_dbContext);


        public IRepository<ZaduzenjaMB> ZaduzenjaMBRepository =>
           new GenericRepository<ZaduzenjaMB>(_dbContext);


        public IRepository<ZahtevZaPromenuZaliha> ZahtevZaPromenuZalihaRepository =>
           new GenericRepository<ZahtevZaPromenuZaliha>(_dbContext);


        public IRepository<Zaliha> ZalihaRepositpry =>
           new GenericRepository<Zaliha>(_dbContext);


        public IRepository<ZaliheZaPremestajTemp> ZAliheZaPremestajTempRepository =>
           new GenericRepository<ZaliheZaPremestajTemp>(_dbContext);


        public IRepository<ZauzeteRegalneLokacijePoVlasniku> ZauzeteRegalneLokacijePoVlasnikuRepository =>
           new GenericRepository<ZauzeteRegalneLokacijePoVlasniku>(_dbContext);


        public IRepository<ZauzeteRegalneLokacijePoVlasnikuSUM> ZauzeteRegalneLokacijePoVlasnikuSUMRepository =>
           new GenericRepository<ZauzeteRegalneLokacijePoVlasnikuSUM>(_dbContext);

        public IRepository<Zona> ZonaRepository =>
           new GenericRepository<Zona>(_dbContext);

        #endregion

        public UnitOfWork(MpContext Context)
        {
            _dbContext = Context;
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }

        public void RejectChanges()
        {
            foreach (var entry in _dbContext.ChangeTracker.Entries()
                  .Where(e => e.State != EntityState.Unchanged))
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.State = EntityState.Detached;
                        break;
                    case EntityState.Modified:
                    case EntityState.Deleted:
                        entry.Reload();
                        break;
                }
            }
        }
    }
}
    

