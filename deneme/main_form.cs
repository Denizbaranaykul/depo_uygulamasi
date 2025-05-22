using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class main_form : DevExpress.XtraEditors.XtraForm
    {
        public main_form()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void navBarControl1_Click(object sender, EventArgs e)
        {
           
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void navBarItem3_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ürün_islem urunEkleForm = new ürün_islem();
            urunEkleForm.Show();
        }

        private void navBarItem4_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ürün_silme ürün_Silme = new ürün_silme();
            ürün_Silme.Show();
        }

        private void navBarItem8_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            ürün_güncelleme ürün_Güncelleme = new ürün_güncelleme();
            ürün_Güncelleme.Show();
        }

        private void navBarItem5_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            stok_rapor stok_Rapor = new stok_rapor();
            stok_Rapor.Show();
        }

        private void navBarItem2_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();

        }
    }
}