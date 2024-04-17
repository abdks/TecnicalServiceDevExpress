
namespace TecnicalService.Formlar
{
    partial class FrmUrunListe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrunListe));
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnList = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
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
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStok.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAFiyat.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Teal;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1208, 1051);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.label7);
            this.groupControl1.Controls.Add(this.BtnList);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.simpleButton2);
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
            this.groupControl1.Location = new System.Drawing.Point(1232, 33);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(295, 564);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "groupControl1";
            // 
            // TxtID
            // 
            this.TxtID.Enabled = false;
            this.TxtID.Location = new System.Drawing.Point(109, 48);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(125, 22);
            this.TxtID.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "IDasdsadsa";
            // 
            // BtnList
            // 
            this.BtnList.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnList.ImageOptions.Image")));
            this.BtnList.Location = new System.Drawing.Point(109, 515);
            this.BtnList.Name = "BtnList";
            this.BtnList.Size = new System.Drawing.Size(94, 29);
            this.BtnList.TabIndex = 18;
            this.BtnList.Text = "Listele";
            this.BtnList.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(109, 467);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(94, 29);
            this.simpleButton3.TabIndex = 17;
            this.simpleButton3.Text = "Güncelle";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(164, 414);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(94, 29);
            this.simpleButton2.TabIndex = 16;
            this.simpleButton2.Text = "Sil";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(42, 414);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(94, 29);
            this.BtnKaydet.TabIndex = 15;
            this.BtnKaydet.Text = "Kaydet";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kategori";
            // 
            // lookUpEdit1
            // 
            this.lookUpEdit1.Location = new System.Drawing.Point(109, 363);
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
            this.TxtStok.Location = new System.Drawing.Point(109, 311);
            this.TxtStok.Name = "TxtStok";
            this.TxtStok.Size = new System.Drawing.Size(125, 22);
            this.TxtStok.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Stok";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // TxtSFiyat
            // 
            this.TxtSFiyat.Location = new System.Drawing.Point(109, 255);
            this.TxtSFiyat.Name = "TxtSFiyat";
            this.TxtSFiyat.Size = new System.Drawing.Size(125, 22);
            this.TxtSFiyat.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Satış Fiyat";
            // 
            // TxtAFiyat
            // 
            this.TxtAFiyat.Location = new System.Drawing.Point(109, 203);
            this.TxtAFiyat.Name = "TxtAFiyat";
            this.TxtAFiyat.Size = new System.Drawing.Size(125, 22);
            this.TxtAFiyat.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alış Fiyat";
            // 
            // TxtMarka
            // 
            this.TxtMarka.Location = new System.Drawing.Point(109, 152);
            this.TxtMarka.Name = "TxtMarka";
            this.TxtMarka.Size = new System.Drawing.Size(125, 22);
            this.TxtMarka.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Marka";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(109, 97);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(125, 22);
            this.TxtAd.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ürün Adı";
            // 
            // FrmUrunListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmUrunListe";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmUrunListe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStok.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAFiyat.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMarka.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
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
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.LookUpEdit lookUpEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private DevExpress.XtraEditors.SimpleButton BtnList;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private System.Windows.Forms.Label label7;
    }
}