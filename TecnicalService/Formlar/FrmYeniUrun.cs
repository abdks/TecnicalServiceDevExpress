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
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();

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

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {
            lookUpEdit1.Properties.DataSource = db.TBLKategori.ToList();

        }
    }
}
