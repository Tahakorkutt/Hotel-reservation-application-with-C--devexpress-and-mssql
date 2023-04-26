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

namespace OtelYeniProje.Formlar.Rezervasyon
{
    public partial class FrmRezervasyonKarti : Form
    {
        public FrmRezervasyonKarti()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();

        Repository<TblRezervasyon> repo = new Repository<TblRezervasyon>();
        TblRezervasyon t = new TblRezervasyon();
        public int id;
        private void FrmRezervasyonKarti_Load(object sender, EventArgs e)
        {// misafir listesi
            lookUpEditMisafir.Properties.DataSource = (from x in db.TblMisafirs
                                                        select new
                                                        {
                                                         x.MisafirID,
                                                           x.AdSoyad
                                                        }).ToList();

            // ODA listesi
            lookUpEditOda.Properties.DataSource = (from x in db.TblOdas
                                                       select new
                                                       {
                                                         x.OdaID,
                                                         x.OdaNo,
                                                         x.TblDurum.DurumAd
                                                       }).Where(y=>y.DurumAd=="Aktif").ToList();

            //Durum listesi
            lookUpEditDurum.Properties.DataSource = (from x in db.TblDurums
                                                   select new
                                                   {
                                                    x.DurumId,
                                                    x.DurumAd,
                                                      
                                                   }).ToList();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TblRezervasyon t = new TblRezervasyon();
            t.Misafir = int.Parse(lookUpEditMisafir.EditValue.ToString());
            t.GirisTarih = DateTime.Parse(dateEditGiris.Text);
            t.CikisTarih = DateTime.Parse(dateEditCikis.Text);
            t.Kisi = numericUpDown1.Value.ToString();
            t.Oda = int.Parse(lookUpEditOda.EditValue.ToString());
            t.RezervasyonAdSoyad = TxtRezervasyonAdSoyad.Text;
            t.Telefon = TxtTelefon.Text;
            t.Aciklama = TxtAciklama.Text;
            t.Durum = int.Parse(lookUpEditDurum.EditValue.ToString());
            repo.TAdd(t);
            XtraMessageBox.Show("Rezervasyon başarılı bir şekilde oluşturuldu");

        }
    }
}
