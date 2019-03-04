using MagacinskoPoslovanje.Data;
using MagacinskoPoslovanje.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoPoslovanje.UnitOfWork
{
   public interface IUnitOfWork
    {
        #region REPOSITORY

        IRepository<SifarnikEntiteta> SifarnikEntitetaRepository { get; }
        IRepository<SifarnikEntitetaTip> SifarnikEntitetaTipRepository { get; }
        IRepository<Sifarnik> SifarnikRepository { get; }
        IRepository<Artikal> ArtikalRepository { get; }
        IRepository<ArtikliIzlaz> ArtikliIzlazRepository { get; }
        IRepository<ArtikliUlaz> ArtikliUlazRepository { get; }
        IRepository<ArtikliZamena> ArtikliZamenaRepository { get; }
        IRepository<Atribut> AtributRepository { get; }
        IRepository<Barcode> BarcodeRepository { get; }
        IRepository<Blokada> BlokadaRepository { get; }
        IRepository<Brojac> BrojacRepository { get; }
        IRepository<CarinskaGrupaArtikla> CarinskaGrupaArtiklaRepository { get; }
        IRepository<CarinskaIspostava> CarinskaIspostavaRepository { get; }
        IRepository<CarinskaOtpremnica> CarinskaOtpremnicaRepository { get; }
        IRepository<CarinskaOtpremnicaStavke> CarinskaOtpremnicaStavkeRepository { get; }
        IRepository<CarinskaPrijemnica> CarinskaPrijemnicaRepository { get; }
        IRepository<CarinskaPrijemnicaStavke> CarinskaPrijemnicaStavkeRepository { get; }
        IRepository<COReport> COReportRepository { get; }
        IRepository<CrossDock> CrossDockRepository { get; }
        IRepository<DodatnoAngazovaniRadnik> DodatnoAngazovaniRadnikRepository { get; }
        IRepository<DupleSifre> DupleSifreRepository { get; }
        IRepository<EksterniKorisnik> EksterniKorisnikRepository { get; }
        IRepository<EksterniPreno> EksterniPrenosRepository { get; }
        IRepository<EksterniPrenosStavke> EksterniPrnosStavkeRepository { get; }
        IRepository<Grupa> GrupaRepository { get; }
        IRepository<GrupaStavke> GrupaStavkeReposiory { get; }
        IRepository<ImportSerijskihBrojevaTemp> ImportSerijskihBrojevaRepository { get; }
        IRepository<InterfaceLog> InterfaceLogRepository { get; }
        IRepository<InterniPreno> InterniPrenosRepository { get; }
        IRepository<InterniPrenosStavke> InterniPrenosStavke { get; }
        IRepository<IzlazniID> IzlazniIDRepository { get; }
        IRepository<IzvestajSkladistenja> IzvestajSkladistenjaRepository { get; }
        IRepository<JCINaimenovanja> JCINaimenovanjaRepository { get; }
        IRepository<JM> JMRepository { get; }
        IRepository<KarticaArtikla> KarticaArtiklaRepository { get; }
        IRepository<KEPU> KEPURepository { get; }
        IRepository<Kontakt> KontaktRepository { get; }
        IRepository<Kontejner> KontejnerRepository { get; }
        IRepository<KontejnerPrijem> KontejnerPrijemRepository { get; }
        IRepository<Korisnik> KorisnikRepository { get; }
        IRepository<LogHost> LogHostRepository { get; }
        IRepository<Lokacija> LokacijaRepository { get; }
        IRepository<LokacijaKlijenta> LokacijaKlijentaRepository { get; }
        IRepository<LPN> LPNRepository { get; }
        IRepository<MagacinskaKnjiga> MagacinskaKnjigaRepository { get; }
        IRepository<Mesto> MestoRepository { get; }
        IRepository<NabavniNalog> NabavniNalogRepository { get; }
        IRepository<NabavniNalogStavke> NabavniNalogStavkeRepository { get; }
        IRepository<NalogLogPodaci> NalogLogPodaciRepository { get; }
        IRepository<NalogZaPakovanje> NalogZaPakovanjeRepository { get; }
        IRepository<NeradniDani> NeradniDaniRepository { get; }
        IRepository<NerazduzeniMB> NerazduzeniMBRepository { get; }
        IRepository<Oblast> OblastRepository { get; }
        IRepository<Obracun> ObracunRepository { get; }
        IRepository<ObracunCarinski> ObracunCarinskiRepository { get; }
        IRepository<ObracunKomercijalni> ObracunKomercijalniRepository { get; }
        IRepository<Odabir> OdabirRepository { get; }
        IRepository<OdabirReport> OdabirReportRepository { get; }
        IRepository<Otpremnica> OtpremnicaRepository { get; }
        IRepository<OtpremnicaKontrola> OtpremnicaKontrolaRepository { get; }
        IRepository<OtpremnicaStatusLog> OtpremnicaStatusiLogRepository { get; }
        IRepository<OtpremnicaStavke> OtpremnicaStavkeRepository { get; }
        IRepository<Pakovanje> PakovanjeRepository { get; }
        IRepository<Parametrizacija> ParametrizacijaRepository { get; }
        IRepository<PodesavanjaFormi> PodesavanjeFormiRepository { get; }
        IRepository<PodesavanjeZaliha> PodesavanjeZalihaStavkiRepository { get; }
        IRepository<PodesavanjeZalihaStavke> PodesavanjZalihaStavkeRepository { get; }
        IRepository<Popi> PopisRepository { get; }
        IRepository<PopisLista> PopisListaRepository { get; }
        IRepository<PopisStavke> PopisStavkeRepository { get; }
        IRepository<PorukaKnjizenja> PorukaKnjizanjaRepository { get; }
        IRepository<Posao> PosaoRepository { get; }
        IRepository<Pravo> PravoRepository { get; }
        IRepository<Prijemnica> PrijemnicaRepository { get; }
        IRepository<PrijemnicaStavke> PrijemnicaStavkeRepository { get; }
        IRepository<PrijemReport> PrijemReportRepository { get; }
        IRepository<Prilog> PrilogRepository { get; }
        IRepository<PSLArtikliTemp> PSLArtikliTemoRepository { get; }
        IRepository<RazduzenjaMB> RazduzenjaMBRepository { get; }
        IRepository<RazdvajanjePrijema> RazdvajanjePrijemaRepository { get; }
        IRepository<RazdvajanjePrijemaStavke> RazdvajanjePrijemaStavkeRepository { get; }
        IRepository<Rola> RolaRepository { get; }
        IRepository<Sarza> SarzaRepository { get; }
        IRepository<Sastavnica> SastavnicaRepository { get; }
        IRepository<SastavnicaPrijem> SastavnicaPrijemRepository { get; }
        IRepository<SastavnicaStavke> SastavnicaStavkeRepository { get; }
        IRepository<SerijskiBroj> SerijskiBrojRepository { get; }
        IRepository<SerijskiBrojPakovanje> SerijskiBrojPakovanjeRepository { get; }
        IRepository<Skladiste> SkladisteRepository { get; }
        IRepository<SpecifikacijaOtpreme> SpecifikacijaOtpremeRepository { get; }
        IRepository<SpecZaCarinjenje> SpecZaCarinjenjeRepository { get; }
        IRepository<SpecZaCarinjenjeStavke> SpecZaCarinjenjeStavkeRepository { get; }
        IRepository<StampaciNalepnice> StampaciNalepniceRepository { get; }
        IRepository<StanjeZaliha> StanjeZalihaRepository { get; }
        IRepository<StanjeZalihaArhiva> StanjeZalihaArhivaRepository { get; }
        IRepository<StatusLog> StatusLogRepository { get; }
        IRepository<StorageReportZenith> StorageReportZenithRepository { get; }
        IRepository<StornoDokumenta> StornoDokumentaRepository { get; }
        IRepository<SumaSarzaMB> SumaSarzaMBRepository { get; }
        IRepository<Tarifa> TarifaRepository { get; }
        IRepository<TarifaStavke> TarifaStavkeRepository { get; }
        IRepository<tmpArtikal> TmpArtikalRepository { get; }
        IRepository<TransakcijaZaliha> TransakcijaZalihaRepository { get; }
        IRepository<TranZal> TranZalRepository { get; }
        IRepository<UlaziIzlazi> UlaziIzlaziRepository { get; }
        IRepository<Usluga> UslugaRepository { get; }
        IRepository<Utovar> UtovarRepository { get; }
        IRepository<UtovarStavke> UtovarStavkeRepository { get; }
        IRepository<Valuta> ValutaRepository { get; }
        IRepository<Verzija> VerzijaRepository { get; }
        IRepository<ZaduzenjaMB> ZaduzenjaMBRepository { get; }
        IRepository<ZahtevZaPromenuZaliha> ZahtevZaPromenuZalihaRepository { get; }
        IRepository<Zaliha> ZalihaRepositpry { get; }
        IRepository<ZaliheZaPremestajTemp> ZAliheZaPremestajTempRepository { get; }
        IRepository<ZauzeteRegalneLokacijePoVlasniku> ZauzeteRegalneLokacijePoVlasnikuRepository { get; }
        IRepository<ZauzeteRegalneLokacijePoVlasnikuSUM> ZauzeteRegalneLokacijePoVlasnikuSUMRepository { get; }
        IRepository<Zona> ZonaRepository { get; }


        #endregion



        // Commits all changes
        /// </summary>
        void Commit();
        /// <summary>
        /// Discards all changes that has not been commited
        /// </summary>
        void RejectChanges();
        void Dispose();
    }
}
