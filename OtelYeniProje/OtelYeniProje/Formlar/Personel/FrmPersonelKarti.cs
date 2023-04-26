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

namespace OtelYeniProje.Formlar.Personel
{
    public partial class FrmPersonelKarti : Form
    {
        public FrmPersonelKarti()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();
        public int id;
        Repository<TblPersonel> repo = new Repository<TblPersonel>();

        private void FrmPersonelKarti_Load(object sender, EventArgs e)
        {
            this.Text = id.ToString();
            if(id != 0)
            {

           
            var personel = repo.Find(x => x.PersonelID == id);
            TxtAdSoyad.Text = personel.AdSoyad;
                TxtTc.Text = personel.TC;
                TxtAdres.Text = personel.Adres;
                TxtTelefon.Text = personel.Telefon;
                TxtMail.Text = personel.Mail;
                dateEditGiris.Text =personel.İseGirisTarih.ToString();
                dateEditGiris.Text = personel.İstenCikisTarih.ToString();
                TxtAciklama.Text = personel.Aciklama;
                TxtŞifre.Text = personel.Sifre;
                pictureEditÖn.Image = Image.FromFile(personel.KimlikÖn);
                pictureEditArka.Image = Image.FromFile(personel.KimlikArka);
                labelControl15.Text = personel.KimlikÖn;
                labelControl3.Text = personel.KimlikArka;

                lookUpEditDepartman.EditValue = personel.Departman;
                lookUpEditGörev.EditValue = personel.Gorev;
               

            }

            lookUpEditDepartman.Properties.DataSource = (from x in db.TblDepartmen
                                                         select new
                                                         {
                                                             x.DepartmanID,
                                                             x.DepartmanAd

                                                         }).ToList();

            lookUpEditGörev.Properties.DataSource = (from x in db.TblGorevs
                                                     select new
                                                     {
                                                       
                                                         x.GörevID,
                                                         x.GörevAd

                                                     }).ToList();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            TxtAdres.Text = pictureEditÖn.GetLoadedImageLocation();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            TblPersonel t = new TblPersonel();
            t.AdSoyad = TxtAdSoyad.Text;
            t.TC = TxtTc.Text;
            t.Adres = TxtAdSoyad.Text;
            t.İseGirisTarih = DateTime.Parse(dateEditGiris.Text);
            t.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            t.Gorev = int.Parse(lookUpEditGörev.EditValue.ToString());
            t.Aciklama = TxtAciklama.Text;
            t.KimlikÖn = pictureEditÖn.GetLoadedImageLocation();
            t.KimlikArka = pictureEditArka.GetLoadedImageLocation();
            t.Mail = TxtMail.Text;
          t.Sifre = TxtŞifre.Text;
            t.Durum = 1;
            repo.TAdd(t);
            XtraMessageBox.Show("Personel başarılı şekilde sisteme kaydedildi");

        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            var deger = repo.Find(x => x.PersonelID == id);
           deger.AdSoyad = TxtAdSoyad.Text;
            deger.TC = TxtTc.Text;
            deger.Adres = TxtAdSoyad.Text;
           deger.Telefon = TxtTelefon.Text;
           // deger.İseGirisTarih = DateTime.Parse(dateEditGiris.Text);
            deger.Departman = int.Parse(lookUpEditDepartman.EditValue.ToString());
            deger.Gorev = int.Parse(lookUpEditGörev.EditValue.ToString());
            deger.Aciklama = TxtAciklama.Text;
            deger.Sifre = TxtŞifre.Text;

            deger.KimlikÖn = labelControl3.Text;
            deger.KimlikArka = labelControl5.Text;
            deger.Mail = TxtMail.Text;
            repo.TUpdate(deger);
            XtraMessageBox.Show("Personel katı bilgileri başarıyla güncellendi");

        }

        private void pictureEditÖn_EditValueChanged(object sender, EventArgs e)
        {
            labelControl15.Text = pictureEditÖn.GetLoadedImageLocation().ToString();
        }

        private void pictureEditArka_EditValueChanged(object sender, EventArgs e)
        {
            labelControl3.Text = pictureEditArka.GetLoadedImageLocation().ToString();

        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }
    }
}
