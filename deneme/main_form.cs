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
            ürün_islem urun_islem = new ürün_islem();
            
            urun_islem.Show();
        }

        private void xtraTabPage2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}