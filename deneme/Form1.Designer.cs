namespace deneme
{
    partial class Form1
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.lbl_wrong_password = new DevExpress.XtraEditors.LabelControl();
            this.btn_close = new DevExpress.XtraEditors.SimpleButton();
            this.btn_login = new DevExpress.XtraEditors.SimpleButton();
            this.şifre = new DevExpress.XtraEditors.LabelControl();
            this.kullanıcı_adi = new DevExpress.XtraEditors.LabelControl();
            this.txt_password = new DevExpress.XtraEditors.TextEdit();
            this.txt_user_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btn_kayıt_ol = new DevExpress.XtraEditors.SimpleButton();
            this.lbl_customer_login_wrong = new DevExpress.XtraEditors.LabelControl();
            this.btn_close_customer = new DevExpress.XtraEditors.SimpleButton();
            this.btn_login_customer = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txt_password_customer = new DevExpress.XtraEditors.TextEdit();
            this.txt_user_name_customer = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password_customer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user_name_customer.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.lbl_wrong_password);
            this.panelControl1.Controls.Add(this.btn_close);
            this.panelControl1.Controls.Add(this.btn_login);
            this.panelControl1.Controls.Add(this.şifre);
            this.panelControl1.Controls.Add(this.kullanıcı_adi);
            this.panelControl1.Controls.Add(this.txt_password);
            this.panelControl1.Controls.Add(this.txt_user_name);
            this.panelControl1.Location = new System.Drawing.Point(46, 45);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(386, 229);
            this.panelControl1.TabIndex = 0;
            // 
            // lbl_wrong_password
            // 
            this.lbl_wrong_password.Location = new System.Drawing.Point(134, 147);
            this.lbl_wrong_password.Name = "lbl_wrong_password";
            this.lbl_wrong_password.Size = new System.Drawing.Size(161, 16);
            this.lbl_wrong_password.TabIndex = 6;
            this.lbl_wrong_password.Text = "kullanıcı adı veya şifre yanlış";
            this.lbl_wrong_password.Visible = false;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(18, 170);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(88, 39);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "çıkış";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(152, 170);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(163, 39);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "giriş yap";
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // şifre
            // 
            this.şifre.Location = new System.Drawing.Point(18, 121);
            this.şifre.Name = "şifre";
            this.şifre.Size = new System.Drawing.Size(25, 16);
            this.şifre.TabIndex = 3;
            this.şifre.Text = "şifre";
            // 
            // kullanıcı_adi
            // 
            this.kullanıcı_adi.Location = new System.Drawing.Point(18, 53);
            this.kullanıcı_adi.Name = "kullanıcı_adi";
            this.kullanıcı_adi.Size = new System.Drawing.Size(66, 16);
            this.kullanıcı_adi.TabIndex = 2;
            this.kullanıcı_adi.Text = "kullanıcı adı";
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(124, 118);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(213, 24);
            this.txt_password.TabIndex = 1;
            // 
            // txt_user_name
            // 
            this.txt_user_name.Location = new System.Drawing.Point(124, 50);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(213, 24);
            this.txt_user_name.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(180, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(94, 24);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "satıcı girişi";
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.btn_kayıt_ol);
            this.panelControl2.Controls.Add(this.lbl_customer_login_wrong);
            this.panelControl2.Controls.Add(this.btn_close_customer);
            this.panelControl2.Controls.Add(this.btn_login_customer);
            this.panelControl2.Controls.Add(this.labelControl3);
            this.panelControl2.Controls.Add(this.labelControl4);
            this.panelControl2.Controls.Add(this.txt_password_customer);
            this.panelControl2.Controls.Add(this.txt_user_name_customer);
            this.panelControl2.Location = new System.Drawing.Point(461, 45);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(386, 229);
            this.panelControl2.TabIndex = 2;
            // 
            // btn_kayıt_ol
            // 
            this.btn_kayıt_ol.Location = new System.Drawing.Point(134, 170);
            this.btn_kayıt_ol.Name = "btn_kayıt_ol";
            this.btn_kayıt_ol.Size = new System.Drawing.Size(80, 39);
            this.btn_kayıt_ol.TabIndex = 7;
            this.btn_kayıt_ol.Text = "kayıt ol";
            this.btn_kayıt_ol.Click += new System.EventHandler(this.btn_kayıt_ol_Click);
            // 
            // lbl_customer_login_wrong
            // 
            this.lbl_customer_login_wrong.Location = new System.Drawing.Point(134, 148);
            this.lbl_customer_login_wrong.Name = "lbl_customer_login_wrong";
            this.lbl_customer_login_wrong.Size = new System.Drawing.Size(161, 16);
            this.lbl_customer_login_wrong.TabIndex = 6;
            this.lbl_customer_login_wrong.Text = "kullanıcı adı veya şifre yanlış";
            this.lbl_customer_login_wrong.Visible = false;
            // 
            // btn_close_customer
            // 
            this.btn_close_customer.Location = new System.Drawing.Point(18, 170);
            this.btn_close_customer.Name = "btn_close_customer";
            this.btn_close_customer.Size = new System.Drawing.Size(88, 39);
            this.btn_close_customer.TabIndex = 5;
            this.btn_close_customer.Text = "çıkış";
            this.btn_close_customer.Click += new System.EventHandler(this.btn_close_customer_Click);
            // 
            // btn_login_customer
            // 
            this.btn_login_customer.Location = new System.Drawing.Point(245, 170);
            this.btn_login_customer.Name = "btn_login_customer";
            this.btn_login_customer.Size = new System.Drawing.Size(92, 39);
            this.btn_login_customer.TabIndex = 4;
            this.btn_login_customer.Text = "giriş yap";
            this.btn_login_customer.Click += new System.EventHandler(this.btn_login_customer_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 121);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(25, 16);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "şifre";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(18, 53);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(66, 16);
            this.labelControl4.TabIndex = 2;
            this.labelControl4.Text = "kullanıcı adı";
            // 
            // txt_password_customer
            // 
            this.txt_password_customer.Location = new System.Drawing.Point(124, 118);
            this.txt_password_customer.Name = "txt_password_customer";
            this.txt_password_customer.Size = new System.Drawing.Size(213, 24);
            this.txt_password_customer.TabIndex = 1;
            // 
            // txt_user_name_customer
            // 
            this.txt_user_name_customer.Location = new System.Drawing.Point(124, 50);
            this.txt_user_name_customer.Name = "txt_user_name_customer";
            this.txt_user_name_customer.Size = new System.Drawing.Size(213, 24);
            this.txt_user_name_customer.TabIndex = 0;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(604, 12);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(123, 24);
            this.labelControl5.TabIndex = 3;
            this.labelControl5.Text = "müşteri geçişi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 366);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login screen";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_password_customer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_user_name_customer.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txt_user_name;
        private DevExpress.XtraEditors.LabelControl kullanıcı_adi;
        private DevExpress.XtraEditors.TextEdit txt_password;
        private DevExpress.XtraEditors.LabelControl şifre;
        private DevExpress.XtraEditors.SimpleButton btn_close;
        private DevExpress.XtraEditors.SimpleButton btn_login;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lbl_wrong_password;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl lbl_customer_login_wrong;
        private DevExpress.XtraEditors.SimpleButton btn_close_customer;
        private DevExpress.XtraEditors.SimpleButton btn_login_customer;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txt_password_customer;
        private DevExpress.XtraEditors.TextEdit txt_user_name_customer;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btn_kayıt_ol;
    }
}

