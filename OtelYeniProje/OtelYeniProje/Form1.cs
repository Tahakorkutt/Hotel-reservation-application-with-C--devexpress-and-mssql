using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYeniProje
{
    public partial class BtnUrunGrupTanimlari : Form
    {
        public BtnUrunGrupTanimlari()
        {
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmDurum fr = new Formlar.Tanımlamalar.FrmDurum();
            fr.Show();
        }

        private void BtnBirimTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmBirim frm = new Formlar.Tanımlamalar.FrmBirim();
            frm.Show();
        }

        private void BtnDepartmanTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmDepartman frm = new Formlar.Tanımlamalar.FrmDepartman();

            frm.Show();
        }

        private void BtnGörevTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmGorev frm = new Formlar.Tanımlamalar.FrmGorev();

            frm.Show();
        }

        private void BtnKasaTanimları_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmKasa frm = new Formlar.Tanımlamalar.FrmKasa();

            frm.Show();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmKurlar  frm = new Formlar.Tanımlamalar.FrmKurlar();

            frm.Show();
        }

        private void BtnOdaTanımlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmOda frm = new Formlar.Tanımlamalar.FrmOda();

            frm.Show();
        }

        private void BtnTelefonTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmTelefon frm = new Formlar.Tanımlamalar.FrmTelefon();

            frm.Show();
        }

        private void BtnUlkeTanimlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmUlke frm = new Formlar.Tanımlamalar.FrmUlke();

            frm.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Tanımlamalar.FrmUrunGrup frm = new Formlar.Tanımlamalar.FrmUrunGrup();

            frm.Show();
        }

        private void BtnPersonelKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personel.FrmPersonelKarti frm = new Formlar.Personel.FrmPersonelKarti();

            frm.Show();
        }

        private void BtnPersonelListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Personel.FrmPersonelListesi frm = new Formlar.Personel.FrmPersonelListesi();

            frm.MdiParent = this;
            frm.Show();

        }

        private void BtnMisafirKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.misafir.FrmMisafirKarti frm = new Formlar.misafir.FrmMisafirKarti();

           
            frm.Show();
        }

        private void BtnMisafirListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.misafir.FrmMisafirListesi frm = new Formlar.misafir.FrmMisafirListesi();

            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnUrunListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.urun.FrmUrunListesi frm = new Formlar.urun.FrmUrunListesi();

            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnÜrünKarti_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.urun.FrmUrunKarti frm = new Formlar.urun.FrmUrunKarti();

      
            frm.Show();

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.urun.FrmUrunGirisHareketleri frm = new Formlar.urun.FrmUrunGirisHareketleri();

            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnÜrünÇıkış_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.urun.FrmUrunCikisHareketleri frm = new Formlar.urun.FrmUrunCikisHareketleri();

            frm.MdiParent = this;
            frm.Show();
        }

        private void BtnYeniÜrünHareketi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.urun.FrmÜrünHareketTanimi frm = new Formlar.urun.FrmÜrünHareketTanimi();

         
            frm.Show();
        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmTümRezervasyonlar frm = new Formlar.Rezervasyon.FrmTümRezervasyonlar();


            frm.Show();

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmRezervasyonKarti frm = new Formlar.Rezervasyon.FrmRezervasyonKarti();
           

            frm.Show();
        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.Rezervasyon.FrmİptalRezervasyon frm = new Formlar.Rezervasyon.FrmİptalRezervasyon();


            frm.Show();
        }

        private void BtnAktifRezarvasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmAktifRezervasyon frm = new Formlar.Rezervasyon.FrmAktifRezervasyon();


            frm.Show();

        }

        private void BtnGeçmişRezervasyon_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmGecmisRezervasyonlar frm = new Formlar.Rezervasyon.FrmGecmisRezervasyonlar();


            frm.Show();

        }

        private void BtnGelecekRezervasyonlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Rezervasyon.FrmGelecekRezervasyonlar frm = new Formlar.Rezervasyon.FrmGelecekRezervasyonlar();


            frm.Show();
        }

        private void BtnWord_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("winword");
        }

        private void BtnHesapMakinesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");

        }

        private void BtnExcel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start("excel");


        }

        private void BtnKurlar_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Formlar.Araclar.FrmKurlar frm = new Formlar.Araclar.FrmKurlar();


            frm.Show();
        }

        private void BtnYoutube_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araclar.FrmYoutube frm = new Formlar.Araclar.FrmYoutube();


            frm.Show();
        }

        private void BtnGoogle_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Formlar.Araclar.FrmGoogle frm = new Formlar.Araclar.FrmGoogle();


            frm.Show();
        }
    }
}
