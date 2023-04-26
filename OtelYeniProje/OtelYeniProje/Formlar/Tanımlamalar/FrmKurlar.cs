using OtelYeniProje.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OtelYeniProje.Formlar.Tanımlamalar
{
    public partial class FrmKurlar : Form
    {
        public FrmKurlar()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();


        private void FrmKurlar_Load(object sender, EventArgs e)
        {
            db.TblKurs.Load();
            bindingSource1.DataSource = db.TblKurs.Local;
            repositoryItemLookUpEditDurum.DataSource = (from x in db.TblDurums
                                                        select new
                                                        {

                                                            x.DurumAd,
                                                            x.DurumId
                                                        }).ToList();
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            db.SaveChanges();
        }

        private void durumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }
    }
}
