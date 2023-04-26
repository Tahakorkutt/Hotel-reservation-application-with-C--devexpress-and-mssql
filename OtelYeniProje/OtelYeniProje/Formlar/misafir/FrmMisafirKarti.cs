using DevExpress.XtraEditors;
using OtelYeniProje.Entity;
using OtelYeniProje.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYeniProje.Formlar.misafir
{
    public partial class FrmMisafirKarti : Form
    {
        public FrmMisafirKarti()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();
        Repository<TblMisafir> repo = new Repository<TblMisafir>();
        TblMisafir t = new TblMisafir();
        public int id;
        string resim1, resim2;
        private void FrmMisafirKarti_Load(object sender, EventArgs e)

        {
            //Güncellenecek kart bilgileri
            if (id != 0)
            {


                var misafir = repo.Find(x => x.MisafirID == id);
                TxtAdSoyad.Text = misafir.AdSoyad;
                TxtTc.Text = misafir.TC;
                TxtAdres.Text = misafir.Adres;
                TxtTelefon.Text = misafir.Telefon;
                TxtMail.Text = misafir.Mail;
                TxtAciklama.Text = misafir.Aciklama;
                lookUpEditSehir.EditValue = misafir.sehir;
           lookUpEditÜlke.EditValue = misafir.Ulke;
               lookUpEditİlce.EditValue = misafir.ilce;
              
         //  pictureEditÖn.Image = Image.FromFile(misafir.KimlikFoto1);
          // pictureEditArka.Image = Image.FromFile(misafir.KimlikFoto2);
                resim1 = misafir.KimlikFoto1;
                resim2 = misafir.KimlikFoto2; 


            }


            // ülke listesi

            lookUpEditÜlke.Properties.DataSource = (from x in db.TblUlkes
                                                    select new
                                                    {
                                                        x.UlkeAd,
                                                        x.UlkeID

                                                    }).ToList();
            // şehir listesi 
            lookUpEditSehir.Properties.DataSource = (from x in db.illers
                                                     select new
                                                     {
                                                         ID = x.id,
                                                         Şehir = x.sehir

                                                     }).ToList();
        }

        private void lookUpEditSehir_EditValueChanged(object sender, EventArgs e)
        {
            int secilen;
         secilen = int.Parse(lookUpEditSehir.EditValue.ToString());
            lookUpEditİlce.Properties.DataSource = (from x in db.ilcelers
                                                    select new
                                                    {
                                                        Id = x.id,
                                                        İlçe = x.ilce,
                                                        Şehir = x.sehir
                                                    }).Where(y => y.Şehir == secilen).ToList();
        }
  

        private void pictureEditÖn_EditValueChanged(object sender, EventArgs e)
        {
            resim1 = pictureEditÖn.GetLoadedImageLocation().ToString();
        }

        private void pictureEditArka_EditValueChanged(object sender, EventArgs e)
        {
            resim2 = pictureEditArka.GetLoadedImageLocation().ToString();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        { var deger = repo.Find(x => x.MisafirID == id);
            deger.AdSoyad = TxtAdSoyad.Text;
            deger.TC = TxtTc.Text;
            deger.Mail = TxtMail.Text;
            deger.Telefon = TxtTelefon.Text;
            deger.Adres = TxtAdres.Text;
            deger.Aciklama = TxtAciklama.Text;
            deger.KimlikFoto1 = resim1;
            deger.KimlikFoto2 = resim2;
            deger.Ulke = int.Parse(lookUpEditÜlke.EditValue.ToString());
            deger.sehir = int.Parse(lookUpEditSehir.EditValue.ToString());
            deger.ilce = int.Parse(lookUpEditİlce.EditValue.ToString());
            deger.Durum = 1;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Misafir kartı bilgileri başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
           
            t.AdSoyad = TxtAdSoyad.Text;
            t.TC = TxtTc.Text;
            t.Telefon = TxtTelefon.Text;
            t.Mail = TxtMail.Text;
            t.Adres = TxtAdres.Text;
            t.Aciklama = TxtAciklama.Text;
            t.Durum = 1;
        t.sehir = int.Parse(lookUpEditSehir.EditValue.ToString());
         t.ilce = int.Parse(lookUpEditİlce.EditValue.ToString());
         t.Ulke = int.Parse(lookUpEditÜlke.EditValue.ToString());
            t.KimlikFoto1 = resim1;
            t.KimlikFoto2 = resim2;
            repo.TAdd(t);

            XtraMessageBox.Show("Misafir başarılı şekilde sisteme kaydedildi");

        }
    }
}
