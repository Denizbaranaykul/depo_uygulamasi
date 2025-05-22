namespace deneme
{
    partial class ürün_güncelleme
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
            this.components = new System.ComponentModel.Container();
            this.txtUrunAdi = new DevExpress.XtraEditors.TextEdit();
            this.numericFiyat = new System.Windows.Forms.NumericUpDown();
            this.numericStok = new System.Windows.Forms.NumericUpDown();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lookUpUrunler = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.richAciklama = new System.Windows.Forms.RichTextBox();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.btnResimSec = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFiyat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUrunler.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUrunAdi
            // 
            this.txtUrunAdi.Location = new System.Drawing.Point(209, 125);
            this.txtUrunAdi.Name = "txtUrunAdi";
            this.txtUrunAdi.Size = new System.Drawing.Size(136, 24);
            this.txtUrunAdi.TabIndex = 1;
            // 
            // numericFiyat
            // 
            this.numericFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(88)))));
            this.numericFiyat.ForeColor = System.Drawing.SystemColors.Window;
            this.numericFiyat.Location = new System.Drawing.Point(209, 203);
            this.numericFiyat.Name = "numericFiyat";
            this.numericFiyat.Size = new System.Drawing.Size(136, 23);
            this.numericFiyat.TabIndex = 2;
            // 
            // numericStok
            // 
            this.numericStok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(88)))));
            this.numericStok.ForeColor = System.Drawing.SystemColors.Window;
            this.numericStok.Location = new System.Drawing.Point(209, 258);
            this.numericStok.Name = "numericStok";
            this.numericStok.Size = new System.Drawing.Size(136, 23);
            this.numericStok.TabIndex = 3;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.Location = new System.Drawing.Point(434, 258);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(137, 43);
            this.btnGuncelle.TabIndex = 4;
            this.btnGuncelle.Text = "güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(52, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(116, 28);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "ürün seçimi";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(52, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 28);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "ürün adı";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(52, 195);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(102, 28);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "ürün fiyatı";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(52, 258);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(98, 28);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "stok adeti";
            // 
            // lookUpUrunler
            // 
            this.lookUpUrunler.Location = new System.Drawing.Point(208, 49);
            this.lookUpUrunler.Name = "lookUpUrunler";
            this.lookUpUrunler.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpUrunler.Properties.Click += new System.EventHandler(this.lookUpUrunler_EditValueChanged);
            this.lookUpUrunler.Size = new System.Drawing.Size(137, 24);
            this.lookUpUrunler.TabIndex = 9;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(52, 329);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(156, 28);
            this.labelControl5.TabIndex = 10;
            this.labelControl5.Text = "ürün açıklaması";
            // 
            // richAciklama
            // 
            this.richAciklama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(73)))), ((int)(((byte)(88)))));
            this.richAciklama.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.richAciklama.Location = new System.Drawing.Point(231, 329);
            this.richAciklama.Name = "richAciklama";
            this.richAciklama.Size = new System.Drawing.Size(340, 97);
            this.richAciklama.TabIndex = 11;
            this.richAciklama.Text = "";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBoxFoto.Location = new System.Drawing.Point(434, 43);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(137, 138);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 12;
            this.pictureBoxFoto.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(434, 187);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(137, 36);
            this.btnResimSec.TabIndex = 13;
            this.btnResimSec.Text = "fotoğraf ekle";
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // ürün_güncelleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 482);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pictureBoxFoto);
            this.Controls.Add(this.richAciklama);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.lookUpUrunler);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.numericStok);
            this.Controls.Add(this.numericFiyat);
            this.Controls.Add(this.txtUrunAdi);
            this.Name = "ürün_güncelleme";
            this.Text = "ürün_güncelleme";
            this.Load += new System.EventHandler(this.ürün_güncelleme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUrunAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericFiyat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericStok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpUrunler.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.TextEdit txtUrunAdi;
        private System.Windows.Forms.NumericUpDown numericFiyat;
        private System.Windows.Forms.NumericUpDown numericStok;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lookUpUrunler;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.RichTextBox richAciklama;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private DevExpress.XtraEditors.SimpleButton btnResimSec;
    }
}