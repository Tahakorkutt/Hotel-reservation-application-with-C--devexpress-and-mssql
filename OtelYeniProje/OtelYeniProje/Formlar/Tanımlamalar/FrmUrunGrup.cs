using DevExpress.XtraEditors;
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
    public partial class FrmUrunGrup : Form
    {
        public FrmUrunGrup()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();
        private void durumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }

        private void vazgeçToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUrunGrup_Load(object sender, EventArgs e)
        {
            db.TblUrunGrups.Load();
            bindingSource1.DataSource = db.TblUrunGrups.Local;
            repositoryItemLookUpEditDurum.DataSource = (from x in db.TblDurums
                                                        select new
                                                        {

                                                            x.DurumAd,
                                                            x.DurumId
                                                        }).ToList();


        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {

                XtraMessageBox.Show("Hatalı veri girişi lütfen terkar deneyiniz");
            }

        }
    }
}
