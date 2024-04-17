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
    public partial class FrmUrunListe : Form
    {
        public FrmUrunListe()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();
        void metot1() // void anahtar kelimesi eklendi
        {
            var degerler = from u in db.TBLUrun
                           select new
                           {
                               u.ID,
                               u.Ad,
                               u.Marka,
                               Kategori = u.TBLKategori.AD,
                               u.Stok,
                               u.AlısFiyat,
                               u.SatisFiyat
                           };
            gridControl1.DataSource = degerler.ToList(); // Degerler listeye dönüştürüldü
        }

    

    private void FrmUrunListe_Load(object sender, EventArgs e)
        {
            metot1();
            var degerler = db.TBLUrun.ToList();
           
            lookUpEdit1.Properties.DataSource = db.TBLKategori.ToList();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLUrun t = new TBLUrun();
            t.Ad = TxtAd.Text;
            t.Marka = TxtMarka.Text;
            t.AlısFiyat = decimal.Parse(TxtAFiyat.Text);
            t.SatisFiyat = decimal.Parse(TxtSFiyat.Text);
            t.Stok = short.Parse(TxtStok.Text);
            t.Durum = false;
            t.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());

            db.TBLUrun.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürün Kaydedildi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            metot1();

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellDisplayText("Ad").ToString();
            TxtMarka.Text = gridView1.GetFocusedRowCellDisplayText("Marka").ToString();
            TxtAFiyat.Text = gridView1.GetFocusedRowCellDisplayText("AlısFiyat").ToString();
            TxtSFiyat.Text = gridView1.GetFocusedRowCellDisplayText("SatisFiyat").ToString();
            TxtStok.Text = gridView1.GetFocusedRowCellDisplayText("Stok").ToString();

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLUrun.Find(id);
            db.TBLUrun.Remove(deger);
            db.SaveChanges();
            MessageBox.Show("Ürün Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);

        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtID.Text);
            var deger = db.TBLUrun.Find(id);
            deger.Ad = TxtAd.Text;
            deger.Stok = short.Parse(TxtStok.Text);
            deger.Marka = TxtMarka.Text;
            deger.AlısFiyat = decimal.Parse(TxtAFiyat.Text);
            deger.SatisFiyat = decimal.Parse(TxtStok.Text);
            deger.Kategori = byte.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }
    }
}
