namespace deneme
{
    partial class ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ayarlar));
            this.colorPickEdit1 = new DevExpress.XtraEditors.ColorPickEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // colorPickEdit1
            // 
            this.colorPickEdit1.EditValue = System.Drawing.Color.Empty;
            this.colorPickEdit1.Location = new System.Drawing.Point(145, 100);
            this.colorPickEdit1.Name = "colorPickEdit1";
            this.colorPickEdit1.Properties.AutomaticColor = System.Drawing.Color.Black;
            this.colorPickEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.colorPickEdit1.Size = new System.Drawing.Size(172, 24);
            this.colorPickEdit1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 15F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(145, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(172, 30);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "arka planı rengi";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.Location = new System.Drawing.Point(145, 141);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(172, 53);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "arka plan olarak ayarla";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 318);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.colorPickEdit1);
            this.Name = "ayarlar";
            this.Text = "ayarlar";
            ((System.ComponentModel.ISupportInitialize)(this.colorPickEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ColorPickEdit colorPickEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}