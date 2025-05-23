using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace deneme
{
	public partial class ayarlar: DevExpress.XtraEditors.XtraForm
	{
        public ayarlar()
		{
            InitializeComponent();
		}

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Form1.main.BackColor=colorPickEdit1.Color;
        }
    }
}