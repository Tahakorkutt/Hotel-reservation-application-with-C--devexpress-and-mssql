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
    public partial class FrmUlke : Form
    {
        public FrmUlke()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();

        private void FrmUlke_Load(object sender, EventArgs e)
        {

            db.TblUlkes.Load();
            bindingSource1.DataSource = db.TblUlkes.Local;
            
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

        private void durumuSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bindingSource1.RemoveCurrent();
            db.SaveChanges();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
          
        }
    }
}
