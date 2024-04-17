
namespace TecnicalService.Formlar
{
    partial class FrmYeniUrun
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYeniUrun));
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lookUpEdit1 = new DevExpress.XtraEditors.LookUpEdit();
            this.TxtStok = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtSFiyat = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAFiyat = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtMarka = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(93, 378);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(94, 29);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "Ekle";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 332);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kategori";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(110, 329);
            this.lookUpEdit1.Name = "lookUpEdit1";
            this.lookUpEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEdit1.Properties.DisplayMember = "AD";
            this.lookUpEdit1.Properties.ValueMember = "ID";
            this.lookUpEdit1.Size = new System.Drawing.Size(125, 22);
            this.lookUpEdit1.TabIndex = 13;
            // 
            // TxtStok
            // 
            this.TxtStok.Location = new System.Drawing.Point(110, 277);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(125, 22);
            this.TxtStok.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stok";
            // 
            // TxtSFiyat
            // 
            this.TxtSFiyat.Location = new System.Drawing.Point(110, 221);
            this.TxtSFiyat.Name = "TxtSFiyat";
            this.TxtSFiyat.Size = new System.Drawing.Size(125, 22);
            this.TxtSFiyat.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Satış Fiyat";
            // 
            // TxtAFiyat
            // 
            this.TxtAFiyat.Location = new System.Drawing.Point(110, 169);
            this.TxtAFiyat.Name = "TxtAFiyat";
            this.TxtAFiyat.Size = new System.Drawing.Size(125, 22);
            this.TxtAFiyat.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alış Fiyat";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(110, 118);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(125, 22);
            this.TxtMarka.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marka";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(110, 63);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(125, 22);
            this.TxtAd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Adı";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.label6);
            this.groupControl1.Controls.Add(this.lookUpEdit1);
            this.groupControl1.Controls.Add(this.TxtStok);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.TxtSFiyat);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.TxtAFiyat);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.TxtMarka);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Location = new System.Drawing.Point(87, 30);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(295, 564);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "groupControl1";
            // 
            // FrmYeniUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 636);
            this.Controls.Add(this.groupControl1);
            this.Name = "FrmYeniUrun";
            this.Text = "FrmYeniUrun";
            this.Load += new System.EventHandler(this.FrmYeniUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.TextEdit TxtStok;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit TxtSFiyat;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit TxtAFiyat;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.TextEdit TxtMarka;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}