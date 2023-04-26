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

namespace OtelYeniProje.Formlar.urun
{
    public partial class FrmÜrünHareketTanimi : Form
    {
        public FrmÜrünHareketTanimi()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();

        Repository<TblUrunHareket> repo = new Repository<TblUrunHareket>();
         TblUrunHareket  t = new TblUrunHareket();
        public int id;

        private void FrmÜrünHareketTanimi_Load(object sender, EventArgs e)
        {

            //id değeri
            TxtID.Text = id.ToString();
            TxtID.Enabled = false;

            //Ürün listesi
            lookUpEditUrun.Properties.DataSource = (from x in db.TblUruns
                                                    select new
                                                    {
                                                        x.UrunID,
                                                        x.UrunAd
                                                    }).ToList();

            //verilerin kart alanlarına doldurulması
            if (id != 0)
            {
                var urun = repo.Find(x => x.Haraketid == id);
                lookUpEditUrun.EditValue = urun.Urun;
                TxtMiktar.Text = urun.Miktar.ToString();
                TxtAciklama.Text = urun.Aciklama;
                comboBox1.Text = urun.HareketTuru;
                dateEdit1.Text = urun.Tarih.ToString();
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            t.Urun = int.Parse(lookUpEditUrun.EditValue.ToString());
            t.Tarih = DateTime.Parse(dateEdit1.Text);
            t.HareketTuru = comboBox1.Text;
            t.Miktar = decimal.Parse(TxtMiktar.Text);
            t.Aciklama = TxtAciklama.Text;
            repo.TAdd(t);
            XtraMessageBox.Show("Ürün hareketi sisteme kaydedildi");
        }

        private void BtnGüncelle_Click(object sender, EventArgs e)
        {
            var urun = repo.Find(x => x.Haraketid == id);
            urun.Urun = int.Parse(lookUpEditUrun.EditValue.ToString());
            urun.Tarih = DateTime.Parse(dateEdit1.Text);
            urun.HareketTuru = comboBox1.Text;
            urun.Miktar = decimal.Parse(TxtMiktar.Text);
            urun.Aciklama = TxtAciklama.Text;
            repo.TUpdate(urun);
            XtraMessageBox.Show("Ürün hareketi başarılı bir şekilde güncellendi");
        }
    }
}
