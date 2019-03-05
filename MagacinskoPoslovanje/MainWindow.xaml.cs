using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MagacinskoPoslovanje.Context;
using MagacinskoPoslovanje.Data;
using System.IO;
using System.Data.Entity;
using MagacinskoPoslovanje.Services;
using Microsoft.Win32;

namespace MagacinskoPoslovanje
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
            CMenuItemDef lmeniDef = new CMenuItemDef();
            lmeniDef.LoadMenu("GLAVNI_MENI");

            this.CreateMenu(lmeniDef);


            try
            {
                MpContext mp = new MpContext("InfoContext");

                #region PRIMER KODA

                // UnitOfWork.UnitOfWork unit = new UnitOfWork.UnitOfWork(mp);
                //List<Sifarnik> sf = new List<Sifarnik>();

                //Artikal kor = new Artikal();


                //kor.Sifra = "A34";
                //kor.Boja = "Bela";
                //kor.Brand = "Sony";
                //kor.BrutoTezina = 25;
                //kor.Cena = 5585;
                //kor.Naziv = "BANAANAAN";
                //mp.Artikal.Add(kor);
                //mp.SaveChanges();
                //SifarnikEntiteta sfe = new SifarnikEntiteta();
                //sfe.ID = 1;
                //sfe.Naziv = "Kontakt";
                //mp.SifarnikEntiteta.Add(sfe);
                //SifarnikEntitetaTip sft = new SifarnikEntitetaTip();
                //sft.ID = 101;
                //sft.SifarnikEntiteta = 1;
                //sft.Naziv = "Tip Kontakta";
                //mp.SifarnikEntitetaTip.Add(sft);
                //Sifarnik sif = new Sifarnik();
                //sif.ID = 10101;
                //sif.SifarnikEntitetaTip = 101;
                //sif.Sifra = "10101";
                //sif.Naziv = "Vlasnik";
                //mp.Sifarnik.Add(sif);
                //mp.SaveChanges();
                //var justOneBook = unit.SifarnikEntitetaRepository.Entities
                //  .First(n => n.Naziv != null);

                //MessageBox.Show(justOneBook.Naziv.ToString());

                //UnitOfWork.UnitOfWork unit = new UnitOfWork.UnitOfWork(mp);
                //SifarnikEntiteta sfe1 = new SifarnikEntiteta();

                //sfe1.Naziv = "Marko";

                //SifarnikEntitetaTip sft = new SifarnikEntitetaTip();
                //sft.ID = 103;
                //sft.SifarnikEntiteta = 1;
                //sft.Naziv = "Tip Kontakta";
                //unit.SifarnikEntitetaTipRepository.Add(sft);
                //unit.Commit();

                //Sifarnik sif = new Sifarnik();
                //sif.ID = 10103;
                //sif.SifarnikEntitetaTip = 103;
                //sif.Sifra = "10102";
                //sif.Naziv = "Kupac";
                //unit.SifarnikRepository.Add(sif);


                //unit.Commit();
                //  SifarnikEntitetaService servisSifarnik = new SifarnikEntitetaService(unit);
                //servisSifarnik.AddSifarnikEntiteta(sfe);
                //servisSifarnik.DeleteSifarnikEntiteta(6);
                // servisSifarnik.UpdateSifarnikEntiteta(sfe);
                //SifarnikEntiteta  id =   servisSifarnik.GetSifarnikEntiteta(3);
                //   MessageBox.Show(id.ID.ToString());
                //SifarnikEntiteta sfe1 = new SifarnikEntiteta();
                //sfe1.ID = 22;
                //sfe1.Naziv = "aaaaa";
                //SifarnikEntiteta author = new SifarnikEntiteta();
                //   author = servisSifarnik.GetSifarnikEntiteta(3);

                //////////////////////// tEstiranje /////////////////////////////////

                //SifarnikEntiteta stari = unit.SifarnikEntitetaRepository.Get(10);
                //stari.Naziv = "111";
                //unit.SifarnikEntitetaRepository.UpdateEntity(stari);
                //unit.Commit();
                //unit.RejectChanges();
                List<SifarnikEntiteta> Lista = new List<SifarnikEntiteta>();
                //lISTA = unit.SifarnikEntitetaRepository.GetAll().ToList();

                //  Services.SifanikEntitetaServices ser = new SifanikEntitetaServices();
                //PTIKAZI PO ID

                //SifarnikEntiteta s = ser.Get(1);
                // MessageBox.Show(s.ID.ToString() + " " + s.Naziv.ToString());

                //PRIKAZI LISTU

                // List<SifarnikEntiteta> sifelista = new List<SifarnikEntiteta>();
                // Services.Servis ser1 = new Servis();
                // sifelista = ser1.GetAll().ToList();

                // DODAJ OBJEKAT

                // SifarnikEntiteta ss = new SifarnikEntiteta();
                // ss.ID = 66;
                // ss.Naziv = "Test";

                // Services.Servis ser2 = new Servis();
                // ser2.Add(ss);

                // DODAJ LISU OBJEKATA

                //SifarnikEntiteta s1 = new SifarnikEntiteta();
                //s1.Naziv = "Pera";
                //Lista.Add(s1);
                //SifarnikEntiteta s2 = new SifarnikEntiteta();
                //s2.Naziv="Mika";
                //Lista.Add(s2);

                //ser.AddRange(Lista);

                // UPDATE OBJEKAT

                //SifarnikEntiteta s = ser.Get(10);
                //s.Naziv = "222";
                //ser.UpdateEntity(s);

                //OB5RISI OBJEKAT

                //SifarnikEntiteta s1 = ser.Get(10);
                //ser.Remove(s1);

                //OB5RISI GRUPU OBJEKATA

                // SifarnikEntiteta s = ser.Get(1);
                //SifarnikEntiteta s1 = ser.Get(3);
                //SifarnikEntiteta s2 = ser.Get(4);
                //SifarnikEntiteta s3 = ser.Get(5);
                //SifarnikEntiteta s4 = ser.Get(8);

                // Lista.Add(s);
                //Lista.Add(s1);
                //Lista.Add(s2);
                //Lista.Add(s3);
                //Lista.Add(s4);

                //ser.RemoveRange(Lista);

                //OB5RISI OBJEKAT

                //SifarnikEntiteta s = ser.Get(7);
                //ser.RemoveEntity(s);

                //FIND single


                //SifarnikEntiteta s = ser.Find(x => x.Naziv == "Dusko");
                //MessageBox.Show(s.Naziv.ToString());
                #endregion

                #region DODAVANJE SIFARNIKA U BAZU
                /*
                 * Kada se dodaje sifarnik u bazu ukoliko pukne prilikom dodavanja
                 * tipa netiteta potrebno je proveriti koji je IDredni u tabeli 
                 * SIFARNIK ENTITETA taj broj mora biti u polju sifarnik entiteta
                 * klase SIFARNIKeNTITETAtIP
                 */
                ////////////////// DODAVANJE SIHRE U SIFARNIK///////////////////

                SifanikEntitetaServices Sentiteta = new SifanikEntitetaServices();
                SifarnikEntiteta sfe = new SifarnikEntiteta();
                sfe.ID = 23;
                sfe.Naziv = "Kontakt";



                SifarnikEntitetaTipServices SentitetaTip = new SifarnikEntitetaTipServices();
                SifarnikEntitetaTip sft = new SifarnikEntitetaTip();

                sft.ID = 101;
                sft.SifarnikEntiteta = 1;
                sft.Naziv = "Tip Kontakta";


                SifarnikServis SifServis = new SifarnikServis();
                Sifarnik sif = new Sifarnik();
                sif.ID = 10101;
                sif.SifarnikEntitetaTip = 101;
                sif.Sifra = "10101";
                sif.Naziv = "Vlasnik";

                Sentiteta.Add(sfe);
                SentitetaTip.Add(sft);
                SifServis.Add(sif);

                #endregion


            }
            catch (Exception ex)
            {

              //  MessageBox.Show(ex.Message);
                File.WriteAllText(@"D:\Greska.txt", ex.ToString());
            }

        }

        private void CreateMenu(CMenuItemDef pmniDef)
        {
            Menu mojMeni = new Menu();
            mojMeni.VerticalAlignment = VerticalAlignment.Top;
            mojMeni.HorizontalAlignment = HorizontalAlignment.Stretch;
            mojMeni.Height = 25;
            mainGrid.Children.Add(mojMeni);

            foreach (CMenuItemDef miTempDef in pmniDef.Items)
            {
                MenuItem mniItem = new MenuItem();
                mniItem.Header = miTempDef.Header;
                mniItem.IsEnabled = miTempDef.IsEnabled;

                mniItem.Resources.Add("APP_OPTION", miTempDef.OptionId);

                if (miTempDef.Items.Count == 0 || miTempDef.OptionId != "")
                {
                    mniItem.Click += MenuClick;
                }
                else
                {
                    this.CreateSubMenu(mniItem, miTempDef.Items);
                }

                mojMeni.Items.Add(mniItem);

            }
        }
        private void CreateSubMenu(MenuItem pmnItem, ICollection<CMenuItemDef> pSubMenuDef)
        {
            foreach (CMenuItemDef miTempDef in pSubMenuDef)
            {
                MenuItem mniItem = new MenuItem();
                mniItem.Header = miTempDef.Header;
                mniItem.IsEnabled = miTempDef.IsEnabled;

                mniItem.Resources.Add("APP_OPTION", miTempDef.OptionId);

                if (miTempDef.Items.Count == 0 || miTempDef.OptionId != "")
                {
                    mniItem.Click += MenuClick;
                }
                else
                {
                    this.CreateSubMenu(mniItem, miTempDef.Items);
                }

                pmnItem.Items.Add(mniItem);

            }

        }

        private void MenuClick(object sender, RoutedEventArgs e)
        {
            MenuItem lMnu = (MenuItem)sender;

            string lOptionId = (string)lMnu.FindResource("APP_OPTION");
            if (lOptionId != "")
            {
                MessageBox.Show("Opcija: " + lOptionId);
            }
        }
    }
}
