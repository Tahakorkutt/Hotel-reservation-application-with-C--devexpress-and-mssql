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
    public partial class FrmDepartman : Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();

        public object XtramessageBox { get; private set; }

        private void FrmDepartman_Load(object sender, EventArgs e)
        {
            db. TblDepartmen.Load();
            bindingSource1.DataSource = db.TblDepartmen.Local;
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

                XtraMessageBox.Show("Bilgiler Kaydedilirken hata oluştu, kontrol edip tekrar kontrol ediniz");
            }
        }

        private void durumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
