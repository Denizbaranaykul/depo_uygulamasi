namespace deneme
{
    partial class main_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main_form));
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem1 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem2 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem3 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem4 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem5 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarSeparatorItem6 = new DevExpress.XtraNavBar.NavBarSeparatorItem();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.CustomHeaderButtons.AddRange(new DevExpress.XtraTab.Buttons.CustomHeaderButton[] {
            new DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Minus),
            new DevExpress.XtraTab.Buttons.CustomHeaderButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)});
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(1283, 832);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.navBarControl1);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1279, 802);
            this.xtraTabPage2.Text = "DEPO";
            this.xtraTabPage2.Paint += new System.Windows.Forms.PaintEventHandler(this.xtraTabPage2_Paint);
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4,
            this.navBarGroup5});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarSeparatorItem1,
            this.navBarItem2,
            this.navBarSeparatorItem2,
            this.navBarItem3,
            this.navBarSeparatorItem3,
            this.navBarItem4,
            this.navBarSeparatorItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarSeparatorItem5,
            this.navBarItem7,
            this.navBarSeparatorItem6});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 288;
            this.navBarControl1.Size = new System.Drawing.Size(288, 802);
            this.navBarControl1.TabIndex = 2;
            this.navBarControl1.Text = "navBarControl1";
            this.navBarControl1.Click += new System.EventHandler(this.navBarControl1_Click);
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "Kullanıcı";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem1),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem2)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "outurm açan kullanıcı";
            this.navBarItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.ImageOptions.LargeImage")));
            this.navBarItem1.Name = "navBarItem1";
            // 
            // navBarSeparatorItem1
            // 
            this.navBarSeparatorItem1.CanDrag = false;
            this.navBarSeparatorItem1.Enabled = false;
            this.navBarSeparatorItem1.Hint = null;
            this.navBarSeparatorItem1.Name = "navBarSeparatorItem1";
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "oturumu kapat";
            this.navBarItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem2.ImageOptions.SvgImage")));
            this.navBarItem2.Name = "navBarItem2";
            // 
            // navBarSeparatorItem2
            // 
            this.navBarSeparatorItem2.CanDrag = false;
            this.navBarSeparatorItem2.Enabled = false;
            this.navBarSeparatorItem2.Hint = null;
            this.navBarSeparatorItem2.Name = "navBarSeparatorItem2";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "siparişler";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem3),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem4),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "yeni sipariş";
            this.navBarItem3.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem3.ImageOptions.SvgImage")));
            this.navBarItem3.Name = "navBarItem3";
            // 
            // navBarSeparatorItem3
            // 
            this.navBarSeparatorItem3.CanDrag = false;
            this.navBarSeparatorItem3.Enabled = false;
            this.navBarSeparatorItem3.Hint = null;
            this.navBarSeparatorItem3.Name = "navBarSeparatorItem3";
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Siparişler";
            this.navBarItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem4.ImageOptions.SvgImage")));
            this.navBarItem4.Name = "navBarItem4";
            // 
            // navBarSeparatorItem4
            // 
            this.navBarSeparatorItem4.CanDrag = false;
            this.navBarSeparatorItem4.Enabled = false;
            this.navBarSeparatorItem4.Hint = null;
            this.navBarSeparatorItem4.Name = "navBarSeparatorItem4";
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "raporlar";
            this.navBarItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("navBarItem5.ImageOptions.SvgImage")));
            this.navBarItem5.Name = "navBarItem5";
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Stoklar";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.LargeIconsText;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem5),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarSeparatorItem6)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Yeni Stok kartı";
            this.navBarItem6.Name = "navBarItem6";
            // 
            // navBarSeparatorItem5
            // 
            this.navBarSeparatorItem5.CanDrag = false;
            this.navBarSeparatorItem5.Enabled = false;
            this.navBarSeparatorItem5.Hint = null;
            this.navBarSeparatorItem5.Name = "navBarSeparatorItem5";
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Stok kartları";
            this.navBarItem7.Name = "navBarItem7";
            // 
            // navBarSeparatorItem6
            // 
            this.navBarSeparatorItem6.CanDrag = false;
            this.navBarSeparatorItem6.Enabled = false;
            this.navBarSeparatorItem6.Hint = null;
            this.navBarSeparatorItem6.Name = "navBarSeparatorItem6";
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Müşteriler";
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "Ayarlar";
            this.navBarGroup5.Name = "navBarGroup5";
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1279, 802);
            this.xtraTabPage3.Text = "HIZLI SATIŞ";
            // 
            // main_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 832);
            this.Controls.Add(this.xtraTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "main_form";
            this.Text = "main_form";
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarSeparatorItem navBarSeparatorItem6;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
    }
}