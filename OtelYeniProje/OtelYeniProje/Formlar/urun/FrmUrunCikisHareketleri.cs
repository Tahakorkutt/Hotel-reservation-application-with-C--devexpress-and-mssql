using OtelYeniProje.Entity;
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
    public partial class FrmUrunCikisHareketleri : Form
    {
        public FrmUrunCikisHareketleri()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();

        private void FrmUrunCikisHareketleri_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = (from x in db.TblUrunHarekets
                                       select new
                                       {
                                           x.Haraketid,
                                           x.TblUrun.UrunAd,
                                           x.Miktar,
                                           x.Tarih,
                                           x.HareketTuru

                                       }).Where(y => y.HareketTuru == "Çıkış").ToList();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            FrmÜrünHareketTanimi fr = new FrmÜrünHareketTanimi();
            fr.id = int.Parse(gridView1.GetFocusedRowCellValue("Haraketid").ToString());
            fr.Show();
        }
    }
}
