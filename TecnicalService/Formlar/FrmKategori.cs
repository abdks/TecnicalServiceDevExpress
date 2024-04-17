using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TecnicalService.Formlar
{
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKategori
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLKategori t = new TBLKategori();
            t.AD = TxtAd.Text;
            db.TBLKategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi");
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKategori
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLKategori.Find(id);
            deger.AD = TxtAd.Text;
           
            db.SaveChanges();
            MessageBox.Show("Kategori Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
