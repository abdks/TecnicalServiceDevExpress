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
    public partial class FrmYeniKategori : Form
    {
        public FrmYeniKategori()
        {
            InitializeComponent();
        }
        DBTeknikServisEntities db = new DBTeknikServisEntities();

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLKategori t = new TBLKategori();
            t.AD = TxtAd.Text;
          

            db.TBLKategori.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
