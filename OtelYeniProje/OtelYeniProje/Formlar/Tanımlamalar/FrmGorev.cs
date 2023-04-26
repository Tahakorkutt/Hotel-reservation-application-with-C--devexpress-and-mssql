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
    public partial class FrmGorev : Form
    {
        public FrmGorev()
        {
            InitializeComponent();
        }
        DbOtelYeniEntities1 db = new DbOtelYeniEntities1();

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

        private void FrmGorev_Load(object sender, EventArgs e)
        {
            db.TblGorevs.Load();
            bindingSource1.DataSource = db.TblGorevs.Local;
            repositoryItemLookUpEditDepartman.DataSource = (from x in db.TblDepartmen
                                                        select new
                                                        {

                                                          x.DepartmanID,
                                                          x.DepartmanAd
                                                        }).ToList(); 
      
            repositoryItemLookUpEditDurum.DataSource = (from x in db.TblDurums
                                                        select new
                                                        {

                                                            x.DurumAd,
                                                            x.DurumId
                                                        }).ToList();
        }
    }
}
